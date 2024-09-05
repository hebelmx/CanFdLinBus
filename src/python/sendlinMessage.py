import ldfparser
from canlib import canlib, Frame
import time

def traverse_ldf(ldf_path):
    # Parse the LDF file
    ldf = ldfparser.parse_ldf_to_dict(ldf_path)
    
    frames = ldf.get('frames', {})
    # for frame in frames:
    #     print(f"Frame: {frame['name']}")
    #     print(f"  ID: {frame['frame_id']}")
    #     print(f"  Publisher: {frame['publisher']}")
    #     print(f"  Length: {frame['length']}")
    #     for signal in frame['signals']:
    #         print(f"  Signal: {signal['signal']}")
    #         print(f"    Offset: {signal['offset']}")

    return frames

def send_lin_message(channel, frame_id, data, bit_rate, times):
    # Open the channel
    ch = canlib.openChannel(channel, canlib.Open.ACCEPT_VIRTUAL)
    ch.setBusOutputControl(canlib.Driver.NORMAL)
    ch.setBusParams(bit_rate)

    # Start the channel
    ch.busOn()

    # Create a LIN frame
    frame = Frame(id_=frame_id, data=data)

    # Send the LIN message


    for _ in range(times):
        ch.write(frame)
        time.sleep(0.2)  # Pause for 10 ms
        print(frame)
    # Stop the channel
    ch.busOff()

    # Close the channel
    ch.close()


def set_bits(data,value, width, offset):
    byte_index = offset // 8
    bit_index = offset % 8
    mask = (1 << width) - 1
    data[byte_index] |= (value & mask) << bit_index
    if bit_index + width > 8:
        data[byte_index + 1] |= (value & mask) >> (8 - bit_index)


def main():
    ldf_path = 'device.ldf'
    frames = traverse_ldf(ldf_path)

    # Example: Sending a specific frame from the parsed LDF
    frame_to_send = frames[0]  # Adjust as needed to select the correct frame
    frame_id = frame_to_send['frame_id']
    frame_length = frame_to_send['length']

     # Form the data for the frame
    data = [0] * frame_length
    set_bits(data, 0x1, 1, 0)   # BCM_RGBb_Slave_Address
    set_bits(data, 0x1, 1, 15)  # BCM_RGBb_Addressing_Type
    set_bits(data, 0xFF, 8, 16) # BCM_RGBb_Red
    set_bits(data, 0xFF, 8, 24) # BCM_RGBb_Green
    set_bits(data, 0xFF, 8, 32) # BCM_RGBb_Blue
    set_bits(data, 0x7F, 7, 40) # BCM_RGBb_Intensity
    set_bits(data, 0x0, 1, 47)  # BCM_RGBb_Normalization_Intensity
    set_bits(data, 0xF, 4, 48)  # BCM_RGBb_Dimming_Ramp
    set_bits(data, 0x0, 3, 53)  # BCM_RGBb_Special_Function
    set_bits(data, 0x0, 1, 56)  # BCM_RGBb_Dimming_Time_Evaluation
    set_bits(data, 0x1, 1, 57)  # BCM_RGBb_Validity
    set_bits(data, 0x1, 1, 58)  # BCM_RGBb_Dimming_Time_Basis
    # Initialize CANlib and send the message
    
    print([f'0x{byte:02X}' for byte in data])

    channel = 0
    bit_rate = canlib.canBITRATE_10K  # Adjust as needed for LIN
    send_lin_message(channel, frame_id, data, bit_rate,100)

    # Send the message 100 times with a 10 ms pause between each send
    
    send_lin_message(channel, frame_id, data, bit_rate,100)
    

if __name__ == "__main__":
    main()

import ldfparser
import binascii


import ldfparser

def traverse_ldf(ldf_path):
    # Parse the LDF file
    ldf = ldfparser.parse_ldf_to_dict(ldf_path)
    
    # Display general information

 # Traverse frames
    print("\nFrames:")
    frames = ldf.get('frames', {})

    for frame in frames:
        print(f"  Frame: {frame['name']}")
        print(f"    ID: {frame['frame_id']}")
        print(f"    Publisher: {frame['publisher']}")
        print(f"    Length: {frame['length']}")
        for signal in frame['signals']:
            print(f"    Signal: {signal['signal']}")
            print(f"      Offset: {signal['offset']}")

 # Traverse signals (if available in the LDF dictionary)
    print("\nSignals:")
    signals = ldf.get('signals', [])

 # Traverse signals
    print("\nSignals:")
    signals = ldf.get('signals', [])
    for signal in signals:
        print(f"  Signal: {signal['name']}")
        print(f"    Width: {signal['width']}")
        print(f"    Initial Value: {signal.get('init_value', 'N/A')}")
        print(f"    Publisher: {signal['publisher']}")
        print(f"    Subscribers: {', '.join(signal['subscribers'])}")



ldf_path = 'device.ldf'
traverse_ldf(ldf_path)

# Load LDF
ldf = ldfparser.parse_ldf(path = "device.ldf")
traverse_ldf(ldf_path)


# Get baudrate from LDF
print(ldf.get_baudrate())




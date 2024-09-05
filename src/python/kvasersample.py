from canlib import canlib

num_channels = canlib.getNumberOfChannels()
print(f"Found {num_channels} channels")
#for ch in range(num_channels):
    #chd = canlib.ChannelData(ch)
    #print(f"{ch}. {chd.channel_name} ({chd.card_upc_no} / {chd.card_serial_no})")

lin =  canlib.ChannelData(0)



# Select the desired channel (0 in this case)
channel = 0
chd = canlib.ChannelData(channel)
print(f"{channel}. {chd.channel_name} ({chd.card_upc_no} / {chd.card_serial_no})")

# Open the channel
ch = canlib.openChannel(channel, canlib.Open.ACCEPT_VIRTUAL)
ch.setBusOutputControl(canlib.Driver.NORMAL)
ch.setBusParams(canlib.canBITRATE_10K)  # You may need to set the appropriate bit rate for LIN

# Initialize the LIN channel

#ch.linSetChannelParams(canlib.LIN_MASTER)  # Set as LIN master; use canlib.LIN_SLAVE for slave

# Start the channel
ch.busOn()

# Prepare a LIN message
lin_id = 0x01  # LIN ID (0x01 is an example, change as needed)
data = [0x12, 0x34, 0x56, 0x78]  # Data bytes (4 bytes in this example)

#frame = Frame(id_=lin_id, data=data, flags=canlib.MessageFlag.LIN)

# Send the LIN message
#ch.write(frame)

# Read a LIN message (if needed)
try:
    frame = ch.read(5000)  # Timeout of 5000 ms
    print(f"Received LIN message: {frame}")
except canlib.CanNoMsg:
    print("No message received")
except canlib.CanError as ex:
    print(f"CAN error: {ex}")

# Stop the channel
ch.busOff()

# Close the channel
ch.close()
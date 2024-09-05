using System.Collections;
using System.Diagnostics;

namespace Parity;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

        GenerateData();

       
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
      
    }

    public byte GenParityBits2(byte masterID, bool parityFlag)
    {
        try
        {
            // Create an array to hold the modified masterID value
            byte[] numArray = new byte[] { masterID };

            // Create a BitArray from the byte array to access individual bits
            BitArray bitArray = new BitArray(numArray);

            // If the parityFlag is true or the masterID is 64 or greater, reset numArray[0] to 0
            if (parityFlag || masterID >= 64)
            {
                numArray[0] = 0;
            }
            else
            {
                // Calculate parity bits using XOR operation
                bool parityBit1 = bitArray[0] ^ bitArray[1] ^ bitArray[2] ^ bitArray[4];
                bool parityBit2 = !(bitArray[1] ^ bitArray[3] ^ bitArray[4] ^ bitArray[5]);

                // Set bits 6 and 7 of numArray[0] based on calculated parity bits
                if (parityBit1)
                {
                    numArray[0] = 64; // Set bit 6
                }

                if (parityBit2)
                {
                    numArray[0] |= 128; // Set bit 7
                }
            }

            // Return the original masterID ORed with the calculated parity bits
            return (byte)(masterID | numArray[0]);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error in GenParityBits2");
            return (byte)(masterID);
        }
    }

    public byte GenParityBits(byte masterID, bool parityFlag)
    {
        byte parity = 0;

        // If forcedRadioButton is checked or masterID >= 64, set parity to 0
        if (!parityFlag && masterID < 64)
        {
            // Calculate P0 and P1 parity bits
            bool p0 = ((masterID & 1) ^ ((masterID >> 1) & 1) ^ ((masterID >> 2) & 1) ^ ((masterID >> 4) & 1)) != 0;
            bool p1 = (((masterID >> 1) & 1) ^ ((masterID >> 3) & 1) ^ ((masterID >> 4) & 1) ^ ((masterID >> 5) & 1)) == 0;

            // Set parity bits based on P0 and P1
            if (p0)
            {
                parity |= 64; // Set bit 6
            }
            if (p1)
            {
                parity |= 128; // Set bit 7
            }
        }

        // Return masterID with parity bits
        return (byte)(masterID | parity);
    }

    public byte GenParityBits3(byte masterID, bool parityFlag)
    {
        byte parity = 0;

        // If forcedRadioButton is not checked and masterID < 64, calculate parity bits
        if (!parityFlag && masterID < 64)
        {
            // Calculate P0 and P1 parity bits
            bool p0 = (((masterID >> 0) & 1) ^ ((masterID >> 1) & 1) ^ ((masterID >> 2) & 1) ^ ((masterID >> 4) & 1)) == 1;
            bool p1 = (((masterID >> 1) & 1) ^ ((masterID >> 3) & 1) ^ ((masterID >> 4) & 1) ^ ((masterID >> 5) & 1)) == 1;

            // Set parity bits based on P0 and P1
            if (p0)
            {
                parity |= 0x40; // Set bit 6
            }
            if (p1)
            {
                parity |= 0x80; // Set bit 7
            }
        }

        // Return masterID with parity bits
        return (byte)(masterID | parity);
    }

    public void GenerateData()
    {
        // Initialize a list to store the results
        List<ResultEntry> results = new List<ResultEntry>();

        try
        {
            AddEntries(results);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error in GenParityBits2");
        }

       
    }

    private void LogEntry(ResultEntry result)
    {
        _logger.LogInformation("Input: {Input}, Output: {Output}, InputHex: {InputHex}, OutputHex: {OutputHex}, ParityFlag: {ParityFlag}",
            result.Input, result.Output, result.InputHex, result.OutputHex, result.ParityFlag);
    }

    private void AddEntries(List<ResultEntry> results)
    {
        // Loop through all masterID values from 0 to 255
        for (byte masterID = 0; masterID <= 255; masterID++)
        {
            // Capture the current value of masterID in a local variable to avoid side effects
            byte capturedMasterID = masterID;
            AddNewEntry(capturedMasterID, results);
        }
    }

    private void AddNewEntry(byte masterID, List<ResultEntry> results)
    {
        // Call GenParityBits2 with parityFlag set to true and false
        var MasterId1 = masterID;
        var MasterId2 = masterID;

        byte resultWithParityTrue = GenParityBits(MasterId1, true);
        byte resultWithParityFalse = GenParityBits(MasterId2, false);

        try
        {
            var result = new ResultEntry
            {
                Input = masterID,
                Output = resultWithParityTrue,
                InputHex = masterID.ToString("X2"),
                OutputHex = resultWithParityTrue.ToString("X2"),
                ParityFlag = true
            };
            results.Add(result);
            LogEntry(result);
            // F0 68 07 48 
            // F0 30
            if (result.OutputHex == "48")
            {
                // Trigger a breakpoint programmatically
                Debugger.Break();
            }

        }

        catch (Exception e)
        {
            _logger.LogError(e, "Error in GenParityBits2 {MasterId} parity {Parity}", masterID, true);
        }
        // Store results in the list
        try
        {
            var result2 = new ResultEntry
            {
                Input = masterID,
                Output = resultWithParityFalse,
                InputHex = masterID.ToString("X2"),
                OutputHex = resultWithParityFalse.ToString("X2"),
                ParityFlag = false
            };

            results.Add(result2);
            LogEntry(result2);
            // F0 68 07 48 
            // F0 30
            if (result2.OutputHex == "48")
            {
                // Trigger a breakpoint programmatically
                Debugger.Break();
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error in GenParityBits2 {MasterId} parity {Parity}", masterID, false);
        }
    }
}

// A class to represent the results of the function call
public class ResultEntry
{
    public byte Input { get; set; }
    public byte Output { get; set; }
    public string InputHex { get; set; }
    public string OutputHex { get; set; }
    public bool ParityFlag { get; set; }
}
using System;

enum HackTool
{
    BruteForce,
    Phishing,
    Backdoor,
    ZeroDay,
    AIOverride,
    QuantumExploit
}

enum SystemType
{
    CorporateServer,
    BankDatabase,
    SmartCityCore,
    MilitaryAI
}

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Create the following enums
            // HackTool > BruteForce, Phishing, Backdoor, ZeroDay, AIOverride, QuantumExploit
            // SystemType > CorporateServer, BankDatabase, SmartCityCore, MilitaryAI

            // The principal program should ask for the user type of system to attack and one or more
            // tools of hacking. Convert the value inserted in respective enum types

            // Implement the necessary logic to determine if the system was hacked, according to the following conditions:
            // CorporateSever > (Phishing or Backdoor) and (BruteForce or ZeroDay)
            // BankDatabase > (ZeroDay and Backdoor) or (QuantumExploit and AiOverride)
            // SmartCityCore > (AIOverride and Backdoor) or (ZeroDay and BruteForce) or (QuantumExploit and Phishing)
            // MilitaryAI > (ZeroDay and AIOverride) and (Backdoor or BruteForce) and (Phishing or QuantumExploit)

            // The program should appear a final message indicating that the system was hacked with success
            // ("System Hacked") or if the attack failed ("System Secure")

            string systemInput = Console.ReadLine();
            SystemType system = (SystemType)Enum.Parse(typeof(SystemType), systemInput);

            string toolsInput = Console.ReadLine();
            string[] toolNames = toolsInput.Split(' ');

            bool bruteForce = false, phishing = false, backdoor = false;
            bool zeroDay = false, aiOverride = false, quantumExploit = false;

            foreach (string toolName in toolNames)
            {
                HackTool tool = (HackTool)Enum.Parse(typeof(HackTool), toolName);
                switch (tool)
                {
                    case HackTool.BruteForce:    bruteForce = true;    break;
                    case HackTool.Phishing:      phishing = true;      break;
                    case HackTool.Backdoor:      backdoor = true;      break;
                    case HackTool.ZeroDay:       zeroDay = true;       break;
                    case HackTool.AIOverride:    aiOverride = true;    break;
                    case HackTool.QuantumExploit:quantumExploit = true; break;
                }
            }

            bool hacked = false;

            switch (system)
            {
                case SystemType.CorporateServer:
                hacked = (phishing || backdoor) && (bruteForce || zeroDay);
                break;

                case SystemType.BankDatabase:
                hacked = (zeroDay && backdoor) || (quantumExploit && aiOverride);
                break;

                case SystemType.SmartCityCore:
                hacked = (aiOverride && backdoor) || (zeroDay && bruteForce) || (quantumExploit && phishing);
                break;

                case SystemType.MilitaryAI:
                hacked = (zeroDay && aiOverride) && (backdoor || bruteForce) && (phishing || quantumExploit);
                break;
            }
            
            Console.WriteLine(hacked ? "System Hacked" : "System Secure");
            
        }
    }
}

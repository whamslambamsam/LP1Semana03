using System;

namespace CyberHack
{
    public class Program
    {
        public enum HackTool
        {
            BruteForce ,
            Phishing ,
            Backdoor ,
            ZeroDay ,
            AIOverride ,
            QuantumExploit
        }

        public enum SystemType
        {
            CorporateServer ,
            BankDatabase ,
            SmartCityCore ,
            MilitaryAI
        }
        
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
        }
    }
}

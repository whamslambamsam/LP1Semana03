using System;
using System.Runtime;

namespace CyberHack
{
    public class Program
    {
        [Flags]
        public enum SystemType
        {
            CorporateServer ,
            BankDatabase ,
            SmartCityCore ,
            MilitaryAI
        }

        [Flags]
        public enum HackTool
        {
            BruteForce ,
            Phishing ,
            Backdoor ,
            ZeroDay ,
            AIOverride ,
            QuantumExploit
        }

        private static void Main(string[] args)
        {
            // Tipo de sistema a atacar
            Console.Write("");
            string answerTarget = Console.ReadLine();
            
            // Ferramentas de hacking (uma ou mais)
            Console.Write("");
            string answerTools = Console.ReadLine();
        }
    }
}

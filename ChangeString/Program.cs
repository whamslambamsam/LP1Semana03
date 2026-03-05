using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("String: ");
            string sentence = Console.ReadLine();
            Console.Write("Caráter: ");
            string character = Console.ReadLine();

            foreach (char c in sentence)
            {
                if (Convert.ToString(c) == character)
                {
                    sentence = sentence.Replace(Convert.ToString(c), "x");
                }
            }

            Console.WriteLine(sentence);
        }
    }
}

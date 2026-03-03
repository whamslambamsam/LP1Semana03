using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                else
                {
                    if (s.Length > 3)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}

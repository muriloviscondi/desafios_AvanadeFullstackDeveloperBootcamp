using System;
using System.Collections.Generic;

namespace _5_PedroBentoMundoOz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> jowels = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == null || line == "")
                {
                    break;
                }

                if (!jowels.Contains(line))
                {
                    jowels.Add(line);
                }
            }

            Console.WriteLine(jowels.Count);
        }
    }
}

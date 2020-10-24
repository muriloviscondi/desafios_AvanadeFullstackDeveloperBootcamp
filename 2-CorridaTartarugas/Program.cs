using System;

namespace _2_CorridaTartarugas
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                int numTurtle = Convert.ToInt32(Console.ReadLine());
                int faster = 0;
                string[] velTurtle = new string[numTurtle];

                velTurtle = Console.ReadLine().Split(" ");


               for (int j = 0; j < velTurtle.Length; j++)
                {
                    if(Convert.ToInt32(velTurtle[j]) > faster)
                    {
                        faster = Convert.ToInt32(velTurtle[j]);
                    }
                }

                if (faster < 10)
                {
                    Console.WriteLine(1);
                }
                else if (faster < 20)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(3);
                }
            }
        }
    }
}

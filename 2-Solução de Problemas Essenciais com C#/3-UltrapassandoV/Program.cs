using System;

namespace _3_UltrapassandoV
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int z = x - 1;

            int i = 2;
            int sum = x;
            int s = 1;

            while (z <= x)
            {
                z = Convert.ToInt32(Console.ReadLine());
            }


            while (sum <= z)
            {
                sum = sum + x + s;
            
                if (sum <= z)
                {
                    i = i + 1;
                    s = s + 1;
                }
            }

            Console.WriteLine(i);
        }
    }
}

using System;

namespace _1_QuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(Math.Pow(i, 2));
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}

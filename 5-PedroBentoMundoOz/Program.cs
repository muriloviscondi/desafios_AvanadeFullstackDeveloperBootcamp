using System;

namespace _5_PedroBentoMundoOz
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJewels = 0;

            string[] jewels = new string[5];
            string[] differentJewelry = new string[5];

            for (int i = 0; i < jewels.Length; i++)
            {
                jewels[i] = Console.ReadLine();

                if (i == 0)
                {
                    differentJewelry[i] = jewels[i];
                }
                else
                {
                    countJewels = 0;
                    for(int j = 0; j < i; j++)
                    {
                        if (jewels[j] == jewels[i])
                        {
                            countJewels++;
                        }

                    }

                    if (countJewels == 0)
                    {
                        differentJewelry[i] = jewels[i];
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < differentJewelry.Length; i++)
            {
                if (differentJewelry[i] != null)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}

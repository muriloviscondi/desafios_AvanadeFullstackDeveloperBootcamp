using System;

namespace _5_PedroBentoMundoOz
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkJowels = Console.ReadLine();
            string[] jowels = new string[200];
            string countString = "";
            int countJowels = 0;
            int countArray = 0;

            while (checkJowels != null)
            {
                if(countArray == 0) {

                countJowels++;
                } else {
                bool status = true;

                for(int i = 0; i < jowels.Length; i++)
                {
                    if(checkJowels == jowels[i])
                    {
                        status = false;
                    }
                }

                if (status)
                {
                    countJowels++;
                }
            }

                jowels[countArray] = checkJowels;
                countArray++;
                checkJowels = Console.ReadLine();
            }
            Console.WriteLine(countJowels);
        }
    }
}

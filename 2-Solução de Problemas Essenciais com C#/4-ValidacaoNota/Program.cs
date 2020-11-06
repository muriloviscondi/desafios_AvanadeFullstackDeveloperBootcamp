using System;

namespace _4_ValidacaoNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = 0;
            double grade = 0;

            while (true)
            {
                double enterGrade = Convert.ToDouble(Console.ReadLine());

                if (0 > enterGrade || 10 < enterGrade)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    grade += enterGrade;
                    count++;

                    if (count == 2)
                    {
                        break;
                    }
                    
                }
            }

            double media = grade / count;
            Console.WriteLine($"media = {media:N2}");
        }
    }
}

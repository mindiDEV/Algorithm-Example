using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_e_to_the_Nth_Digit
{
    class Program
    {
        public static void CaculateEOfDigits()
        {
            int number, n, x, power;
            double e = 1;
            double ex = 1;

            Console.WriteLine("Enter a number to get its factorial : ");
            number = Convert.ToInt32(Console.ReadLine());

            x = number;

            while (number > 0)
            {
                n = number;
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }

                //e += Convert.ToDouble(1) / n;

                //for (power = 1; power <= number; power++)
                //{
                //    ex += Convert.ToDouble(Math.Pow(x, power) / n);
                //}

                number--;

                Console.WriteLine("Factorial of {0}! = {1}\n", number + 1, n);

            }
        }
        static void Main(string[] args)
        {
            CaculateEOfDigits();
        }
    }
}

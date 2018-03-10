using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_PI_to_the_Nth_Digits
{
    class Program
    {

        static public IEnumerable<uint> Pi()
        {
            uint[] x = new uint[short.MaxValue];
            
            uint[] r = new uint[short.MaxValue];

            for (int j = 0; j < short.MaxValue; j++)
                x[j] = 20;

            for ( int i = 0; i < short.MaxValue; i++)
            {
                uint carry = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    uint num = (uint)(x.Length - j - 1);
                    uint dem = num * 2 + 1;

                    x[j] += carry;

                    uint q = x[j] / dem;
                    r[j] = x[j] % dem;

                    carry = q * num;
                }

                yield return (x[x.Length - 1] / 10);

                r[x.Length - 1] = x[x.Length - 1] % 10; ;
                for (int j = 0; j < x.Length; j++)
                {
                    x[j] = r[j] * 10;
                }
            }
        }



        public static string CalculatePi(int digits)
        {
            digits++;

            uint[] x = new uint[digits * 10 / 3 + 2];
            uint[] r = new uint[digits * 10 / 3 + 2];

            uint[] pi = new uint[digits];

            for (int j = 0; j < x.Length; j++)
                x[j] = 20;

            for (int i = 0; i < digits; i++)
            {
                uint carry = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    uint num = (uint)(x.Length - j - 1);
                    uint dem = num * 2 + 1;

                    x[j] += carry;

                    uint q = x[j] / dem;
                    r[j] = x[j] % dem;

                    carry = q * num;
                }


                pi[i] = (x[x.Length - 1] / 10);


                r[x.Length - 1] = x[x.Length - 1] % 10; ;

                for (int j = 0; j < x.Length; j++)
                    x[j] = r[j] * 10;
            }

            var result = "";

            uint c = 0;

            for (int i = pi.Length - 1; i >= 0; i--)
            {
                pi[i] += c;
                c = pi[i] / 10;

                result = (pi[i] % 10).ToString() + result;
            }

            return result;
        }

        public static int GetNumber()

        {
            return 5;

        }
        public static IEnumerable<int>GetNumber_2()
        {
            yield return 5;
            yield return 10;
            yield return 15;
        }




        static void Main(string[] args)
        {

            Console.Write("Input digits of PI : ");
            int count = int.Parse(Console.ReadLine());
            foreach (uint digits in Pi().Take(count))
            {
                Console.Write(digits);
            }
            Console.Read();




        }

       
    }
}

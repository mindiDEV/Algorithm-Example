using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Topic : Write a program that prints the integers from 1 to 100.
             * But for multiples of three print "Fizz" instead of the number, and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
             */

            //here 3 is fizz, here 5 is buzz
            //int[] _letNumber = new int[100];

            for (int num = 1; num < 100; num++)
            {
                if (num % 15 ==0)
                {
                    Console.WriteLine("fizz buzz");

                }
                else if(num % 3 == 0 )
               
                {
                    Console.WriteLine("fizz");
                }
                else if(num % 5 == 0)
                {
                    Console.WriteLine("buzz");

                }
                else
                {
                    Console.WriteLine(num);
                }
            }


        }
    }
}

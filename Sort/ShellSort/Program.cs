using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        public static void InputArray(ref int[] a, ref int n)
        {

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the values of arrays " + i + " : ");
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
        public static void OutputArray(int[] a, int n)
        {
            Console.WriteLine("Array is : ");
            for (int i = 0; i < n; i++)
            {

                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Ascendings the sort by Shell Sort
        /// </summary>
        /// <param name="a">a. Vùng nhớ của mảng</param>
        /// <param name="n">The n. Số lượng phần tử của mảng</param>
        /// <param name="divideBy">The divide by. Số bị chia trong thuật toán Shell Sort</param>
        public static void AscendingSort(int[] a, int n)
        {
            n = a.Length;
            int gap = n / 2;
            int temp;
            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = a[j];
                    while (j - gap >= 0 && temp < a[j - gap])
                    {
                        a[j] = a[j - gap];
                        j = j - gap;
                    }
                    a[j] = temp;
                }
                gap = gap / 2;
            }
        }

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] h = new int[n];
            InputArray(ref a, ref n);
            OutputArray(a, n);
            Console.WriteLine("Array after ascending sort by shell sort");
            AscendingSort(a, n);
            OutputArray(a, n);
        }
    }
}

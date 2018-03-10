using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        public static void InputArray(ref int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the elements of array [" + i + "] : ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        /// <summary>
        /// Ascendings the sort by BubbleSort
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="n">The n.</param>
        public static void AscendingSort(int []a,int n)
        {
            for(int i =0;i<n;i++)
            {
                for(int j = n-1;j>i;j--)
                {
                    if(a[j-1]> a[j])
                    {
                        Swap(ref a[j - 1], ref a[j]);
                    }
                }
            }
        }
        public static void DescendingSort(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (a[j - 1] < a[j])
                    {
                        Swap(ref a[j - 1], ref a[j]);
                    }
                }
            }
        }
        public static void OutputArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Swap(ref int a, ref int b)
        {
            int temporary = a;
            a = b;
            b = temporary;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of elements in arrays : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            InputArray(ref a, n);
            OutputArray(a, n);
            Console.WriteLine("Arrays after ascending sort by bubble sort : ");
            AscendingSort(a, n);
            OutputArray(a, n);
            Console.WriteLine("Arrays after descending sort by bubble sort : ");
            DescendingSort(a, n);
            OutputArray(a, n);
        }
    }
}

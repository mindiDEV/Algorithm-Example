using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        /// <summary>
        /// Inputs the array.
        /// </summary>
        /// <param name="a">a.Phần tử của mảng</param>
        /// <param name="n">The n.Số lượng phần tử của mảng</param>
        public static void InputArray(ref int[]a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the elements of array [" + i + "] : ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void OutputArray(int []a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Swap(ref int a,ref int b)
        {
            int temporary = a;
            a = b;
            b = temporary;
        }

        /// <summary>
        /// Ascendings the sort by Selection Sort
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="n">The n.</param>
        public static void AscendingSort(int []a,int n)
        {
            for(int i =0;i<n-1;i++)
            {
                int min = i;
                for(int j = i+1;j<n;j++)
                {
                    if(a[min] > a[j])
                    {
                        min = j;
                    }
                }
                Swap(ref a[min], ref a[i]);
            }
        }
        /// <summary>
        /// Descendings the sort by Selection Sort
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="n">The n.</param>
        public static void DescendingSort(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[min] < a[j])
                    {
                        min = j;
                    }
                }
                Swap(ref a[min], ref a[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of elements in array : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            InputArray(ref a, n);
            OutputArray(a, n);

            Console.WriteLine("Arrays after ascending sort by selection sort : " );
            AscendingSort(a, n);
            OutputArray(a, n);

            Console.WriteLine("Arrays after descending sort by selection sort : ");
            DescendingSort(a, n);
            OutputArray(a, n);

        }
    }
}

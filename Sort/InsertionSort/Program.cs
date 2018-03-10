using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
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
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        /// <summary>
        /// Ascendings the sort by Insertion Sort
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="n">The n.</param>
        public static void AscendingSort(ref int[]a,int n)
        {
            int x, pos;
            for (int i=1;i<n;i++)
            {
                //pos : lưu phần tử a[i] 
                x = a[i];
                pos = i - 1;
                //Tìm vị trí để chèn j vào phía trước
                while ((pos>=0) && (a[pos] > x))
                {
                    //Dời chỗ nó đi
                    a[pos + 1] = a[pos];
                    //Tiếp tục tìm
                    pos--;
                }

                //chèn x vào đây
                a[pos + 1] = x;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of array : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            InputArray(ref a, ref n);
            OutputArray(a, n);
            AscendingSort(ref a, n);
            Console.WriteLine("Arrays after ascending sort by insertion sort");
            OutputArray(a, n);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterchangeSort
{
    class Program
    {
        public static void InputArray( ref int []a, int n)
        {
           
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the values of arrays " + i + " : ");
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
        public static void OutputArray(int []a,int n)
        {
            Console.WriteLine("Array is : ");
            for (int i = 0; i < n; i++)
            {
                
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Swap(ref int a,ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        public static void AscendingSort(ref int []a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j = i+1;j<n;j++)
                {
                    if(a[i] > a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }

        public static void DescendingSort(ref int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        public static int MaxNumberArray(int[] a, int n)
        {
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        
        public static int MinNumberArray(int []a,int n)
        {
            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }



        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of array : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            InputArray(ref a, n);
            OutputArray(a, n);
            Console.WriteLine("Arrays after ascending sort by interchange sort : ");
            AscendingSort(ref a, n);
            OutputArray(a, n);
            Console.WriteLine("Arrays after descending sort by interchange sort : ");
            DescendingSort(ref a, n);
            OutputArray(a, n);
            int res = MaxNumberArray(a, n);
            Console.WriteLine("Max number in arrays is : " + res);
            int res2 = MinNumberArray(a, n);
            Console.WriteLine("Max number in arrays is : " + res2);
        }
    }
}

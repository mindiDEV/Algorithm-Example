using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HeapSort
{

    class Program
    {

        /// <summary>
        /// Hàm hỗ trợ tạo cây theo đúng thứ tự
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="n">The n.</param>
        /// <param name="i">The i.</param>
        public static void Heapify(int[] a, int n, int i)
        {
            while (i <= n / 2 - 1)
            {
                int left = 2 * i + 1;
                int right = 2 * i + 2;
                int max = left;
                if(right<n && a[right] > a[max])
                {
                    max = right;
                }
                //So với node cha
                //Nếu thằng cha bé hơn thằng max vừa tìm được thì đổi chổ
                if (a[i] < a[max])
                {
                    Swap(ref a[i], ref a[max]);
                }
                i = max;
            }
        }
        /// <summary>
        /// Hàm tạo cây
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="n">The n.</param>
        public static void BuildHeap(int []a,int n)
        {
            for(int i = n/2-1;i>=0;i--)
            {
                Heapify(a, n, i);
            }
        }
        public static void HeapSort(int []a,int n)
        {
            //Đầu tiên là xây dựng mảng thành cây
            BuildHeap(a, n);
            //Xét từ cuối cây lên đầu
            for (int i=n-1;i>=0;i--)
            {
                //Hoán vị 
                //a[i] là node đang xét
                Swap(ref a[0], ref a[i]);
                //Hiệu chỉnh lại node
                //i : là thằng đã hoán vị
                Heapify(a, i, 0);

            }
        }
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
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
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            InputArray(ref a, ref n);
            OutputArray(a, n);
            Console.WriteLine("Arrays after ascending sort by heap sort : ");
            HeapSort(a, n);
            OutputArray(a, n);  
        }
    }
}

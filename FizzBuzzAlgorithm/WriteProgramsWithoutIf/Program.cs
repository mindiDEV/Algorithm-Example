using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteProgramsWithoutIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x : ");
            int x = int.Parse(Console.ReadLine());
            int y;

            #region "Dùng IF"

            //if(x>6)
            //{
            //    y = 8;
            //}
            //else
            //{
            //    y = 27;
            //}
            //Console.WriteLine("y = " + y);
            #endregion

            #region "Không Dùng IF - Cách 1"
            //y = (x > 6) ? 8 : 27;
            //Console.WriteLine("y = " + y);
            #endregion

            #region "Không Dùng IF - Cách 2"
            //y = 27;
            //while(x>6)
            //{
            //    y = 8;
            //    x = 0;
            //}
            //Console.WriteLine("y = " + y);
            #endregion

            #region "Không Dùng IF - Cách 3"
            int s = (int)(((x - 6) & 0x88888888) >> 31);
            y = (27 * s) + (8 * (1 - s));
            Console.WriteLine("y = " + y);

            #endregion
        }
    }
}

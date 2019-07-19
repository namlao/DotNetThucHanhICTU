using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Chuong1
{
    class Bai3Cach2
    {
        static void Main(string []args)
        {
            int temp, a, b;
            a = Math.Abs(Int32.Parse(Console.ReadLine()));
            b = Math.Abs(Int32.Parse(Console.ReadLine()));

            while (b!=0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

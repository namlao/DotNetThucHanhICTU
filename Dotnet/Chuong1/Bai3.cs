using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Chuong1
{
    class Bai3
    {
        //Cach 1
        static void Main(string[] args)
        {
            int a, b;
            a = Math.Abs(Int32.Parse(Console.ReadLine()));

            b = Math.Abs(Int32.Parse(Console.ReadLine()));
          

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Khong co ucln");
            }

            while(a!= b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine("ucln la: "+ a);
            Console.ReadLine();

        }
      


       
    }
}

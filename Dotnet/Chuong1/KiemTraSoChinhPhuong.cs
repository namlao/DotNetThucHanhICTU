using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Chuong1
{
    class KiemTraSoChinhPhuong
    {
        
        static void Main(String[] args)
        {
            int number;
            Console.WriteLine("Nhap n: ");
            number = Int32.Parse(Console.ReadLine());
            if(Math.Sqrt(number) == (int)Math.Sqrt(number))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();

        }

    }
}

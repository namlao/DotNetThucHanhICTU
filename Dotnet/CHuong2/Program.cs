using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.CHuong2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo();
            p1.NhapSo();
           PhanSo p2 = new PhanSo();
            p2.NhapSo();

            Console.WriteLine("Phan so 1: ");
            p1.XuatPhanSo();
            Console.WriteLine("Phan so 2: ");
            p2.XuatPhanSo();

            PhanSo ps;
            PhanSo p3 = new PhanSo();
            ps = p3.CongPhanSo(p1,p2);
            Console.WriteLine("Ket qua: {0}",ps);
            Console.ReadLine();
        }
    }
}

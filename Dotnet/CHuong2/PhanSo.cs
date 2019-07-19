using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.CHuong2
{
    class PhanSo
    {
        public int tuSo{set; get;}
        public int mauSo{set; get;}


        public void NhapSo()
        {
            Console.WriteLine("Nhap tu so: ");
            
            this.tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            this.mauSo = int.Parse(Console.ReadLine());
        }
        public void XuatPhanSo()
        {
            Console.WriteLine("Phan so la: "+this.tuSo +"/"+this.mauSo );
            
        }
        

        public PhanSo CongPhanSo(PhanSo p1, PhanSo p2)
        {

            PhanSo p3 = new PhanSo();
            p3.tuSo = p1.tuSo * p2.mauSo + p2.tuSo * p1.mauSo;
            p3.mauSo = p1.mauSo * p2.mauSo;
            return p3;
        }


    }
}

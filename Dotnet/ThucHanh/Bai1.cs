using System;
using System.Collections.Generic;
using Dotnet.ThucHanh;

namespace Dotnet.ThucHanh
{
    class Bai1
    {
        public double canhA { get; set; }
        public double canhB { get; set; }
        public double canhC { get; set; }
        
        public  double dienTich { get; set; }
        public  double chuVi { get; set; }

        public static Boolean TamGiacDeu(double canhA, double canhB, double canhC)
        {

            if (canhA == canhB && canhB == canhC && canhC == canhA)
            {
                return true;
            }
            return false;
        }

        public static Boolean TamGiacCan(double canhA, double canhB, double canhC)
        {

            if (canhA == canhB && canhB == canhC || canhA == canhB && canhA == canhC || canhA == canhC && canhB == canhC)
            {
                return true;
            }
            return false;
        }

        

        public static Boolean TamGiacVuongCan(double canhA, double canhB, double canhC)
        {

            if (TamGiacCan(canhA, canhB, canhC))
            {
                if (Math.Pow(canhA, 2) == Math.Pow(canhB, 2) + Math.Pow(canhC, 2))
                {
                    return true;
                }
            }
            return false;
        }
        public static double ChuVi(double canhA, double canhB, double canhC)
        {
            double chuVi = canhA + canhB + canhC;
            return chuVi;
        }
        public static double DienTich(double canhA, double canhB, double canhC)
        {
            double P = ChuVi(canhA, canhB, canhC);
            double dienTich = Math.Sqrt(P * (P - canhA) * (P - canhB) * (P - canhC)); ;

            return dienTich;
        }
        public void Nhap()
        {
            Console.WriteLine("canh A: ");
            this.canhA = double.Parse(Console.ReadLine());
            Console.WriteLine("canh B: ");
            this.canhB = double.Parse(Console.ReadLine());
            Console.WriteLine("canh C: ");
            this.canhC = double.Parse(Console.ReadLine());
        }
        public string Xuat()
        {
            if (TamGiacDeu(canhA, canhB, canhC))
            {
                return "Tam giac deu";
            }
            else if (TamGiacCan(canhA, canhB, canhC))
            {
                return "Tam giac can";
            }
            else if (TamGiacVuongCan(canhA, canhB, canhC))
            {
                return "Tam giac vuong can";
            }
            else
            {
                return "Tam giac thuong";
            }
            

        }

        public static void Main(string[] args)
        {
            Bai1 b1 = new Bai1();
            b1.Nhap();

            Console.WriteLine(b1.Xuat());
           
            Console.ReadLine();
            
            
        }

    }
}

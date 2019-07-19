using System;
using System.Collections.Generic;
using Dotnet.ThucHanh;


namespace Dotnet.ThucHanh
{
    class Bai2 : Bai1
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            Bai1[] tamGiac = new Bai1[n];
            //Nhập mảng tam giac
            for(int i = 0;i < n; i++)
            {
                tamGiac[i].Nhap();
            }
            //xuất tên mảng tam giac
            for(int i = 0; i < n; i++)
            {
                tamGiac[i].Xuat();
            }
              
            //sắp xếp diện tích
           /* for (int i = 0; i < n; i++)
                for(int j = 0; j < n; j++)
                {

                }
           */
        }
    }
}   

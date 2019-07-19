using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Chuong1
{
    class Array1
    {

        static void Main(string[] args)
        {
            int max = Int32.Parse(Console.ReadLine());
            int[] array = new int[max];
            List<int> li = new List<int>();

            for (int i = 0; i < max; i++)
            {
                int k = int.Parse(Console.ReadLine());
                li.Add(k);
            }
            /*
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = Int32.Parse(Console.ReadLine());
                    }
                    //mang goc
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);

                    }
                    //sap xep
                    for(int i = 0; i <= array.Length; i++)
                    {
                        for(int j = i+1;)
                    }
                    */
            Console.ReadLine();
        }

    }
}


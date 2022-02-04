using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaHomework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[100];

            for(int i =0; i < 100; i++) // Dizi elemanları verdiğim kurala göre dolduruluyor.
            {
                dizi[i] = i * 5;
            }

            foreach(int item in dizi)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }
    }
}

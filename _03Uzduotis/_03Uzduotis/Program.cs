using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Uzduotis
{
    //3.Indėlininkas į banką padėjo suma litų. Bankas moka 2proc. metinių palūkanų. 
    // Sudarykite programą dviejų metų apskaitai skaičiuoti. Ekrane išveskite palūkanas ir turimą indėlį kasmet.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite ideta indeli");
            double deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kiek metu laikysite");
            double years = Convert.ToDouble(Console.ReadLine());
            double intrest = 0.02;
            for (int i = 0; i < years; i++)
            {
                double intrestSum = deposit* intrest;
                Console.WriteLine("{0} metu indelis yra {1:0.00} ir palukanu suma yra {2:0.00}", i+1,deposit, intrestSum);
                deposit += intrestSum;
            }
        }
    }
}

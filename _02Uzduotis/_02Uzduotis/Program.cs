using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Uzduotis
{
    //2.Žinomi kambario matmenys –ilgis ir plotis.Abu dydžiai sveikieji skaičiai.Reikia apskaičiuoti, kokią pinigų sumą reiks mokėti už plyteles,
    // skirtas kambario grindims kloti, jei plytelių vieno kvadrato kaina yra kaina litų. Plytelių reikia pirkti 5 proc.daugiau galimiems nuostoliams padengti
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kambario ilgi");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kambario ploti");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite plyteliu kvadrato kaina");
            double price = Convert.ToDouble(Console.ReadLine());
            double payment = (lenght * width * 1.05) * price;
            Console.WriteLine("moketi reikes {0:0.00}", payment);

        }
    }
}

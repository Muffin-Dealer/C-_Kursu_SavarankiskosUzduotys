using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Uzduotis
{
    class Program
    {
        //1.Parašykite programą, kuri apskaičiuotų, kiek popieriaus lapų k reikės norint nukopijuoti konspektą visos klasės mokiniams.
        //Žinoma kad klasėje yra m mokinių o konspektą sudaro n lapų.Pvz.: m=20, n=10, tai atsakymas 200
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite mokiniu skaiciu");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite lapu skaiciu");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = m * n;
            Console.WriteLine("reikes {0} lapu", k);
        }
    }
}

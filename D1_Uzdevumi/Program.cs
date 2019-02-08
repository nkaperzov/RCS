using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd6();
            //lai konsole paliek atverta
            
            Console.Read();
        }

        static void uzdevums2()
        {

            Console.Write("Ievadi skaitlis 1: ");

            int skaitlis1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi skaitlis 2: ");

            int skaitlis2 = int.Parse(Console.ReadLine());

            int summa = skaitlis1 + skaitlis2;
            int starpiba = skaitlis1 - skaitlis2;
            int reizinajums = skaitlis1 * skaitlis2;
            float dalijums = skaitlis1 / (float)skaitlis2;

            Console.WriteLine("summa= " + summa);
            Console.WriteLine("starpiba= " + starpiba);
            Console.WriteLine("reizinajums= " + reizinajums);
            Console.WriteLine("Dalijums= " + dalijums);
        }
        static void uzd5()
        {
            Console.Write("Ievadi gradi pec Celsija: ");
            int gr = int.Parse(Console.ReadLine());
            float Kelvin = (float) gr + (float)273.15;
            //vai 273.15f
            float Fr = (float) gr * 9 / 5 + 32;

            Console.WriteLine("Kelvin = " + Kelvin);
            Console.WriteLine("Farenheita = " + Fr);
        }
        static void uzd6()
        {
            Console.Write("Ievadi sk1: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi sk2: ");
            int sk2 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi sk3: ");
            int sk3 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi sk4: ");
            int sk4 = int.Parse(Console.ReadLine());

            float Ave = (sk1 + sk2 + sk3 + sk4) / 4f;

            Console.WriteLine("Avarage bus: " + Ave);
        }
    }
}

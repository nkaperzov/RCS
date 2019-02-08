using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd5();
            Console.Read();

        }
        static void uzd1()
        {
            Console.WriteLine("Ievadi N skaitli: ");
            int N = int.Parse(Console.ReadLine());
            if (N % 3 == 0)
            {
                Console.WriteLine("ja");
            }
            else
            {
                Console.WriteLine("ne");
            }

        }

        static void uzd2()
        {
            Console.WriteLine("Ievadi N skaitli: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = N; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

        }
        static void uzd3()
        {
            Console.WriteLine("Ievadi N skaitli: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i == 5)
                {

                    continue;
                }
                Console.WriteLine(i);
            }
        }
        static void uzd4()
        {
            Console.WriteLine("Ievadi dienu ( P, O, T, C, Pk, Se, Sv): ");
            string diena = Console.ReadLine();
            Console.WriteLine("Vai ir atvalinajums? (J vai N) ");
            string atvl = Console.ReadLine();

            if (atvl == "J")
            {
                if (diena == "P")
                {
                    Console.WriteLine("10.00");
                }
                if (diena == "O")
                {
                    Console.WriteLine("10.00");
                }
                if (diena == "T")
                {
                    Console.WriteLine("10.00");
                }
                if (diena == "C")
                {
                    Console.WriteLine("10.00");
                }
                if (diena == "Pk")
                {
                    Console.WriteLine("10.00");
                }
                if (diena == "Se")
                {
                    Console.WriteLine("off");
                }
                if (diena == "Sv")
                {
                    Console.WriteLine("off");
                }

            }
            if (atvl == "N")
            {
                if (diena == "P")
                {
                    Console.WriteLine("7.00");
                }
                if (diena == "O")
                {
                    Console.WriteLine("7.00");
                }
                if (diena == "T")
                {
                    Console.WriteLine("7.00");
                }
                if (diena == "C")
                {
                    Console.WriteLine("7.00");
                }
                if (diena == "Pk")
                {
                    Console.WriteLine("7.00");
                }
                if (diena == "Se")
                {
                    Console.WriteLine("10.00");
                }
                if (diena == "Sv")
                {
                    Console.WriteLine("10.00");
                }

                //switch(diena)
                //{
                //    case "P":
                //    case "O":
                //    case "T":
                //    case "C":
                //    case "Pk":
                //        if(atvl == "J")
                //        {
                //            Console.Write("10.00");
                //        }
                //        else
                //        {
                //            Console.Write("7.00");
                //        }
                //        ///2.var.
                //        /// Console.Write(atvalinajums == "J" ? "10.00" : "07.00");
                //        break;
                //    case "Se":
                //    case "Sv":
                //        Console.Write(atvl == "J" ? "Off" : "10.00");
                //        break;
                //    default:
                //        Console.Write("Neatlauta vertiba");
                //        break;



            }

        }



        static void uzd5()
        {
            Console.WriteLine("Ievadi vertibu A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadi vertibu B: ");
            int B = int.Parse(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }

            }
        }
        static void uzd6()
        {
            Console.WriteLine("Pieejamas darbibas: ");
            Console.WriteLine("1 - iemaksat");
            Console.WriteLine("2 - pirkt");
            Console.WriteLine("3 - sanemt atlikumu");
            Console.WriteLine("e - partraukt");

            DzerienuAutomats dzerienu = new DzerienuAutomats();

            while (true)
            {
                Console.Write("Ievadi darbibu: ");
                string darbiba = Console.ReadLine();

                

                switch(darbiba)
                {
                    case "e":
                        return; //partrauc gan switch, gan while
                    case "1":
                        Console.Write("Ievadi summu: ");
                        double summa = double.Parse(Console.ReadLine());

                        dzerienu.Iemaksat(summa);
                        break;
                    case "2":
                        dzerienu.PirktDzerienu();
                        break;
                    case "3":
                        dzerienu.SanemtAtlikumu();
                        break;
                }
            }
        }
    }
}










using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd11();

            Console.ReadLine();
        }
        static void MD5()
        {
            Console.WriteLine("Ievadi savu vecumu: ");
            int vecums = int.Parse(Console.ReadLine());
            if (vecums >= 18) Console.WriteLine("Jus esat pilngadigs");
            if (vecums < 18) Console.WriteLine("Jus neesat pilngadigs");

            //vai
            // if(vecums>=18)
            // {
            // Console.Write ("Tu esi pilngadigs!");
            // }
            //else
            // {
            // Console.Write("Tu neesi pilngadigs!");
            // }
            // else if(vecums ==18)
            
        }
        static void uzd7()
        {
            Console.WriteLine("Ievadi skaitlis1: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadi skaitlis2: ");
            int sk2 = int.Parse(Console.ReadLine());

            if (sk1 == sk2)
            {
                Console.Write("Skaitli ir vienadi");
            }
            else
            {
                Console.WriteLine("Skaitli nav vienadi");
            }
            //vai:
            // CONDITION ? TRUE : FALSE
            Console.Write(sk1 == sk2 ? "Skaitli ir vienadi!" : "Skatli nav vienadi!");

            if (sk1 == sk2 && sk1 == 5)
            {
                //skaitli ir vienadi UN abi ir 5
            }
            if (sk1 == sk2 || sk1 ==5)
            {
                // Skaitli ir vinadi VAI 1.skaitlis ir 5
            }
            
        }
        static void uzd8()
        {
            Console.Write("Ievadi menesi: ");
            Console.ReadLine();

            string menesis = Console.ReadLine();

            if (menesis == "jan")
            {
                Console.Write(31);
            }
            else if (menesis == "feb")
            {
                Console.Write(28);
            }
            else if (menesis == "mar")
            {
                Console.Write(31);
            }
            //utt


            // 2. variants

            if (menesis == "apr" || menesis == "jun" || menesis == "sep")
                {
                Console.Write("30 dienas");
            }

            else if (menesis == "feb")
            {
                Console.Write("28 dienas");
            }
            else
            {
                Console.Write("31 diena");
            }

            //3. variants
            switch (menesis)
            {
                case "apr":
                case "mar":
                case "may":
                case "jun":
                    Console.Write("30 dienas");
                    break;

                case "feb":
                    Console.Write("28 dienas");
                    break;

                default:
                    Console.Write("31 diena");
                    break;
            }
        }
            static void uzd9()
            {
                Console.Write("Ievadi valsts: ");
            
            string city = Console.ReadLine();
            Console.Write("Valsts {0} galvaspilseta ir ", city);
            switch (city)
            {
                case "igaunija":
                    Console.Write("Tallina");
                    break;
                case "somija":
                    Console.Write("Helsinki");
                    break;
                case "ukraina":
                    Console.Write("Kijeva");
                    break;
                case "zviedrija":
                    Console.Write("Stokholma");
                    break;
                case "krievija":
                    Console.Write("Maskava");
                    break;
                default:
                    Console.Write("Not Found");
                    break;
            }
            }
        static void uzd10()
        {
            Console.Write("Ievadi ko darit: ");
            string action = Console.ReadLine();
            Console.Write("Ievadi pirmo skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            if (action == "+")
            {
                Console.WriteLine(sk1 + sk2);
            }
            else if (action == "-")
            {
                Console.WriteLine(sk1 - sk2);
            }
            else if (action == "*")
            {
                Console.WriteLine(sk1 * sk2);
            }
            else if (action == "/")
            {
                Console.WriteLine(sk1 / sk2);
            }
            else
            {
                Console.Write("Wrong operation");
            }





        }

        static void uzd11()
        {
            Console.Write("Ievadi cik gradi: ");
            float gr = (float)int.Parse(Console.ReadLine());

            Console.Write("Ievadi kada mervieniba tie ir: ");
            string m1 = Console.ReadLine().ToUpper();

            Console.Write("Ievadi uz kuru mervienibu parvest: ");
            string m2 = Console.ReadLine().ToUpper();

            if (m1 == "K" && m2 == "C")
            {
                Console.Write(gr - 273.15); 
            }
                
            else if (m1 == "K" && m2 == "F")
            {
                Console.Write((gr - 273.15) * 9 / 5 + 32);
            }
            else if (m1 == "C" && m2 == "K")
            {
                Console.Write(gr + 273.15);
            }
            else if (m1 == "C" && m2 == "F")
            {
                Console.Write((gr + 9 / 5) + 32);
            }
            else if (m1 == "F" && m2 == "C")
            {
                Console.Write((gr - 32) * 5 / 9);
            }
            else if (m1 == "F" && m2 == "K")
            {
                Console.Write((gr - 32) * 5 / 9 + 273.15);
            }
            else
            {
                Console.Write("Wrong operation");
            }
            

        }

    }
}

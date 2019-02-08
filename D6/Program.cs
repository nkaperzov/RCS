using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd27();
            Console.Read();
        }

        static void Piemers()
        {
            int sk1;
            int sk2;

            int[] skaitli = new int[5]; // masivs ar 5 elementiem - int
            skaitli[0] = 1;
            skaitli[1] = 2;
            skaitli[2] = 3;
            skaitli[3] = 4;
            skaitli[4] = 5;
            //izmetis kludu - IndexOutOfRange
            // skaitli[4] = 6;

            int skaitlis = skaitli[3]; // 4

            for (int i = 0; i < skaitli.Length; i++)
            {
                int vertiba = skaitli[i];
                Console.WriteLine(vertiba);
            }

            //foreach (... in masivs)
            foreach (int vertiba in skaitli)
            {
                Console.WriteLine(vertiba);
            }

        }
        static void uzd25()
        {
            Console.WriteLine("Ievadi skaitli N: ");
            int n = int.Parse(Console.ReadLine());

            int[] masivs = { 0, 10, 20, 30, 40, 50 };

            bool irAtrasts = false;
            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] == n)
                {
                    Console.WriteLine("N ir atrasts pozicija {0}", i);
                    irAtrasts = true;
                    break;
                }
            }
            if (irAtrasts == false)
            //if(!irAtrasts)
            {
                Console.WriteLine("Skaitlis nav masiva!");
            }

            //irAtrasts = masivs.Contains(n);

        }

        static void uzd26()
        {
            //Console.WriteLine("Ievadi 1.skaitli: ");
            //int sk1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ievadi 2.skaitli: ");
            //int sk2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ievadi 3.skaitli: ");
            //int sk3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ievadi 4.skaitli: ");
            //int sk4 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ievadi 5.skaitli: ");
            //int sk5 = int.Parse(Console.ReadLine());

            //Console.WriteLine(sk5);
            //Console.WriteLine(sk4);
            //Console.WriteLine(sk3);
            //Console.WriteLine(sk2);
            //Console.WriteLine(sk1);

            int[] masivs = new int[5];

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = int.Parse(Console.ReadLine());

            }
            for (int i = masivs.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(masivs[i]);
            }
        }

        static void pretejiSarakts()
        {
            List<int> saraksts = new List<int>();

            while (true)
            {
                Console.Write("Ievadi skaitli (vai 0, lai partrauktu): ");
                string vertiba = Console.ReadLine();
                if (String.IsNullOrEmpty(vertiba))
                {
                    break;
                }
                int skaitlis = int.Parse(vertiba);

                if (skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);
            }

            //int elementuSkaits = saraksts.Count;
            saraksts.Reverse();
            Console.WriteLine(string.Join(",", saraksts));
        }
        static void uzd27()
        {
            List<int> LIST = new List<int>();

            while (true)
            {
                Console.Write("Ievadi skaitli (vai tuksu lai partrauktu): ");
                string vertiba = Console.ReadLine();
                if (String.IsNullOrEmpty(vertiba))
                {
                    break;
                }
                int sk = int.Parse(vertiba);

                
                LIST.Add(int.Parse(vertiba));
                
            }

            //SKAITISANA:
            // 1.variants
            int skaits = 0;
            foreach(int skaitlis in LIST)
            {
                if(skaitlis == 5)
                {
                    skaits++;
                    // skaits +=1;
                    // skaits = skaits +1;
                }
            }
            Console.WriteLine("Skaitlis 5 atrasts {0} reizes", skaits);

            //2.variants
            //skaits = LIST.Count(sk => sk == 5);
            //Console.WriteLine("Skaitlis 5 atrasts {0} reizes", skaits);

            Console.WriteLine("Min int is: {0}", LIST.Min());
            Console.WriteLine("Max int is: {0}", LIST.Max());


            added
        }

    }
}

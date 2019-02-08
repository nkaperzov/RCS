using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            md4();
            Console.Read();
        }

        static void uzd12()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);

            }
        }
        static void uzd14()
        {
            Console.WriteLine("Ievadi N skaitli");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i * i);
            }

        }
        static void uzd13()
        {
            Console.WriteLine("Ievadi savu dz gadu:");
            int gads = int.Parse(Console.ReadLine());
            for (int i = gads; i <= DateTime.Now.Year; i++)
            {
                Console.WriteLine(i);
            }

        }
        static void uzd15()
        {
            Console.WriteLine("Ievadi skaitli N: ");
            int N = int.Parse(Console.ReadLine());
            int summa = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    summa = summa + i;
                }




            }

            Console.WriteLine("summa {0}", summa);
        }

        static void uzd16()
        {
            Console.WriteLine("Ievadi skaitlu N: ");
            int N = int.Parse(Console.ReadLine());
            int summa = 0;
            int nummer = 0;



            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Ievadi " + i + " sk");
                nummer = int.Parse(Console.ReadLine());
                summa = summa + nummer;
            }

            float average = (float)summa / (float)N;

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Summa = " + summa);


        }
        static void uzd17()
        {
            int number = 0;
            int summa = 0;
            while (number >= 0)
            {
                Console.WriteLine("Ievadi skaitli: ");
                number = int.Parse(Console.ReadLine());
                summa = summa + number;
            }
            Console.WriteLine("summa {0}", summa);
    }
        static void uzd18()
        {
            Console.WriteLine("Ievadi skaitli N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {

                for (int j = 1; j <= N; j++)
                {
                    Console.Write("#");
                    
                }

                Console.WriteLine();


            }
        }
        static void uzd19()
        {
            Console.WriteLine("Ievadi N skaitli: ");
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                

            }

        }
        static void uzd20()
        {
            Console.WriteLine("Ievadi skaitli N: ");
            int N = int.Parse(Console.ReadLine());
            int max = 2 * N - 1;
            int star = 0;
            int space = 0;
            for (int i = 1; i <= N; i++)
            {
                star = (2 * i) - 1;
                space = (max - star) / 2;

                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");

                }
                for (int j = 1; j <= star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
          
                
            }
            for (int i = 1; i < N; i++)
            {
                star = max - (i * 2);
                space = i;
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void md1()
        {
            Console.WriteLine("Ievadiet savu vecumu: ");
            int vec = int.Parse(Console.ReadLine());
            if(vec <= 50)
            {
                Console.WriteLine("Jusu vecums neparsniedz 50 gadus");
            }
            if (vec > 50)
            {
                Console.WriteLine("Jusu vecums parsniedz 50 gadus");
            }
        }
        static void md2()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            if(sk >= -50 & sk <= 50)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
        static void md3()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            if (sk %2 == 0)
            {
                Console.WriteLine("Pair number");
            }
            else
            {
                Console.WriteLine("unpair number");
            }
        }
        static void md4()
        {
            Console.WriteLine("Ievadiet 1 .skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            int min = sk1;
            int max = sk1;
            Console.WriteLine("Ievadiet 2 .skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());
            if (sk2 < min)
            {
                min = sk2;
            }
            if (sk2 >max)
            {
                max = sk2;
            }
            Console.WriteLine("Ievadiet 3 .skaitli: ");
            int sk3 = int.Parse(Console.ReadLine());
            if (sk3 < min)
            {
                min = sk3;
            }
            if (sk3 > max)
            {
                max = sk3;
            }
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
        }
        

    }
}

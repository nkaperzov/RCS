using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            sklidz100();
            Console.Read();
        }
        static void ciklupiemers()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());

            for (int i = skaitlis; i <= 10; i++)
            {
                // pariet pie nakamas interacija
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
                //partrauktu cikla apstradi
                //  if (i == 5)
                //{
                //  break;
                //}


               
            }

            Console.Write("Cikla beigas");
        }

        static void sklidz100()
        {
            int summa = 0;
            
            

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                summa = summa + i;
               
                // summa += i;
            }

            // jaizvada summa            

            Console.Write("Summa = {0} {1}", summa);
            



        }
        static void uzd13()
        {
            Console.Write("Ievadi savu dzimsanas gadu: ");

            int dzimsanasGads = int.Parse(Console.ReadLine());

            for (int gads = dzimsanasGads; gads <= DateTime.Now.Year; gads++)
            //vai
            // for (;dzimsanasGads <= DateTime.Now.Year; dzimsanasGads++)
            {
                Console.WriteLine(gads);
            }

            //while (dzimsanasGads <= DateTime.Now.Year)
            //{
            //    Console.WriteLine(dzimsanasGads);
            //    dzimsanasGads = dzimsanasGads + 1;
                // gads+=1;
                // gads++;
            }
        static void uzd15()
        {
            Console.WriteLine("Ievadi skaitlis n: ");
            int n = int.Parse(Console.ReadLine());
            int summa = 0;


            for (int i = 1; i <= n; i++)
            {

                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                summa += i;

                           }
            Console.Write("Summa - {0}", summa);
        }
        static void uzd16()
        {
            Console.WriteLine("Ievadi skaitlu N: ");

            int N = int.Parse(Console.ReadLine());
            int summa = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Ievadi {0}. skaitli ", i);
                //int sk = int.Parse(Console.ReadLine());
                //summa = summa + sk;
                summa += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Summa = {0}", summa);
            Console.WriteLine("Videja = {0}", summa / (float)N);
                
                     
           
        }

        static void uzd17()
        {
            Console.WriteLine("Ievadi skaitlu N: ");
            int N = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= N; rinda++)
            {


                for (int kolona = 1; kolona <= N; kolona++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

        }
        static void uzd18()
        {
            Console.Write("Ievadi skaitlu N: ");
            int N = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= N; rinda++)
            {


                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);
                }

                Console.WriteLine();
            }


        }
        static void uzd19()
        {
            Console.Write("Ievadi skaitlu N: ");
            int N = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= N; rinda++)
            {


                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);
                }
            }
            for (int rinda = N - 1; rinda >= 1; rinda--)
            {
                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);

                }
            }
        }
    }

  }

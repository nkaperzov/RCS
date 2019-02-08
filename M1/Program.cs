using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           uzd3();
            Console.Read();
        }
        static void uzd1()
        {
            Console.WriteLine("  *  ");
            Console.WriteLine(" *** ");
            Console.WriteLine("*****");
            Console.Read();
        }
        static void uzd2()
        {
           Console.WriteLine("Ievadi pirmo vardu: ");
           string word1 = Console.ReadLine();

            Console.WriteLine("Ievadi otro vardu: ");
            string word2 = Console.ReadLine();

            Console.WriteLine("Ievadi treso vardu: ");
            string word3 = Console.ReadLine();

            Console.WriteLine(word1 + "," + word2 + "," + word3);
        }
       static void uzd3()
        {
            Console.WriteLine("Ievadi skaitla a vertibu: ");
            int a = int.Parse(Console.ReadLine());
            int a1 = a + 5; 
            int a2 = a += 5;
            int a3 = a -= 3;
            int a4 = a *= 2;
            int a5 = a += 1;
            int a6 = a++;
            Console.WriteLine("a= a+5: " + a1);
            Console.WriteLine("a += 5: " + a2);
            Console.WriteLine("a -= 3: " + a3);
            Console.WriteLine("a *= 2: " + a4);
            Console.WriteLine("a += 1: " + a5);
            Console.WriteLine("a++ : " + a6);
            // Узнать про математику эту :D
        }
        static void uzd4()
        {
            Console.WriteLine("Ievadiet vienu vardu: ");
            string vards = Console.ReadLine();
            string uppervards = vards.ToUpper();
            //vai 
            // string vards = Console.ReadLine().ToUpper();
            //vai
            // vards = vards.ToUpper();
            
            Console.WriteLine(uppervards);
        }

        static void uzd5()
        {
            Console.WriteLine("Ievadi savu vecumu: ");
            int vecums = int.Parse(Console.ReadLine());
            if (vecums > 18)  Console.WriteLine("Jus esat pilngadigs");
            if (vecums < 18) Console.WriteLine("Jus neesat pilngadigs");

        }

        
            
        

    }
}

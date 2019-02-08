using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md5
{
    class Program
    {
        static void Main(string[] args)
        {
            md5();
            Console.Read();
        }
        static void md5()
        {
            Console.WriteLine("Ievadi skaitlu: ");
            int sk1 = int.Parse(Console.ReadLine());           
            int summa = 0;
            string skstr = sk1.ToString();
            for( int i = 0; i < skstr.Length; i++)
            {

                char c = skstr[i];



                int digit = c - '0';
                summa = summa + digit;
            }
            Console.WriteLine("summa is {0} ", summa);
        }
    }
}

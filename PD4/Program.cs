using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD4
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd21();
            Console.ReadLine();
        }
        static void uzd21()
        {
            Square mysquare = new Square();
            int m = int.Parse(Console.ReadLine());
            mysquare.mala = m;
            int laukums = mysquare.area(8);
            int perimetr = mysquare.peri();
            Console.WriteLine("laukums ir " +laukums);
            Console.WriteLine("perimetrs ir " +perimetr);

        }
        
    }


    class Square
    {
        public int mala;

        public int area(int eee)
        {
            return eee * eee;


        }

        public int peri()
        {
            return mala * 4;
        }


        
    }
   
}




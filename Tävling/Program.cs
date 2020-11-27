using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tävling
{
    class Program
    {
        static void Main(string[] args)
        {
            int apple = 7;
            int pear = 13;

            Console.WriteLine("Ange antal äpplen sålda:");
            int antalas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange antlal päron sålda:");
            int antalps = int.Parse(Console.ReadLine());

            Console.WriteLine("Tjänade kronor av äpplen:" + apple*antalas);
            int tpa = apple * antalas;
            Console.WriteLine("Tjänade kronor av päron:" + pear*antalps);
            int tpp = pear * antalps;

            if (tpa < tpp)
                Console.WriteLine("Petra har tjänat mest.");

            else
                Console.WriteLine("Axel har tjänat mest.");
        }
    }
}

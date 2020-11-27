using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2_tävling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ditt personnummer:");
            string pnummer = Console.ReadLine();
            string nitton = "19";
            string tjugo = "20";
            string arton = "18";
            string pinne = "-";
            string plus = "+";
            string res = pnummer.Substring(0, 2);

            int res1 = int.Parse(res);
            bool sant1 = (pnummer.Contains(pinne));

            if (res1 < 99)
            {
                if (res1 < 40)
                {
                    if (sant1 == true)
                    {
                        if (sant1 == true)
                        {
                            if (sant1 == true)
                            {
                                if (res1 < 20)
                                {
                                    if (sant1 == true)
                                    {
                                        Console.WriteLine(tjugo + pnummer.Remove(6, 1));
                                    }
                                    else if (sant1 == false)
                                    {
                                        Console.WriteLine(nitton + pnummer.Remove(6, 1));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(nitton + pnummer.Remove(6, 1));
                                }
                            }


                        }
                    }
                }
                else
                {
                    Console.WriteLine(arton + pnummer.Remove(6, 1));
                }         
            }
        }
    }
}

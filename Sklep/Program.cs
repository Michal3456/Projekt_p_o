using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sklep
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "1", b = "0";
            int g=0;
            //ogolna.menu_1(Baza_dan.odczyt("Baza.txt"));
           // Baza_dan.zapis_do_pliku("3454334", "Baza2.txt");
           // Console.WriteLine($"{ Baza_dan.odczyt("Baza2.txt")}");
            StreamReader srd = new StreamReader("Baza.txt");
            //|| (1 != g)
            int i=0;
            while (("op1389" != b ))
            {
                b = srd.ReadLine();
                try
                {
                   g= ogolna.daj_string_oddaj_int(b);
                }
                catch(Exception)
                {

                }
               // if("op13" == b)
                    Console.WriteLine($"{b}");
                
                i++;
                if (i > 1)
                    break;
            }
            


            Console.ReadKey();
        }
    }
}

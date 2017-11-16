using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a;
            //a= Console.ReadLine();
            //ogolna.daj_string_oddaj_int(a);
             ogolna.menu_1(Baza_dan.odczyt("Baza.txt"));
            // Console.WriteLine($"{a}");
            Console.WriteLine($"{ Baza_dan.odczyt("Baza.txt")}");
            Console.ReadKey();
        }
    }
}

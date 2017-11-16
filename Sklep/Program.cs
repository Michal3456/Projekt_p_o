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
            ogolna.menu_1(Baza_dan.odczyt("Baza.txt"));
            Baza_dan.zapis_do_pliku("3454334", "Baza2.txt");
            Console.WriteLine($"{ Baza_dan.odczyt("Baza2.txt")}");
            Console.ReadKey();
        }
    }
}

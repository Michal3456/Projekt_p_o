using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Koszyk_Panel
    {
        public static void zapis_kosz(float cena, int liczba_przed)
        {
            Console.WriteLine("************************");
            Console.WriteLine("************************");
            Console.WriteLine($"Kosz: {cena: F2} zł");
            Console.WriteLine("************************");
            Console.WriteLine("************************");
            Console.WriteLine("************************");
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class ogolna
    {
        public static int daj_string_oddaj_int(string a)
        {
            int b = Int32.Parse(a);
            return b;
        }
        public static void menu_1(string a)
        {
           a = metod_og.zwroc_int_jesli_ci_s_r(a);
            switch (a)
            {
                case ("1"):
                    {
                        Console.WriteLine("Opcja 1.");
                        break;
                    }
                case "2":
                    {
                        break;
                    }
                case "3":
                    {
                        break;
                    }
                case "4":
                    {
                        break;
                    }
                case "5":
                    {
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("NIez znam takiej komendy.");
                        break;
                    }
            }
        }
    }
}

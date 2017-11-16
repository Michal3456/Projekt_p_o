using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sklep
{
    class Baza_dan : IWyszukaj
    {
        public static String odczyt(string pliktxt)
        {
            String lin;
            try
            {
                using (StreamReader sr = new StreamReader(pliktxt))
                {
                    String line = sr.ReadToEnd();
                    //Console.WriteLine(line);
                    lin = line;
                    return lin;
                }
            }catch(Exception e)
            {
                Console.WriteLine($"{e}");
            }
            finally
            {               
            }
            return "";
        }
        public static void zapis_do_pliku(string tekst, string zrodlo)
        {
            using (System.IO.StreamWriter plik = new System.IO.StreamWriter((zrodlo) ,true))
            {
                plik.WriteLine(tekst);
            }
        }

        public int szukac_prod(float min_cena, float max_cen, string nazwa)
        {
            return 0;
        }
        public int szukac_prod(float min_cena, string nazwa)
        {
            return 0;
        }
        public int szukac_prod(string nazwa)
        {
            return 0;
        }
        public int szukac_prod(float max_cen)
        {
            return 0;
        }

    }
}

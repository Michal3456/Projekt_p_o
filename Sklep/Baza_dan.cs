using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sklep
{
    class Baza_dan
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



    }
}

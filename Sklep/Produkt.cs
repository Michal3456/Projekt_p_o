using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Produkt : Baza_produktow
    {
        protected int numerID;
        protected int numerWyszukiwania;
        public float cena;
        public string nazwa;
        public Produkt()
        {

        }
        public Produkt(string nazwa, float cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.numerID = Produkt.tworz_nr_ID();
            this.numerID = Produkt.tworz_nr_Wyszk();
        }
        public float Podaj_Cene()
        {
            return cena;
        }
        public string Podaj_Nazwe()
        {
            return nazwa;
        }

        protected static int tworz_nr_ID()
        {

            return 0;

        }
        protected static int tworz_nr_Wyszk()
        {
            return 0;
        }
    }
}

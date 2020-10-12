using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statickeVarijable
{
    class PrvaKlasa
    {
        string ime;
        string prezime;
        static int brojac;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public PrvaKlasa()
        {
            brojac++;
        }
        public PrvaKlasa(string ime, string prezime)
        {
            brojac++;
            this.ime = ime;
            this.prezime = prezime;
        }

        public override string ToString()
        {
            string ispis = "Redni broj: "+brojac+", "+ime+" " +prezime;
            return ispis;
        }

    }
}

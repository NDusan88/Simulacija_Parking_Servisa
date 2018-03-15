using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSimulacijaParkingServisa
{
    class Automobil
    {
        private string registracija;
        private string vlasnik;
        private static int brojac = 0;

        public Automobil()
        {
            brojac++;
        }
        public Automobil(string vlas, string reg)
        {
            brojac--;
            registracija = reg;
            vlasnik = vlas;
        }
        public void Upisi(string vlas, string reg)
        {
            registracija = reg;
            vlasnik = vlas;
        }

        public string VratiReg()
        {
            return registracija;
        }

        public string VratiVlasnika()
        {
            return vlasnik;
        }

        public static int VratiBrojac()
        {
            return brojac;
        }

        public override string ToString()
        {
            return "\n\rRegistracija: " + registracija + "\n\r\n\rVlasnik: " + vlasnik;
        }
    }
}

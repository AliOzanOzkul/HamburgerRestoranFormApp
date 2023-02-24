using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerWFA.Classes
{
    public class Siparis : Hamberger
    {
        public int HamburgerAdet { get; set; }

        



        public void HamburgerAdetSet(int hamburgerSayisi)
        {
            HamburgerAdet = hamburgerSayisi;


        }
        public void HamburgerBoyutSet(int indeks)
        {
            if (indeks == 0)
            {
                Boyut = "Kücük";
                BoyFiyati = 5m;
            }
            else if (indeks == 1)
            {
                Boyut = "Orta";
                BoyFiyati = 7.5m;
            }
            else if (indeks == 2)
            {
                Boyut = "Buyuk";
                BoyFiyati = 10m;
            }
        }

        public void HamburgerAdiSet(string adi)
        {

            Adi = adi;
        }
        decimal sosToplam = 0;
        public decimal SosToplamFiyat(int indeks)
        {
            
            sosToplam = sosToplam + Restorant.SosFiyati[indeks];
            return sosToplam;
        } 
        public void SosToplamFiyatSet(decimal a)
        {
            SosToplamFiyati = SosToplamFiyati + a;

        }
    }
}

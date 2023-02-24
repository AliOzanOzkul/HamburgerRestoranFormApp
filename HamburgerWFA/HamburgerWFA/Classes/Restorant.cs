using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerWFA.Classes
{
    public static class Restorant
    {

        public static int CiroDegeri { get; set; }
        public static int ToplamSatisSayisi { get; set; }
        public static int SatilanUrunAdeti { get; set; }
        public static int SatilanEkstraMalzeme { get; set; }

        static List<string> sosListesi = new List<string>() { "Ketçap", "Mayanoz", "Hardal", "BBQ", "Ranch", "Buffalo" };
        public static List<string> SosAdi
        {
            get
            {
                return sosListesi;
            }
            set
            {

            }
        }
        static List<decimal> sosFiyatListesi = new List<decimal>() { 0.50m, 0.50m, 1m, 1m, 1m, 1m };
        public static List<decimal> SosFiyati
        {
            get
            { return sosFiyatListesi; }
            set
            {
            }
        }



       static List<string> menuList = new List<string>() { "Big King Menü", "Double King Chicken Menü", "Steakhouse Menü", "Whooper Menü", "Whooper Jr. Menü", "Chicken Royal Menü" };
       

        public static List<string> MenuList
        {
            get { return menuList; }
            set { }
        }
        static List<decimal> hamburgerFiyatListesi = new List<decimal>() { 75m, 65m, 120m, 100m, 80m, 75m };

        public static List<decimal> HamburgerFiyat
        {
            get { return hamburgerFiyatListesi; }
            set {  }
        }


        public static void MenuListesiGuncelle(string yemekAdi,decimal yemekFiyati)
        {
            menuList.Add(yemekAdi);
            hamburgerFiyatListesi.Add(yemekFiyati);
        }

        public static void EkstraMalzemeGuncelle(string malzemeAdi, decimal malzemeFiyati)
        {
            sosListesi.Add(malzemeAdi);
            sosFiyatListesi.Add(malzemeFiyati);

        }

        
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdev
{
    class Siparis
    {
        public int Adet { get; set; }
        public Hamburger hamburgerler { get; set; }
        public string Toplamtutar { get; set; }
        public override string ToString()
        {
            Toplamtutar = "";
            Toplamtutar += hamburgerler.Adi + " ," + hamburgerler.Boyut + " ,"  + hamburgerler.Icecekler+ " ," ;
         
            foreach (string malzeme in hamburgerler.Malzemeler)
            {
                Toplamtutar += malzeme + ", ";
            }           
            Toplamtutar += string.Format("{0}*{1} = {2}", Adet, hamburgerler.ToplamFiyat, Adet * hamburgerler.ToplamFiyat + " TL");
            return Toplamtutar;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerOdev
{
    class Hamburger
    {
        public string Adi { get; set; }
        public decimal Fiyati { get; set; }
        public Boyut Boyut { get; set; }
        public List<string> Malzemeler { get; set; }
        public Icecekler Icecekler { get; set; }
        public int Adet { get; set; }

        public override string ToString()
        {
            return Adi;
        }
        //private decimal toplamFiyat; // Bu olursa her çağrıldığında get döngüsüne sokacak.
        public decimal ToplamFiyat
        {
            get
            {
                decimal toplamFiyat = 0;
                toplamFiyat += Fiyati * (decimal)Boyut.Fiyati;
                toplamFiyat += Icecekler.Fiyati;               
                return toplamFiyat;
            }
            set
            {
                //toplamFiyat = value;
            }
                   
        }

    }
}

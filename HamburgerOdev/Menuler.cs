using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerOdev
{
    public partial class Menuler : Form
    {
        public Menuler()
        {
            InitializeComponent();
        }
        private void Menuler_Load(object sender, EventArgs e)
        {
            Hamburger SteakHouse = new Hamburger { Adi = "Steakhouse Burger Menu", Fiyati = 50 };
            Hamburger Whopper = new Hamburger { Adi = "Whopper Burger Menu", Fiyati = 45 };
            Hamburger Texas = new Hamburger { Adi = "Texas Burger Menu", Fiyati = 60 };
            Hamburger Meatball = new Hamburger { Adi = "Meatball Burger Menu ", Fiyati = 40 };
            Hamburger KingChicken = new Hamburger { Adi = "King Chicken Menu", Fiyati = 30 };
            Hamburger Chicken = new Hamburger { Adi = "Chicken Burger Menu", Fiyati = 25 };

            cmbMenu.Items.Add(SteakHouse);
            cmbMenu.Items.Add(Whopper);
            cmbMenu.Items.Add(Texas);
            cmbMenu.Items.Add(Meatball);
            cmbMenu.Items.Add(KingChicken);
            cmbMenu.Items.Add(Chicken);

            Boyut kucuk = new Boyut { Adi = "Küçük", Fiyati = 1 };
            rdbKucuk.Tag = kucuk;
            Boyut orta = new Boyut { Adi = "Orta", Fiyati = 1.25 };
            rdbOrta.Tag = orta;
            Boyut buyuk = new Boyut { Adi = "Büyük", Fiyati = 1.75 };
            rdbBuyuk.Tag = buyuk;

            Icecekler ayran = new Icecekler { Adi = "Ayran", Fiyati = 5 };
            Icecekler kola = new Icecekler { Adi = "Kola", Fiyati = 10 };
            Icecekler salgam = new Icecekler { Adi = "Salgam", Fiyati = 8 };
            Icecekler meyveSuyu = new Icecekler { Adi = "Meyve Suyu", Fiyati = 7 };
            Icecekler su = new Icecekler { Adi = "Su", Fiyati = 2 };

            cmb_Icecekler.Items.Add(ayran);
            cmb_Icecekler.Items.Add(kola);
            cmb_Icecekler.Items.Add(salgam);
            cmb_Icecekler.Items.Add(meyveSuyu);
            cmb_Icecekler.Items.Add(su);  
        }
        Siparis s;
        
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            Hamburger  h = (Hamburger)cmbMenu.SelectedItem; // Hamburger ekleme
            h.Boyut = rdbKucuk.Checked? (Boyut)rdbKucuk.Tag : rdbOrta.Checked ? (Boyut)rdbOrta.Tag : (Boyut)rdbBuyuk.Tag; //Boyut ekleme

            h.Malzemeler = new List<string>(); // Malzeme Ekleme
            foreach (CheckBox Malzemeler in grpMalzemeler.Controls)
            {
                h.Malzemeler.Add(Malzemeler.Text);
            }
            h.Icecekler = (Icecekler)cmb_Icecekler.SelectedItem;
            h.Adet = (int)num_adet.Value;
            txt_tutar.Text = h.ToplamFiyat * h.Adet + " TL";
            s = new Siparis();
            s.hamburgerler = h;
            s.Adet = (int)num_adet.Value;
            

        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(s != null)
            {
                list_Ekle.Items.Add(s);
            }
            
            
          
        }

        private void brn_temizle_Click(object sender, EventArgs e)
        {
            s.hamburgerler.Fiyati = 0;
            s.hamburgerler.Boyut.Fiyati = 0;
            s.hamburgerler.Icecekler.Fiyati = 0;
            s.hamburgerler.ToplamFiyat = 0;
            lbl_toplamTutar.Text = s.hamburgerler.ToplamFiyat.ToString();
            list_Ekle.Items.Clear();
        }

        private void btn_Ode_Click(object sender, EventArgs e)
        {
            decimal toplamFiyat = 0;
            int adet = 0;
            foreach (Siparis item in list_Ekle.Items)
            {
                toplamFiyat += item.hamburgerler.ToplamFiyat * item.Adet;
                adet++;
            }
            lbl_toplamTutar.Text = toplamFiyat.ToString();
            MessageBox.Show(adet + " Adet ürünü " + lbl_toplamTutar.Text +" TL fiyata satın almak istediğinize emin misiniz?");
        }
    }
}

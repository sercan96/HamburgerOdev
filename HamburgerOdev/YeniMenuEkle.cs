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
    public partial class YeniMenuEkle : Form
    {
        public YeniMenuEkle()
        {
            InitializeComponent();
        }
        Menuler anaform = new Menuler();
        
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            Hamburger h = new Hamburger { Adi = MenuAdi.Text, Fiyati = Convert.ToInt32(txtFiyat.Text) };
            anaform.cmbMenu.Items.Add(h.Adi);
            MessageBox.Show("eklendi" + txtFiyat.Text);
            Close();
            //Form1.menuler.Add(new Menu { MenuAdi = txtMenuAdi.Text, Fiyati = nmrFiyat.Value });
        }
       
    }
}

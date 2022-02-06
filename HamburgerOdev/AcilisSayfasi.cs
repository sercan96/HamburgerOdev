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
    public partial class AcilisSayfasi : Form
    {
        public AcilisSayfasi()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Menuler menuler = new Menuler();
            menuler.MdiParent = AcilisSayfasi.ActiveForm;
            menuler.Show();
            

        }

        private void menulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menuler menuler = new Menuler();
            menuler.MdiParent = AcilisSayfasi.ActiveForm;
            menuler.Show();
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniMenuEkle yme = new YeniMenuEkle();
            yme.Show();
        }

        private void ciroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciro ciro = new Ciro();
            ciro.MdiParent = AcilisSayfasi.ActiveForm;
            ciro.Show();
        }
    }
}

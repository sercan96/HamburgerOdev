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
    public partial class Ciro : Form
    {
        public Ciro()
        {
            InitializeComponent();
        }
        Siparis spr = new Siparis();
        private void Ciro_Load(object sender, EventArgs e)
        {
            grp_ciro.Text = spr.Adet.ToString();
            
        }
    }
}

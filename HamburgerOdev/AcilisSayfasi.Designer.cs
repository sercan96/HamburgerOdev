
namespace HamburgerOdev
{
    partial class AcilisSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişEkranıToolStripMenuItem,
            this.urunYonetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişEkranıToolStripMenuItem
            // 
            this.siparişEkranıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menulerToolStripMenuItem,
            this.ciroToolStripMenuItem});
            this.siparişEkranıToolStripMenuItem.Name = "siparişEkranıToolStripMenuItem";
            this.siparişEkranıToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.siparişEkranıToolStripMenuItem.Text = "Sipariş Ekranı";
            // 
            // menulerToolStripMenuItem
            // 
            this.menulerToolStripMenuItem.Name = "menulerToolStripMenuItem";
            this.menulerToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.menulerToolStripMenuItem.Text = "Menuler";
            this.menulerToolStripMenuItem.Click += new System.EventHandler(this.menulerToolStripMenuItem_Click);
            // 
            // urunYonetimiToolStripMenuItem
            // 
            this.urunYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEkleToolStripMenuItem});
            this.urunYonetimiToolStripMenuItem.Name = "urunYonetimiToolStripMenuItem";
            this.urunYonetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.urunYonetimiToolStripMenuItem.Text = "Urun Yonetimi";
            // 
            // menuEkleToolStripMenuItem
            // 
            this.menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            this.menuEkleToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.menuEkleToolStripMenuItem.Text = "Menu Ekle";
            this.menuEkleToolStripMenuItem.Click += new System.EventHandler(this.menuEkleToolStripMenuItem_Click);
            // 
            // ciroToolStripMenuItem
            // 
            this.ciroToolStripMenuItem.Name = "ciroToolStripMenuItem";
            this.ciroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ciroToolStripMenuItem.Text = "Ciro";
            this.ciroToolStripMenuItem.Click += new System.EventHandler(this.ciroToolStripMenuItem_Click);
            // 
            // AcilisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 683);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AcilisSayfasi";
            this.Text = "AnaMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciroToolStripMenuItem;
    }
}
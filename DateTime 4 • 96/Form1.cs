using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_4___96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            DateTime sonOdeme = new DateTime(2022, 3, 30, 14, 30, 50, 20);
            lblBugun.Text = "Bugün: " + bugun.ToString();
            lblSonOdeme.Text = "Son Ödeme: " + sonOdeme.ToString();
            TimeSpan tarihFark = sonOdeme - bugun;
            lblGun.Text = "Gün Farkı: " + tarihFark.Days.ToString();
            lblSaat.Text = "Saat Farkı: " + tarihFark.Hours.ToString();
            lblDakika.Text = "Dakika Farkı: " + tarihFark.Minutes.ToString();
            lblSaniye.Text = "Saniye Farkı: " + tarihFark.Seconds.ToString();
            lblMiliSaniye.Text = "MiliSaniye Farkı: " + tarihFark.Milliseconds.ToString();
        }
    }
}

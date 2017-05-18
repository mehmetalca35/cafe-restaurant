using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCafe_Restaurant
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }
        public static string tarih,sql,tablo;
        public static int i;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                frmRapor2 goster = new frmRapor2();
                i = 1;
                sql = "SELECT * FROM rapor where MasaNo = 'Masa " + comboBox1.Text + "'";
                tablo = "rapor";
                goster.ShowDialog();
            }
        }

        private void btnGunSonuAc_Click(object sender, EventArgs e)
        {
            frmRapor2 goster = new frmRapor2();
            i = 0;
            tarih = dateTimePicker1.Value.ToShortDateString();
            sql = "SELECT * FROM gunsonu where BASLANGIC LIKE '" + frmRapor.tarih + "%'";
            tablo = "gunsonu";
            goster.ShowDialog();
        }

    }
}

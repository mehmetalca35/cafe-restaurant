using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace prjCafe_Restaurant
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        int hak;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=vt.accdb");
        private void button1_Click(object sender, EventArgs e)//Giriş butonu
        {
            if (hak <= 2)
            {
                string kadi = textBox1.Text.Trim();
                string sifre = textBox2.Text.Trim();
                OleDbDataAdapter sorgula = new OleDbDataAdapter("SELECT * FROM kullanicilar where KADI='" + kadi + "' and SIFRE = '" + sifre + "'", baglan);
                DataTable tablo = new DataTable();
                sorgula.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {
                    this.Hide();
                    loading baslat = new loading();
                    baslat.ShowDialog();

                }
                else
                {
                    hak++;
                    label3.Text = "Kalan Hakkınız : " + (3 - hak).ToString();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//entera basınca bir sonrakine geçme
        {
            if (e.KeyChar == 13)
            {
                button1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//entera basınca bir sonrakine geçme
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

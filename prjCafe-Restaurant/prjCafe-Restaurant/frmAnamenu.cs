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
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=vt.accdb");
        private void frmMasa_Load(object sender, EventArgs e)
        {
           
        }

        private void frmMasa_FormClosed(object sender, FormClosedEventArgs e)//formdan çıkış yapınca programı kapa
        {
            Application.Exit();
        }
        string gunbasi;bool gunbasikontrol;
        private void button1_Click(object sender, EventArgs e)//Gün Sonu Aç
        {
            if (!gunbasikontrol)
            {
                OleDbCommand basla = new OleDbCommand("insert into gunsonu (BASLANGIC) values('" + DateTime.Now + "')", baglan);
                gunbasi = DateTime.Now.ToString();
                baglan.Open();
                basla.ExecuteNonQuery();
                baglan.Close();
                gunbasikontrol = true;
                btnGunSonuAc.Enabled = false;
                btnGunSonuKapa.Enabled = true;
                btnMasalar.Enabled = true;
            }
        }
        double toplamhesap;
        private void button2_Click(object sender, EventArgs e)//Gün Sonu Kapa
        {
            if (gunbasikontrol)
            {
                #region//hasılat hesaplama
                OleDbDataAdapter toplam = new OleDbDataAdapter("select sum (Hasilat) from rapor WHERE AcilisZamani LIKE'"+DateTime.Today.ToShortDateString()+"%'",baglan);
                DataTable tablo = new DataTable();
                toplam.Fill(tablo);
                dataGridView1.DataSource = tablo;
                if (dataGridView1.Rows[0].Cells[0].Value.ToString() != "")
                {
                    toplamhesap = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value.ToString());
                }
                else
                {
                    toplamhesap = 0;
                }
                #endregion
                OleDbCommand bitir = new OleDbCommand("update gunsonu set BITIS='" + DateTime.Now + "' ,HASILAT='"+toplamhesap+"' where BASLANGIC = '" + gunbasi + "'", baglan);
                baglan.Open();
                bitir.ExecuteNonQuery();
                baglan.Close();
                gunbasikontrol = false;
                btnGunSonuAc.Enabled = true;
                btnGunSonuKapa.Enabled = false;
                btnMasalar.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)//Masaları göster
        {
            frmmasalar masalar = new frmmasalar();
            masalar.ShowDialog();
        }

         private void frmAnaMenu_FormClosing(object sender, FormClosingEventArgs e)//Form kapanmadan yapılan kontroller
        {
                if(gunbasikontrol)
            {
                DialogResult sor = MessageBox.Show("GÜN SONU YAPMADAN PROGRAMDAN ÇIKAMAZSINIZ! \n Gün sonu yapmak istermisiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (sor == DialogResult.Yes)
                {
                    button2_Click(sender,e);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmRapor goster = new frmRapor();
            goster.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }
    }
}

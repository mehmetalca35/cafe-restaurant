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
    public partial class frmmasalar : Form
    {
        public frmmasalar()
        {
            InitializeComponent();
        }
        public static string[] acilis; string tuslanan;
        Button buton;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=vt.accdb");
        void ac(object sender, EventArgs e)//masa aç ana metodu
        {
            masalar[Convert.ToInt32(tuslanan) - 1] = true;
            buton.BackColor = Color.Green;
            OleDbCommand basla = new OleDbCommand("insert into rapor (Masano,AcilisZamani,adet) values('Masa " + tuslanan + "','" + DateTime.Now + "','0:0:0:0')", baglan);
            acilis[Convert.ToInt32(tuslanan) - 1] = DateTime.Now.ToString();
            baglan.Open();
            basla.ExecuteNonQuery();
            baglan.Close();
            masalar[Convert.ToInt32(tuslanan) - 1] = true;
            #region //açılan masanın bilgilerini çekme
            OleDbDataAdapter oku = new OleDbDataAdapter("select * from rapor where AcilisZamani='" + acilis[Convert.ToInt32(tuslanan) - 1] + "'", baglan);
            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            dataGridView1.DataSource = tablo;
            #endregion
        }
        void kapa(object sender, EventArgs e)//masa kapa ana metodu
        {

            masalar[Convert.ToInt32(tuslanan) - 1] = true;
            buton.BackColor = Color.Red;
            OleDbCommand bitir = new OleDbCommand("update rapor set KapanisZamani='" + DateTime.Now + "'  where AcilisZamani = '" + acilis[Convert.ToInt32(tuslanan.ToString()) - 1] + "'", baglan);
            baglan.Open();
            bitir.ExecuteNonQuery();
            baglan.Close();
            masalar[Convert.ToInt32(tuslanan) - 1] = false;

        }
        bool[] masalar = new bool[20];
        private void frmmasalar_Load(object sender, EventArgs e)//masaların listesi
        {
            acilis = new string[20];

        }
        private void tiklanan(object sender, EventArgs e)//tıklanan masanın numarası
        {
            tuslanan = (sender as Button).Text;
            buton = sender as Button;
            if (masalar[Convert.ToInt32(tuslanan) - 1])
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[3].Enabled = true;
                contextMenuStrip1.Show(Cursor.Position);

            }
            else if (!masalar[Convert.ToInt32(tuslanan) - 1])
            {
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        public static string[] adet;
        private void aDİSYONAÇToolStripMenuItem_Click(object sender, EventArgs e)//adisyon formunu açma
        {
            OleDbDataAdapter oku = new OleDbDataAdapter("select * from rapor where AcilisZamani='" + acilis[Convert.ToInt32(tuslanan) - 1] + "'", baglan);
            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Refresh();
            frmMasaAdisyon goster = new frmMasaAdisyon();
            goster.Text = tuslanan;
            string kelime = dataGridView1.Rows[0].Cells["adet"].Value.ToString();
            adet = kelime.Split(':');
            goster.listBox2.Items.Clear();
            goster.label1.Text = "Hesap : " + dataGridView1.Rows[0].Cells["Hasilat"].Value.ToString();
            for (int i = 0; i < adet.Length; i++)
            {
                goster.listBox2.Items.Add(adet[i]);
            }
            goster.ShowDialog();
        }
        private void frmmasalar_FormClosing(object sender, FormClosingEventArgs e)//form kapanmadan yapılan kontroller
        {
            for (int i = 0; i < masalar.Length; i++)
            {
                if (masalar[i])
                {
                    DialogResult sor=MessageBox.Show("AÇIK MASA VARKEN KAPATAMAZSINIZ! \n Kapatmak istermisiniz?","UYARI",MessageBoxButtons.YesNo);
                    if (sor == DialogResult.Yes)
                    {
                        for (int k = 0; k < masalar.Length; k++)
                        {
                            masalar[k] = false;
                            OleDbCommand bitir = new OleDbCommand("update rapor set KapanisZamani='" + DateTime.Now + "'  where AcilisZamani = '" + acilis[k] + "'", baglan);
                            baglan.Open();
                            bitir.ExecuteNonQuery();
                            baglan.Close();
                        }
                        this.Close();
                    }
                    else
                    {
                        e.Cancel = true;
                        break;
                    }
                }
                
            }
        }
    }
}

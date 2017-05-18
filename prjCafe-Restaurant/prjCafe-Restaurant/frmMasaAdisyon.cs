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
    public partial class frmMasaAdisyon : Form
    {
        public frmMasaAdisyon()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=vt.accdb");
        int[] adet;
        private void frmMasaAdisyon_Load(object sender, EventArgs e)//ürün listesini listboxa çekme
        {
            OleDbDataAdapter oku = new OleDbDataAdapter("select * from urunler ",baglan);
            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adet = new int[dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                adet[i] = Convert.ToInt32(frmmasalar.adet[i]);
                listBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString().ToUpper());
            }
            hesapla();

        }
        string satis,urun;
        double hesap = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//masa adisyonuna ürün ekleme
        {
            
            hesap += Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[1].Value);
            adet[dataGridView1.SelectedRows[0].Index] += 1;
            listBox2.Items.Clear();
            for (int i = 0; i < adet.Length; i++)
            {
                listBox2.Items.Add(adet[i]);
            }
            //
            label1.Text = "Hesap :" + hesap.ToString() + " TL";
        }


        private void listBox1_DoubleClick(object sender, EventArgs e)//masa adisyonundan ürün çıkarma
        {
            if (listBox1.SelectedIndex!=-1)
            {
            if (adet[listBox1.SelectedIndex] > 0)
                {
                    
                    adet[listBox1.SelectedIndex] -= 1;
                    hesapla();
                    label1.Text = "Hesap :"+hesap.ToString()+" TL";
                }
            }
            listBox2.Items.Clear();
            for (int i = 0; i < adet.Length; i++)
            {
                listBox2.Items.Add(adet[i]);
            }
            
        }

        private void frmMasaAdisyon_FormClosing(object sender, FormClosingEventArgs e)//form kapanmadan ürün ve satış miktarlarını kaydetme
        {
            urun= listBox1.Items[0] + ":" + listBox1.Items[1] + ":" + listBox1.Items[2] + ":" + listBox1.Items[3];
            satis = listBox2.Items[0] + ":" + listBox2.Items[1] + ":" + listBox2.Items[2] + ":" + listBox2.Items[3];
            OleDbCommand guncelle = new OleDbCommand("update rapor set Adet='" + satis + "',urun='"+urun+"' ,Hasilat='" + hesap + "' where AcilisZamani = '" + frmmasalar.acilis[Convert.ToInt32(this.Text)-1] + "'", baglan);
            baglan.Open();
            guncelle.ExecuteNonQuery();
            baglan.Close();
        }
        double hesapla()//hesap
        {
            double a;
            hesap = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               a=Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                hesap += a*adet[i];
            }
            return hesap;
        }
    }
}

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
    public partial class frmRapor2 : Form
    {
        public frmRapor2()
        {
            InitializeComponent();
        }

        private void frmRapor2_Load(object sender, EventArgs e)
        {
            if (frmRapor.i == 0)
            {
                CrystalReport1 rapor = new CrystalReport1();
                oleDbDataAdapter1.SelectCommand.CommandText = frmRapor.sql;
                oleDbDataAdapter1.Fill(dataSet11.Tables[frmRapor.tablo]);
                rapor.SetDataSource(dataSet11.Tables[frmRapor.tablo]);
                crystalReportViewer1.ReportSource = rapor;
                if (rapor.Rows.Count > 0)
                {
                    Opacity = 1;
                }
                else
                {
                    MessageBox.Show("RAPOR BULUNAMADI");
                    this.Close();
                }
            }
            if (frmRapor.i == 1)
            {
                CrystalReport2 rpr = new CrystalReport2();
                oleDbDataAdapter1.SelectCommand.CommandText = frmRapor.sql;
                oleDbDataAdapter1.Fill(dataSet11.Tables[frmRapor.tablo]);
                rpr.SetDataSource(dataSet11.Tables[frmRapor.tablo]);
                crystalReportViewer1.ReportSource = rpr;
                if (rpr.Rows.Count > 0)
                {
                    Opacity = 1;
                }
                else
                {
                    MessageBox.Show("RAPOR BULUNAMADI");
                    this.Close();
                }
            }
        }
    }
}

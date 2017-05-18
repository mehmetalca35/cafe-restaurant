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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value==100)
            {
                timer1.Stop();
               
                frmAnaMenu masalar = new frmAnaMenu();
                masalar.Show();
                this.Close();

            }
            else
            {
                progressBar1.Value += 1;
            }
        }

        private void loading_Load(object sender, EventArgs e)
        {

        }
    }
}

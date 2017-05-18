namespace prjCafe_Restaurant
{
    partial class frmAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            this.btnGunSonuAc = new System.Windows.Forms.Button();
            this.btnGunSonuKapa = new System.Windows.Forms.Button();
            this.btnMasalar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGunSonuAc
            // 
            this.btnGunSonuAc.BackColor = System.Drawing.Color.Crimson;
            this.btnGunSonuAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGunSonuAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunSonuAc.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnGunSonuAc.Location = new System.Drawing.Point(0, 0);
            this.btnGunSonuAc.Name = "btnGunSonuAc";
            this.btnGunSonuAc.Size = new System.Drawing.Size(156, 125);
            this.btnGunSonuAc.TabIndex = 0;
            this.btnGunSonuAc.Text = "GÜN SONU AÇ";
            this.btnGunSonuAc.UseVisualStyleBackColor = false;
            this.btnGunSonuAc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGunSonuKapa
            // 
            this.btnGunSonuKapa.BackColor = System.Drawing.Color.Crimson;
            this.btnGunSonuKapa.Enabled = false;
            this.btnGunSonuKapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGunSonuKapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunSonuKapa.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnGunSonuKapa.Location = new System.Drawing.Point(162, 0);
            this.btnGunSonuKapa.Name = "btnGunSonuKapa";
            this.btnGunSonuKapa.Size = new System.Drawing.Size(156, 125);
            this.btnGunSonuKapa.TabIndex = 1;
            this.btnGunSonuKapa.Text = "GÜN SONU KAPA";
            this.btnGunSonuKapa.UseVisualStyleBackColor = false;
            this.btnGunSonuKapa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMasalar
            // 
            this.btnMasalar.BackColor = System.Drawing.Color.Crimson;
            this.btnMasalar.Enabled = false;
            this.btnMasalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasalar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnMasalar.Location = new System.Drawing.Point(324, 0);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(156, 125);
            this.btnMasalar.TabIndex = 2;
            this.btnMasalar.Text = "MASALARI GÖSTER";
            this.btnMasalar.UseVisualStyleBackColor = false;
            this.btnMasalar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(486, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 125);
            this.button1.TabIndex = 3;
            this.button1.Text = "RAPOR AL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(486, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(137, 13);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(661, 141);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMasalar);
            this.Controls.Add(this.btnGunSonuKapa);
            this.Controls.Add(this.btnGunSonuAc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(677, 180);
            this.MinimumSize = new System.Drawing.Size(677, 180);
            this.Name = "frmAnaMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnaMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMasa_FormClosed);
            this.Load += new System.EventHandler(this.frmMasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGunSonuAc;
        private System.Windows.Forms.Button btnGunSonuKapa;
        private System.Windows.Forms.Button btnMasalar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
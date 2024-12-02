namespace _12A1419
{
    partial class frmSatisDetaylari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisDetaylari));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdSatislar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatisToplam = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grdSatislar);
            this.groupBox1.Location = new System.Drawing.Point(28, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Listesi";
            // 
            // grdSatislar
            // 
            this.grdSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatislar.Location = new System.Drawing.Point(0, 47);
            this.grdSatislar.Name = "grdSatislar";
            this.grdSatislar.Size = new System.Drawing.Size(328, 176);
            this.grdSatislar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btnSatisIptal);
            this.groupBox2.Location = new System.Drawing.Point(334, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış Detayları";
            // 
            // grdSatilanUrunler
            // 
            this.grdSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilanUrunler.Location = new System.Drawing.Point(402, 103);
            this.grdSatilanUrunler.Name = "grdSatilanUrunler";
            this.grdSatilanUrunler.Size = new System.Drawing.Size(352, 70);
            this.grdSatilanUrunler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATILAN ÜRÜNLER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisIptal.Image")));
            this.btnSatisIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisIptal.Location = new System.Drawing.Point(62, 160);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(95, 24);
            this.btnSatisIptal.TabIndex = 10;
            this.btnSatisIptal.Text = "SATIŞ YAP";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genel Toplam :";
            // 
            // txtSatisToplam
            // 
            this.txtSatisToplam.Location = new System.Drawing.Point(615, 216);
            this.txtSatisToplam.Name = "txtSatisToplam";
            this.txtSatisToplam.Size = new System.Drawing.Size(107, 20);
            this.txtSatisToplam.TabIndex = 13;
            // 
            // frmSatisDetaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 491);
            this.Controls.Add(this.txtSatisToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdSatilanUrunler);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSatisDetaylari";
            this.Text = "frmSatisDetaylari";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdSatislar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdSatilanUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatisToplam;
    }
}
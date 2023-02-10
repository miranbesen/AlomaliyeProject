namespace AlomaliyeProject
{
    partial class FİRMALAR
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
            this.DgvFirmaKayit = new System.Windows.Forms.DataGridView();
            this.txtFirmaAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirmaKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnMaasBordro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFirmaKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFirmaKayit
            // 
            this.DgvFirmaKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFirmaKayit.Location = new System.Drawing.Point(675, 50);
            this.DgvFirmaKayit.Name = "DgvFirmaKayit";
            this.DgvFirmaKayit.RowHeadersWidth = 51;
            this.DgvFirmaKayit.RowTemplate.Height = 24;
            this.DgvFirmaKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFirmaKayit.Size = new System.Drawing.Size(559, 595);
            this.DgvFirmaKayit.TabIndex = 14;
            this.DgvFirmaKayit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFirmaKayit_CellClick);
            this.DgvFirmaKayit.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvFirmaKayit_CellMouseDoubleClick);
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.Location = new System.Drawing.Point(170, 91);
            this.txtFirmaAd.Multiline = true;
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.Size = new System.Drawing.Size(343, 97);
            this.txtFirmaAd.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Adı-Soyadı / Unvanı";
            // 
            // txtFirmaKod
            // 
            this.txtFirmaKod.Location = new System.Drawing.Point(170, 50);
            this.txtFirmaKod.Name = "txtFirmaKod";
            this.txtFirmaKod.Size = new System.Drawing.Size(183, 22);
            this.txtFirmaKod.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Firma Kod(12 Hane)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Firma Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSil.Location = new System.Drawing.Point(324, 600);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(148, 45);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDuzenle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDuzenle.Location = new System.Drawing.Point(170, 600);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(148, 45);
            this.btnDuzenle.TabIndex = 16;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYeniKayit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYeniKayit.Location = new System.Drawing.Point(16, 600);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(148, 45);
            this.btnYeniKayit.TabIndex = 15;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = false;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTemizle.Location = new System.Drawing.Point(365, 223);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(148, 45);
            this.btnTemizle.TabIndex = 23;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnMaasBordro
            // 
            this.btnMaasBordro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaasBordro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaasBordro.Location = new System.Drawing.Point(478, 600);
            this.btnMaasBordro.Name = "btnMaasBordro";
            this.btnMaasBordro.Size = new System.Drawing.Size(142, 45);
            this.btnMaasBordro.TabIndex = 24;
            this.btnMaasBordro.Text = "Maas Bordro";
            this.btnMaasBordro.UseVisualStyleBackColor = false;
            this.btnMaasBordro.Click += new System.EventHandler(this.btnMaasBordro_Click);
            // 
            // FİRMALAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 670);
            this.Controls.Add(this.btnMaasBordro);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtFirmaAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirmaKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.DgvFirmaKayit);
            this.Name = "FİRMALAR";
            this.Text = "FİRMALAR";
            this.Load += new System.EventHandler(this.FİRMALAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFirmaKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFirmaKayit;
        private System.Windows.Forms.TextBox txtFirmaAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirmaKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnMaasBordro;
    }
}
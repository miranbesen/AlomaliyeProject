namespace AlomaliyeProject
{
    partial class MAASBORDRO
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
            this.DgvFirmaPersonel = new System.Windows.Forms.DataGridView();
            this.cbFirmaAd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dgvMaasBordro = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFirmaPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaasBordro)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFirmaPersonel
            // 
            this.DgvFirmaPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFirmaPersonel.Location = new System.Drawing.Point(16, 103);
            this.DgvFirmaPersonel.Name = "DgvFirmaPersonel";
            this.DgvFirmaPersonel.RowHeadersWidth = 51;
            this.DgvFirmaPersonel.RowTemplate.Height = 24;
            this.DgvFirmaPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFirmaPersonel.Size = new System.Drawing.Size(550, 451);
            this.DgvFirmaPersonel.TabIndex = 15;
            this.DgvFirmaPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFirmaPersonel_CellClick);
            // 
            // cbFirmaAd
            // 
            this.cbFirmaAd.FormattingEnabled = true;
            this.cbFirmaAd.Location = new System.Drawing.Point(120, 14);
            this.cbFirmaAd.Name = "cbFirmaAd";
            this.cbFirmaAd.Size = new System.Drawing.Size(165, 24);
            this.cbFirmaAd.TabIndex = 16;
            this.cbFirmaAd.SelectedIndexChanged += new System.EventHandler(this.cbFirmaAd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Firma Adı:";
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonelGetir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPersonelGetir.Location = new System.Drawing.Point(12, 586);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(148, 45);
            this.btnPersonelGetir.TabIndex = 18;
            this.btnPersonelGetir.Text = "Personel Getir";
            this.btnPersonelGetir.UseVisualStyleBackColor = false;
            this.btnPersonelGetir.Click += new System.EventHandler(this.btnPersonelGetir_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHesapla.Location = new System.Drawing.Point(176, 586);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(148, 45);
            this.btnHesapla.TabIndex = 19;
            this.btnHesapla.Text = "Hesaplat";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSil.Location = new System.Drawing.Point(347, 586);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(148, 45);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeri.Location = new System.Drawing.Point(511, 585);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(145, 46);
            this.btnGeri.TabIndex = 50;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(919, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Bugün Tarihi:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(1053, 18);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(53, 20);
            this.lblTarih.TabIndex = 53;
            this.lblTarih.Text = "label3";
            // 
            // dgvMaasBordro
            // 
            this.dgvMaasBordro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaasBordro.Location = new System.Drawing.Point(595, 103);
            this.dgvMaasBordro.Name = "dgvMaasBordro";
            this.dgvMaasBordro.RowHeadersWidth = 51;
            this.dgvMaasBordro.RowTemplate.Height = 24;
            this.dgvMaasBordro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaasBordro.Size = new System.Drawing.Size(572, 451);
            this.dgvMaasBordro.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(202, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Personel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(810, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "MaasBordro";
            // 
            // MAASBORDRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMaasBordro);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnPersonelGetir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFirmaAd);
            this.Controls.Add(this.DgvFirmaPersonel);
            this.Name = "MAASBORDRO";
            this.Text = "MAASBORDRO";
            this.Load += new System.EventHandler(this.MAASBORDRO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFirmaPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaasBordro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFirmaPersonel;
        private System.Windows.Forms.ComboBox cbFirmaAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DataGridView dgvMaasBordro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
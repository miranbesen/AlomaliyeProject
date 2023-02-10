namespace AlomaliyeProject
{
    partial class DonemselUcretForm
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtbYil = new System.Windows.Forms.MaskedTextBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label12.Location = new System.Drawing.Point(166, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 22);
            this.label12.TabIndex = 49;
            this.label12.Text = "Maaş:";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(249, 22);
            this.txtMaas.Multiline = true;
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(118, 24);
            this.txtMaas.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label11.Location = new System.Drawing.Point(28, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 22);
            this.label11.TabIndex = 47;
            this.label11.Text = "Yıl:";
            // 
            // mtbYil
            // 
            this.mtbYil.Location = new System.Drawing.Point(78, 24);
            this.mtbYil.Mask = "0000";
            this.mtbYil.Name = "mtbYil";
            this.mtbYil.Size = new System.Drawing.Size(58, 22);
            this.mtbYil.TabIndex = 46;
            this.mtbYil.ValidatingType = typeof(int);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYeniKayit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYeniKayit.Location = new System.Drawing.Point(18, 110);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(145, 45);
            this.btnYeniKayit.TabIndex = 50;
            this.btnYeniKayit.Text = "Ekle";
            this.btnYeniKayit.UseVisualStyleBackColor = false;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTemizle.Location = new System.Drawing.Point(249, 72);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(118, 34);
            this.btnTemizle.TabIndex = 51;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeri.Location = new System.Drawing.Point(249, 121);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(118, 34);
            this.btnGeri.TabIndex = 52;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // DonemselUcretForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 182);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mtbYil);
            this.Name = "DonemselUcretForm";
            this.Text = "DonemselUcretForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbYil;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGeri;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlomaliyeProject
{
    public partial class DonemselUcretForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = MIRANPC\SQLEXPRESS;Initial Catalog = TimecomDB; Integrated Security = True");
        public int personelId { get; set; }
        public int firmaId { get; set; }
        public string firmaAd { get; set; }
        public DonemselUcretForm()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Personel_Maas VALUES (@PersonelId,@Yil,@Maas)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PersonelId", this.personelId);
                cmd.Parameters.AddWithValue("@Yil", Convert.ToInt32(mtbYil.Text));
                cmd.Parameters.AddWithValue("@Maas", Convert.ToDecimal((txtMaas.Text).Replace(".", ",")));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Personel Maas is successfully saved in database!!!");
                ShowPersonelForm();
            }
        }

        private bool IsValid()
        {
            if (mtbYil.Text == string.Empty || txtMaas.Text == string.Empty)
            {
                MessageBox.Show("Maas and yil Area is required!!!");
                return false;
            }
            return true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            mtbYil.Clear();
            txtMaas.Clear();
        }

        private void ShowPersonelForm()
        {
            this.Hide();
            var personelForm = new PERSONELLER();
            personelForm.firmaAd = this.firmaAd;
            personelForm.firmaId = this.firmaId;
            personelForm.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            ShowPersonelForm();
        }
    }
}

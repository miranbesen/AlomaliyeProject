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
    public partial class FİRMALAR : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = MIRANPC\SQLEXPRESS;Initial Catalog = TimecomDB; Integrated Security = True");
        public int firmaId;
        public FİRMALAR()
        {
            InitializeComponent();
        }

        private void FİRMALAR_Load(object sender, EventArgs e)
        {
            GetFirmaRecord();
        }

        private void GetFirmaRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Firma", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            DgvFirmaKayit.DataSource = dt;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Firma VALUES (@kod,@ad)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@kod", txtFirmaKod.Text);
                cmd.Parameters.AddWithValue("@ad", txtFirmaAd.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Firma is successfully saved in database!!!");
                GetFirmaRecord();
                ResetFormControls();
            }
        }

        private void ResetFormControls()
        {
            firmaId = 0;
            txtFirmaAd.Clear();
            txtFirmaKod.Clear();
        }

        private bool IsValid()
        {
            if (txtFirmaAd.Text == string.Empty)
            {
                MessageBox.Show("Firma Ad area is required!!!");
                return false;
            }
            return true;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (firmaId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Firma SET Firma_Kodu=@kod,Firma_Adi=@ad WHERE Id=@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.firmaId);
                cmd.Parameters.AddWithValue("@kod", txtFirmaKod.Text);
                cmd.Parameters.AddWithValue("@ad", txtFirmaAd.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Firma update is successfully in database!!!");
                GetFirmaRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select firma for update!");
            }
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            if (firmaId > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Firma WHERE Id=@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.firmaId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Firma delete is successfully in database!!!");
                GetFirmaRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select firma for delete!");
            }
        }

        private void DgvFirmaKayit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            firmaId = Convert.ToInt32(DgvFirmaKayit.SelectedRows[0].Cells[0].Value);
            txtFirmaKod.Text = DgvFirmaKayit.SelectedRows[0].Cells[1].Value.ToString();
            txtFirmaAd.Text = DgvFirmaKayit.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void DgvFirmaKayit_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Hide();
            var personelForm = new PERSONELLER();
            personelForm.firmaAd = txtFirmaAd.Text;
            personelForm.firmaId = firmaId;
            personelForm.Show();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void btnMaasBordro_Click(object sender, EventArgs e)
        {
            this.Hide();
            var maasBordroForm = new MAASBORDRO();
            maasBordroForm.Show();
        }
    }
}

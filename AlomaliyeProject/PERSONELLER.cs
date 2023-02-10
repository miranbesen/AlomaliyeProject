using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlomaliyeProject
{
    public partial class PERSONELLER : Form
    {


        public int firmaId { get; set; }
        public string firmaAd { get; set; }

        public int personelId;

        SqlConnection con = new SqlConnection(@"Data Source = MIRANPC\SQLEXPRESS;Initial Catalog = TimecomDB; Integrated Security = True");

        public PERSONELLER()
        {
            InitializeComponent();
        }

        private void PERSONELLER_Load(object sender, EventArgs e)
        {
            GetPersonelRecord();
            lblFirmaAd.Text = firmaAd;
        }

        private void GetPersonelRecord()
        {
            SqlCommand cmd = new SqlCommand("Select Personel_Kod,Ad,Soyad from Personel WHERE Firma_Id=@FirmaId", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@FirmaId", this.firmaId);
            DataTable dt = new DataTable();

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            DgvPersonelKayit.DataSource = dt;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Personel VALUES (@firmaId,@ad,@soyad,@tcNo,@perKod,@cinsiyet,@iseBaslamaTarih,@engellilik,@CalismaSekli)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@firmaId", this.firmaId);
                cmd.Parameters.AddWithValue("@ad", txtPerAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtPerSoyad.Text);
                cmd.Parameters.AddWithValue("@tcNo", txtTC.Text);
                cmd.Parameters.AddWithValue("@perKod", txtPerKod.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", cbCinsiyet.Text);
                cmd.Parameters.AddWithValue("@iseBaslamaTarih", dtpİseBaslangicTarih.Value);
                cmd.Parameters.AddWithValue("@engellilik", cbEngellilikDurum.Text);
                cmd.Parameters.AddWithValue("@CalismaSekli", cbCalismaSekli.Text);
                con.Open();
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("SELECT TOP(1) Id FROM Personel ORDER BY Id DESC", con);
                SqlDataReader idReader = null;
                idReader = cmd2.ExecuteReader();
                string stringIdReader = "";
                if (idReader.Read())
                {
                    stringIdReader = idReader.GetValue(0).ToString();
                }

                con.Close();

                con.Open();
                SqlCommand cmd3 = new SqlCommand("INSERT INTO Personel_Maas VALUES (@personelId,@yil,@maas)", con);
                cmd3.CommandType = CommandType.Text;
                cmd3.Parameters.AddWithValue("@personelId", Convert.ToInt32(stringIdReader));
                cmd3.Parameters.AddWithValue("@yil", Convert.ToInt32(mtbYil.Text));
                cmd3.Parameters.AddWithValue("@maas", Convert.ToDecimal((txtMaas.Text).Replace(".", ",")));

                cmd3.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("New Personel is successfully saved in database!!!");
                GetPersonelRecord();
                ResetFormControls();
            }
        }
        private void ResetFormControls()
        {
            personelId = 0;
            txtMaas.Clear();
            txtPerAd.Clear();
            txtPerKod.Clear();
            txtPerSoyad.Clear();
            txtTC.Clear();
            mtbYil.Clear();
            cbCalismaSekli.Text = null;
            cbCinsiyet.Text = null; ;
            cbEngellilikDurum.Text = null;
            dtpİseBaslangicTarih.Text = string.Empty;

        }

        private bool IsValid()
        {
            if (txtPerAd.Text == string.Empty || txtMaas.Text == string.Empty || mtbYil.Text==string.Empty)
            {
                MessageBox.Show("Personel Ad, Maas and Yil Area is required!!!");
                return false;
            }
            return true;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (personelId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Personel SET Ad=@ad,Soyad=@soyad,Tc_No=@tcNo,Personel_Kod=@personelKod,Cinsiyet=@cinsiyet,Ise_Baslama_Tarihi=@iseBaslamaTarihi,Engellilik_Durumu=@engellilikDurumu,Calisma_Sekli=@calismaSekli WHERE Id=@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.personelId);
                cmd.Parameters.AddWithValue("@ad", txtPerAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtPerSoyad.Text);
                cmd.Parameters.AddWithValue("@tcNo", txtTC.Text);
                cmd.Parameters.AddWithValue("@personelKod", txtPerKod.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", cbCinsiyet.Text);
                cmd.Parameters.AddWithValue("@iseBaslamaTarihi", dtpİseBaslangicTarih.Value);
                cmd.Parameters.AddWithValue("@engellilikDurumu", cbEngellilikDurum.Text);
                cmd.Parameters.AddWithValue("@calismaSekli", cbCalismaSekli.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE Personel_Maas SET Yil=@yil,Maas=@maas WHERE Personel_Id=@personelId AND Yil=@eskiYil", con);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@personelId", this.personelId);
                cmd2.Parameters.AddWithValue("@eskiYil", mtbYil.Text);
                cmd2.Parameters.AddWithValue("@yil", Convert.ToInt32(mtbYil.Text));
                cmd2.Parameters.AddWithValue("@maas", Convert.ToDecimal((txtMaas.Text).Replace(".", ",")));
                MessageBox.Show(" Personel update is successfully in database!!!");
                cmd2.ExecuteNonQuery();
                con.Close();
                GetPersonelRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select personel for update!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (personelId > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Personel WHERE Id=@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.personelId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd2 = new SqlCommand("DELETE FROM Personel_Maas WHERE Personel_Id=@Id", con);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@Id", this.personelId);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Personel delete is successfully in database!!!");
                GetPersonelRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select personel for delete!");
            }
        }

        private void DgvPersonelKayit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPerKod.Text = DgvPersonelKayit.SelectedRows[0].Cells[0].Value.ToString();
            txtPerAd.Text = DgvPersonelKayit.SelectedRows[0].Cells[1].Value.ToString();
            txtPerSoyad.Text = DgvPersonelKayit.SelectedRows[0].Cells[2].Value.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id,Tc_No,Cinsiyet,Ise_Baslama_Tarihi,Engellilik_Durumu,Calisma_Sekli FROM Personel WHERE Personel_Kod=@PerKod", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@PerKod", txtPerKod.Text);
            SqlDataReader cmdReader = null;
            cmdReader = cmd.ExecuteReader();
            string personelIdReader = "";
            string tcNo = "";
            string cinsiyet = "";
            string engellilikDurum = "";
            string calismaSekli = "";
            string dateTime = "";
            if (cmdReader.Read())
            {
                personelIdReader = cmdReader.GetValue(0).ToString();
                tcNo = cmdReader.GetValue(1).ToString();
                cinsiyet = cmdReader.GetValue(2).ToString();
                dateTime = cmdReader.GetValue(3).ToString();
                engellilikDurum = cmdReader.GetValue(4).ToString();
                calismaSekli = cmdReader.GetValue(5).ToString();
            }
            personelId = Convert.ToInt32(personelIdReader);
            txtTC.Text = tcNo;
            cbCalismaSekli.Text = calismaSekli;
            cbEngellilikDurum.Text = engellilikDurum;
            cbCinsiyet.Text = cinsiyet;
            dtpİseBaslangicTarih.Text = dateTime;
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT TOP(1) Maas,Yil FROM Personel_Maas WHERE Personel_Id=@personelId ORDER BY Yil DESC", con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@personelId", personelId);
            SqlDataReader cmd2Reader = cmd2.ExecuteReader();
            string maas = "";
            string yil = "";
            if (cmd2Reader.Read())
            {
                maas = cmd2Reader.GetValue(0).ToString();
                yil = cmd2Reader.GetValue(1).ToString();
            }
            mtbYil.Text = yil;
            txtMaas.Text = maas;
            con.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var firmaForm = new FİRMALAR();
            firmaForm.Show();

        }

        private void btnDonemselUcret_Click(object sender, EventArgs e)
        {
            this.Hide();
            var donemselUcretForm = new DonemselUcretForm();
            donemselUcretForm.personelId = this.personelId;
            donemselUcretForm.firmaId = this.firmaId;
            donemselUcretForm.firmaAd = this.firmaAd;
            donemselUcretForm.Show();

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtMaas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mtbYil_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


    }
}

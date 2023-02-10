using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlomaliyeProject
{

    public partial class MAASBORDRO : Form
    {
        public int normalGun, haftasonuGun;
        public int personelId;
        public int bordroMaasId;
        public int ay, yil, ayToplamGun;
        public Decimal gunlukUcret, gelirVergisi, bes, netUcret;
        public int firmaId;
        public string personelTc;
        private bool bayrakPersonelKontrol;

        SqlConnection con = new SqlConnection(@"Data Source = MIRANPC\SQLEXPRESS;Initial Catalog = TimecomDB; Integrated Security = True");


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (bayrakPersonelKontrol) //personel secimi yapma kont
            {
                bool bayrakMaasBordroKontrol;
                DateTime tarih = DateTime.Now;
                this.yil = tarih.Year;
                this.ay = tarih.Month;
                this.ayToplamGun = Convert.ToInt32(AyinToplamGunu(DateTime.Now));
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP(1) Maas,Yil FROM Personel_Maas WHERE Personel_Id=@personelId ORDER BY Yil DESC", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@personelId", this.personelId);
                SqlDataReader cmdReader = cmd.ExecuteReader();
                string maas = "";
                if (cmdReader.Read())
                {
                    maas = cmdReader.GetValue(0).ToString();
                }
                con.Close();
                gunlukUcret = (Decimal)Math.Round(Convert.ToDecimal(maas) / (Decimal)ayToplamGun, 2);
                this.normalGun = NormalGunSayisiBulma();
                haftasonuGun = ayToplamGun - this.normalGun;
                gelirVergisi = (Decimal)Math.Round(((gunlukUcret * this.normalGun) * 15) / 100, 2);
                bes = (Decimal)Math.Round(((gunlukUcret * this.normalGun) * 3) / 100, 2);
                netUcret = (Decimal)Math.Round((Convert.ToDecimal(maas) - gelirVergisi) - bes, 2);
                bayrakMaasBordroKontrol = IsValid();
                AddBordroMaas(bayrakMaasBordroKontrol);
                GetMaasBordro();
            }
            else
            {
                MessageBox.Show("Lütfen bir personel seciniz!!");
            }

        }

        private bool IsValid()
        {
            SqlCommand cmd = new SqlCommand("SELECT Personel_Id,Ay FROM Maas_Bordro WHERE Personel_Id=@personelId AND Ay=@ay", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@personelId", this.personelId);
            cmd.Parameters.AddWithValue("@ay", this.ay);
            SqlDataReader cmdReader = cmd.ExecuteReader();
            if (cmdReader.Read())
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;


        }


        private void AddBordroMaas(bool bayrakMaasBordroKontrol)
        {
            if (bayrakMaasBordroKontrol)
            {
                SqlCommand cmd2 = new SqlCommand("INSERT INTO Maas_Bordro VALUES (@personelId,@personelTc,@ay,@yil,@gunlukUcret,@gelirVergisi,@bes,@normalGun,@haftaSonuGun,@netUcret)", con);
                con.Open();
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@personelId", this.personelId);
                cmd2.Parameters.AddWithValue("@personelTc", this.personelTc);
                cmd2.Parameters.AddWithValue("@ay", ay);
                cmd2.Parameters.AddWithValue("@yil", yil);
                cmd2.Parameters.AddWithValue("@gunlukUcret", gunlukUcret);
                cmd2.Parameters.AddWithValue("@gelirVergisi", gelirVergisi);
                cmd2.Parameters.AddWithValue("@bes", bes);
                cmd2.Parameters.AddWithValue("@normalGun", normalGun);
                cmd2.Parameters.AddWithValue("@haftaSonuGun", haftasonuGun);
                cmd2.Parameters.AddWithValue("@netUcret", netUcret);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(ay + "/" + yil + "Bordrosu kaydedildi.");

            }
            else
            {
                MessageBox.Show("Bu ayın bordrosu önceden kaydedilmiştir");
            }

        }

        private void GetMaasBordro()
        {
            SqlCommand cmd = new SqlCommand("Select Personel_Tc, Ay, Yil, Gunluk_Ucret, Gelir_Vergisi, Bes, Normal_Gun, Haftasonu_Gun, Net_Ucret  from Maas_Bordro WHERE Personel_Id=@personelId", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@personelId", this.personelId);
            DataTable dt = new DataTable();
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dgvMaasBordro.DataSource = dt;
        }

        private int NormalGunSayisiBulma()
        {
            var list = Enumerable.Range(1, DateTime.DaysInMonth(yil, ay))
                                  .Select(day => new DateTime(yil, ay, day))
                                  .Where(dt => dt.DayOfWeek != DayOfWeek.Sunday &&
                                               dt.DayOfWeek != DayOfWeek.Saturday)
                                  .ToList();

            return list.Count();
        }

        private string AyinToplamGunu(DateTime tarih)
        {
            tarih = new DateTime(tarih.Year, tarih.Month, 1);
            return tarih.AddMonths(1).AddDays(-1).Day.ToString();
        }

        private void cbFirmaAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string firmaAd = cbFirmaAd.Text;

            SqlCommand cmd = new SqlCommand("SELECT Id FROM Firma WHERE Firma_Adi=@firmaAdi", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@firmaAdi", firmaAd);
            SqlDataReader rowIdReader = cmd.ExecuteReader();
            string strRowIdReader = "";
            if (rowIdReader.Read())
            {
                strRowIdReader = rowIdReader.GetValue(0).ToString();
            }
            this.firmaId = Convert.ToInt32(strRowIdReader);
            con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }


        private void DgvFirmaPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bayrakPersonelKontrol = true;
            DgvFirmaPersonel.CurrentRow.Selected = true;
            this.personelTc = DgvFirmaPersonel.Rows[e.RowIndex].Cells["Tc_No"].Value.ToString();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Personel WHERE Tc_No=@tcNo", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@tcNo", this.personelTc);
            SqlDataReader rowIdReader = cmd.ExecuteReader();
            string strRowIdReader = "";
            if (rowIdReader.Read())
            {
                strRowIdReader = rowIdReader.GetValue(0).ToString();
            }
            con.Close();
            this.personelId = Convert.ToInt32(strRowIdReader);
        }

        public MAASBORDRO()
        {
            InitializeComponent();
        }

        private void MAASBORDRO_Load(object sender, EventArgs e)
        {

            GetFirmaList();
            lblTarih.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void GetFirmaList()
        {
            DataTable dt = null;
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT Firma_Adi FROM Firma", con))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Firma_Adi FROM Firma", con);
                dt = new DataTable("TName");
                da.Fill(dt);
            }
            con.Close();
            cbFirmaAd.DisplayMember = "Firma_Adi";
            cbFirmaAd.ValueMember = "Id";
            cbFirmaAd.DataSource = dt;

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var firmaForm = new FİRMALAR();
            firmaForm.Show();
        }

        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {

            using (SqlCommand cmd2 = new SqlCommand("Select Ad,Soyad,Tc_No, Ise_Baslama_Tarihi from Personel WHERE Firma_Id=@FirmaId", con))
            {

                DataTable dt = new DataTable();
                con.Open();
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@FirmaId", this.firmaId);
                SqlDataReader sdr = cmd2.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                DgvFirmaPersonel.DataSource = dt;
            }
        }
    }
}
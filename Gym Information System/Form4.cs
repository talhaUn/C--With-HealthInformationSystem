using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_Information_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public adminInformation adminInformation4 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataReader dr;

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dat = new SqlDataAdapter("Select id,policlinicName AS 'Poliklinik Adı', patientName AS 'Müşteri Adı', conformity AS 'Kısıt Bilgisi', eligibilityDetail AS 'Kısıt Detayı' From diagnosis where patientTc ='" + txtTc.Text + "'", con);
            DataSet dst = new DataSet();
            con.Open();
            dat.Fill(dst, "diagnosis");
            bunifuCustomDataGrid1.DataSource = dst.Tables[0];
            con.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bunifuCustomDataGrid1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("Select * from diagnosis where id='" + bunifuCustomDataGrid1.SelectedRows[i].Cells["id"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    txtUygunluk.Text = dr["conformity"].ToString();
                    richTextBox2.Text = dr["eligibilityDetail"].ToString();
                    if (txtUygunluk.Text == "Uygun")
                    {
                        txtUygunluk.BackColor = Color.LimeGreen;
                        richTextBox2.Visible = false;
                        
                    }
                    if (txtUygunluk.Text == "Kısmi Uygun")
                    {
                        txtUygunluk.BackColor = Color.Orange;
                        richTextBox2.Visible = true;
                        
                    }
                    if (txtUygunluk.Text == "Uygun Değil")
                    {
                        txtUygunluk.BackColor = Color.Red;
                        richTextBox2.Visible = false;
                        
                    }

                }
                else
                {
                    MessageBox.Show("Hata");
                }
                con.Close();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtUygunluk.Text == "Uygun Değil")
            {
                MessageBox.Show("Bu kişi kaydedilemez. Çünkü sağlığı elverişli değil. Yanlış Olduğu Düşünülüyor Düşünülüyor İse Müşteri Doktorla Görüşmeli.","Kayıt Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string kayit = "insert into customerGym(nameSurname,telNo,eMail,movements,address,tcNo,recordingTime,suitability,date,companyid) values(@nameSurname,@telNo,@eMail,@movements,@address,@tcNo,@recordingTime,@suitability,@date,@companyid)";
                    SqlCommand komut = new SqlCommand(kayit, con);

                    komut.Parameters.AddWithValue("@nameSurname", txtAd.Text);
                    komut.Parameters.AddWithValue("@telNo", txtTel.Text);
                    komut.Parameters.AddWithValue("@eMail", txtMail.Text);
                    komut.Parameters.AddWithValue("@movements", richTextBox2.Text);
                    komut.Parameters.AddWithValue("@suitability", txtUygunluk.Text);
                    komut.Parameters.AddWithValue("@tcNo", txtTc.Text);
                    komut.Parameters.AddWithValue("@recordingTime", txtKayit.Text);
                    komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                    komut.Parameters.AddWithValue("@address", richTextBox1.Text);
                    komut.Parameters.AddWithValue("@companyid", adminInformation4.companyid);
                    komut.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Müşteri Kayıt Edildi","Kayıt Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Question);

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu!" + hata.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation3 = adminInformation4;
            form3.bunifuMaterialTextbox1.Text = adminInformation4.nameSurname;
            form3.bunifuMaterialTextbox2.Text = adminInformation4.companyName;
            form3.Show();
            this.Close();
        }
    }
}

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

namespace healthInformationSystem
{

    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public adminInformation adminInformation6 { get; set; }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = adminInformation6.id.ToString();
            textBox2.Text = adminInformation6.nameSurname;
            textBox3.Text = adminInformation6.tcNo;
            textBox4.Text = adminInformation6.telNo;
            richTextBox1.Text = adminInformation6.address;
            textBox6.Text = adminInformation6.eMail;
            textBox7.Text = adminInformation6.password;
            textBox8.Text = adminInformation6.hospitalName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                var kayit = "UPDATE adminInformation Set eMail=@eMail,password=@password  WHERE  id=" + adminInformation6.id;
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@eMail", textBox6.Text);
                komut.Parameters.AddWithValue("@password", textBox7.Text);

                if (textBox6.Text == "")
                {

                    MessageBox.Show("E-Posta Alanı Boş Bırakılamaz");

                    return;

                }

                if (textBox7.Text == "")
                {

                    MessageBox.Show("Şifre Alanı Boş Bırakılamaz");

                    return;

                }

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bilgileriniz Başarıyla Değiştirilmiştir!" + " " + "Lütfen Tekrar Giriş Yapınız!");
                this.Close();
                Application.Exit();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation2 = adminInformation6;
            form3.label1.Text = "Hoşgeldiniz Sayın" + " " + adminInformation6.nameSurname;
            form3.Show();
            this.Close();
        }
    }
}


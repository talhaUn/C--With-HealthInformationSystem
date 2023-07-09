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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        public patientInformation patientInformation5 { get; set; }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");

        private void Form18_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            textBox1.Text = patientInformation5.nameSurname;
            maskedTextBox1.Text = patientInformation5.tcNo;
            maskedTextBox2.Text = patientInformation5.telNo;
            dateTimePicker1.Text = patientInformation5.dateOfBirth;
            textBox2.Text = patientInformation5.eMail;
            textBox3.Text = patientInformation5.password;
            richTextBox1.Text = patientInformation5.address;
            label8.Text = "Kaydeildiği Hastane :" + patientInformation5.hospitalName;
            label9.Text = "Kaydeden Çalışan Adı :" + patientInformation5.secreteryName;
            label10.Text = "Kaydedilen Tarih :" + patientInformation5.dateOfRegistration;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                var kayit = "UPDATE patientInformation Set nameSurname=@nameSurname,tcNo=@tcNo,telNo=@telNo,dateOfBirth=@dateOfBirth,eMail=@eMail,password=@password,address=@address  WHERE  id=" + patientInformation5.id;
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@nameSurname", textBox1.Text);
                komut.Parameters.AddWithValue("@tcNo", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@telNo", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@dateOfBirth", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@eMail", textBox2.Text);
                komut.Parameters.AddWithValue("@password", textBox3.Text);
                komut.Parameters.AddWithValue("@address", richTextBox1.Text);

                if (textBox1.Text == "")
                {

                    MessageBox.Show("Ad Soyad Bölümü Boş Bırakılamaz.");

                    return;

                }

                if (maskedTextBox1.Text == "")
                {

                    MessageBox.Show("T.C No Bölümü Boş Bırakılamaz.");

                    return;

                }

                if (maskedTextBox2.Text == "")
                {

                    MessageBox.Show("Telefon No Bölümü Boş Bırakılamaz.");

                    return;

                }

                if (textBox2.Text == "")
                {

                    MessageBox.Show("E-Posta Bölümü Boş Bırakılamaz.");

                    return;

                }

                if (dateTimePicker1.Text == "")
                {

                    MessageBox.Show("Doğum Tarihi Bölümü Boş Bırakılamaz.");

                    return;

                }

                if (textBox3.Text == "")
                {

                    MessageBox.Show("Şifre Bölümü Boş Bırakılamaz.");

                    return;

                }

                if (richTextBox1.Text == "")
                {

                    MessageBox.Show("Adres Bölümü Boş Bırakılamaz");

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
            Form15 form15 = new Form15();
            form15.patientInformation1 = patientInformation5;
            form15.label1.Text = "Hoşgeldiniz Sayın" + " " + patientInformation5.nameSurname;
            form15.Show();
            this.Close();
        }
    }
}

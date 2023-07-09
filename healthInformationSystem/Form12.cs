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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation12 { get; set; }

        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            txtAd.Text = employeeInformation12.nameSurname;
            txtTc.Text = employeeInformation12.tcNo;
            txtTel.Text = employeeInformation12.telNo;
            richTextBox1.Text = employeeInformation12.address;
            txtUnvan.Text = employeeInformation12.title;
            txtDepart.Text = employeeInformation12.department;
            txtHastane.Text = employeeInformation12.hospitalName;
            txtMail.Text = employeeInformation12.eMail;
            txtSifre.Text = employeeInformation12.password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update employeeInformation set telNo=@telNo,address=@address,eMail=@eMail,password=@password where tcNo=@tcNo";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@telNo", txtTel.Text);
            komut.Parameters.AddWithValue("@address", richTextBox1.Text);
            komut.Parameters.AddWithValue("@eMail", txtMail.Text);
            komut.Parameters.AddWithValue("@password", txtSifre.Text);
            komut.Parameters.AddWithValue("@tcNo", txtTc.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir. Güncellenemeyen bilgiler için lütfen çalıştığınız hastanenizdeki admin ile görüşünüz.");
            MessageBox.Show("Tekrar Giriş Yapınız");
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.employeeInformation2 = employeeInformation12;
            form9.Show();
            form9.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation12.nameSurname;
            this.Close();
        }
    }
}

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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation22 { get; set; }

        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void Form22_Load(object sender, EventArgs e)
        {
            txtAd.Text = employeeInformation22.nameSurname;
            txtTc.Text = employeeInformation22.tcNo;
            txtTel.Text = employeeInformation22.telNo;
            richTextBox1.Text = employeeInformation22.address;
            txtUnvan.Text = employeeInformation22.title;
            txtDepart.Text = employeeInformation22.department;
            txtHastane.Text = employeeInformation22.hospitalName;
            txtMail.Text = employeeInformation22.eMail;
            txtSifre.Text = employeeInformation22.password;
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

        private void Form22_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.employeeInformation3 = employeeInformation22;
            form10.Show();
            form10.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation22.nameSurname;
            this.Close();
        }
    }
}

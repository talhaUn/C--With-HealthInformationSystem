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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        private void Form14_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string tc = txttc.Text;
            string password = txtpassword.Text;
            con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*from patientInformation where tcNo ='" + txttc.Text + "'And password ='" + txtpassword.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                patientInformation patientInformation = new patientInformation();
                patientInformation.id = Convert.ToInt32(dr["id"]);
                patientInformation.nameSurname = dr["nameSurname"].ToString();
                patientInformation.tcNo = dr["tcNo"].ToString();
                patientInformation.telNo = dr["telNo"].ToString();
                patientInformation.dateOfBirth = dr["dateOfBirth"].ToString();
                patientInformation.eMail = dr["eMail"].ToString();
                patientInformation.gender = dr["gender"].ToString();
                patientInformation.password = dr["password"].ToString();
                patientInformation.address = dr["address"].ToString();
                patientInformation.hospitalName = dr["hospitalName"].ToString();
                patientInformation.diagnostic = dr["diagnostic"].ToString();
                patientInformation.dateOfRegistration = dr["dateOfRegistration"].ToString();
                patientInformation.secreteryName = dr["secretaryName"].ToString();

                Form15 form15 = new Form15();
                form15.patientInformation1 = patientInformation;
                form15.label1.Text = "Hoşgeldiniz Sayın" + " " + patientInformation.nameSurname;

                form15.Show();
                this.Close();
                MessageBox.Show("Giriş Başarılı!");

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz Lütfen Tekrar Deneyiniz!");
            }
            con.Close();
        }

        private void Form14_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(29, 209, 161);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
        }
    }
}

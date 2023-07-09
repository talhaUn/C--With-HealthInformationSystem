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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string tc = bunifuMaterialTextbox1.Text;
            string password = bunifuMaterialTextbox2.Text;
            if (tc == "" || password == "")
            {
                MessageBox.Show("Lütfen alanları boş bırakmayınız");
            }
            con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*from gymAdmin where tcNo ='" + bunifuMaterialTextbox1.Text + "'And password ='" + bunifuMaterialTextbox2.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                adminInformation adminInformation1 = new adminInformation();
                adminInformation1.id = Convert.ToInt32(dr["id"]);
                adminInformation1.companyid = Convert.ToInt32(dr["companyid"]);
                adminInformation1.telNo = dr["telNo"].ToString();
                adminInformation1.nameSurname = dr["nameSurname"].ToString();
                adminInformation1.tcNo = dr["tcNo"].ToString();
                adminInformation1.password = dr["password"].ToString();
                adminInformation1.address = dr["address"].ToString();
                adminInformation1.eMail = dr["eMail"].ToString();
                adminInformation1.companyName = dr["companyName"].ToString();

                Form3 form3 = new Form3();
                form3.adminInformation3 = adminInformation1;
                form3.bunifuMaterialTextbox1.Text = adminInformation1.nameSurname;
                form3.bunifuMaterialTextbox2.Text = adminInformation1.companyName;

                form3.Show();
                this.Hide();
                MessageBox.Show("Giriş Başarılı!");

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz Lütfen Tekrar Deneyiniz!");
            }
            con.Close();
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
        }
    }
}

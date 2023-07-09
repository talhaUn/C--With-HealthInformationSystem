using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace healthInformationSystem
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string tc = txttc.Text;
            string password = txtpassword.Text;
            if(tc == "" || password == "")
            {
                MessageBox.Show("Lütfen alanları boş bırakmayınız");
            }
            con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*from adminInformation where tcNo ='" + txttc.Text + "'And password ='" + txtpassword.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                adminInformation adminInformation1 = new adminInformation();
                adminInformation1.id = Convert.ToInt32(dr["id"]);
                adminInformation1.hospitalid = Convert.ToInt32(dr["hospitalid"]);
                adminInformation1.telNo = dr["telNo"].ToString();
                adminInformation1.nameSurname = dr["nameSurname"].ToString();
                adminInformation1.tcNo = dr["tcNo"].ToString();
                adminInformation1.password = dr["password"].ToString();
                adminInformation1.address = dr["address"].ToString();
                adminInformation1.eMail = dr["eMail"].ToString();
                adminInformation1.hospitalName = dr["hospitalName"].ToString();

                Form3 form3 = new Form3();
                form3.adminInformation2 = adminInformation1;
                form3.label1.Text = "Hoşgeldiniz Sayın" + " " + adminInformation1.nameSurname;

                form3.Show();
                this.Close();
                MessageBox.Show("Giriş Başarılı!");

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz Lütfen Tekrar Deneyiniz!");
            }
            con.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
            pictureBox1.BackColor = Color.Lime;
            pictureBox4.BackColor = Color.Lime;
            
        }

        private void Form2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255,128, 0);
            pictureBox1.BackColor = Color.FromArgb(255,128, 0);
            pictureBox4.BackColor = Color.FromArgb(255,128, 0);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            pictureBox1.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

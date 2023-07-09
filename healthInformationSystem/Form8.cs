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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
        }

        private void Form8_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(24, 220, 255);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string tc = txttc.Text;
            string password = txtpassword.Text;
            con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*from employeeInformation where tcNo ='" + txttc.Text + "'And password ='" + txtpassword.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                EmployeeInformation employeeInformation1 = new EmployeeInformation();
                employeeInformation1.id = Convert.ToInt32(dr["id"]);
                employeeInformation1.telNo = dr["telNo"].ToString();
                employeeInformation1.nameSurname = dr["nameSurname"].ToString();
                employeeInformation1.tcNo = dr["tcNo"].ToString();
                employeeInformation1.password = dr["password"].ToString();
                employeeInformation1.address = dr["address"].ToString();
                employeeInformation1.eMail = dr["eMail"].ToString();
                employeeInformation1.hospitalName = dr["hospitalName"].ToString();
                employeeInformation1.title = dr["title"].ToString();
                employeeInformation1.department = dr["department"].ToString();
                employeeInformation1.hospitalid = Convert.ToInt32(dr["hospitalid"]);
                if (employeeInformation1.title == "Hasta Kabul Sekreteri")
                {
                    employeeInformation1.policlinicid = 0;
                }
                if (employeeInformation1.title == "Doktor")
                {
                    employeeInformation1.policlinicid = Convert.ToInt32(dr["policlinicid"]);
                }


                if (employeeInformation1.title == "Hasta Kabul Sekreteri")
                {
                    Form9 form9 = new Form9();
                    form9.employeeInformation2 = employeeInformation1;
                    form9.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation1.nameSurname;
                    form9.Show();
                    this.Close();
                    MessageBox.Show("Giriş Başarılı!");
                }
                if (employeeInformation1.title == "Doktor")
                {
                    Form10 form10 = new Form10();
                    form10.employeeInformation3 = employeeInformation1;
                    form10.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation1.nameSurname;
                    form10.Show();
                    this.Close();
                    MessageBox.Show("Giriş Başarılı!");
                }
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz Lütfen Tekrar Deneyiniz!");
            }
            con.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

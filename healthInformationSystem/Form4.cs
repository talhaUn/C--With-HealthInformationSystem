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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        SqlDataReader dr;
        public adminInformation adminInformation3 { get; set; }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox5.Text = adminInformation3.hospitalName;
            textBox5.Enabled = false;
            comboBox1.Items.Add("Hasta Kabul Sekreteri");
            comboBox1.Items.Add("Doktor");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "Hasta Kabul Sekreteri")
            {
                comboBox2.DataSource = null;
                comboBox2.Items.Add("Hasta Kabul Sekreteri");
            }

            if(comboBox1.SelectedItem == "Doktor")
            {
                comboBox2.DataSource = null;
                SqlCommand komut = new SqlCommand("Select *from policlinic where hospitalid =" + adminInformation3.hospitalid, connect);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox2.DisplayMember = "policlinicName";
                comboBox2.ValueMember = "policlinicid";
                comboBox2.DataSource = dt;
                comboBox2.Items.Remove("Hasta Kabul Sekreteri");

            }
        }
        int employee;
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "Hasta Kabul Sekreteri")
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    string kayit = "insert into employeeInformation(nameSurname,telNo,eMail,password,address,tcNo,title,department,hospitalName,hospitalid) values(@nameSurname,@telNo,@eMail,@password,@address,@tcNo,@title,@department,@hospitalName,@hospitalid)";
                    SqlCommand komut = new SqlCommand(kayit, connect);

                    komut.Parameters.AddWithValue("@nameSurname", txtName.Text);
                    komut.Parameters.AddWithValue("@telNo", txtTel.Text);
                    komut.Parameters.AddWithValue("@eMail", txtMail.Text);
                    komut.Parameters.AddWithValue("@password", txtPassword.Text);
                    komut.Parameters.AddWithValue("@address", richTextBox1.Text);
                    komut.Parameters.AddWithValue("@tcNo", txtTc.Text);
                    komut.Parameters.AddWithValue("@title", comboBox1.Text);
                    komut.Parameters.AddWithValue("@department", comboBox2.Text);
                    komut.Parameters.AddWithValue("@hospitalName", textBox5.Text);
                    komut.Parameters.AddWithValue("@hospitalid", adminInformation3.hospitalid);
                    komut.ExecuteNonQuery();

                    connect.Close();
                    MessageBox.Show("Başarıyla Kayıt Olundu!");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu!" + hata.Message);
                }
            }


                if (comboBox1.SelectedItem == "Doktor")
                {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    string kayit = "insert into employeeInformation(nameSurname,telNo,eMail,password,address,tcNo,title,department,hospitalName,hospitalid,policlinicid) values(@nameSurname,@telNo,@eMail,@password,@address,@tcNo,@title,@department,@hospitalName,@hospitalid,@policlinicid)";
                    SqlCommand komut = new SqlCommand(kayit, connect);

                    komut.Parameters.AddWithValue("@nameSurname", txtName.Text);
                    komut.Parameters.AddWithValue("@telNo", txtTel.Text);
                    komut.Parameters.AddWithValue("@eMail", txtMail.Text);
                    komut.Parameters.AddWithValue("@password", txtPassword.Text);
                    komut.Parameters.AddWithValue("@address", richTextBox1.Text);
                    komut.Parameters.AddWithValue("@tcNo", txtTc.Text);
                    komut.Parameters.AddWithValue("@title", comboBox1.Text);
                    komut.Parameters.AddWithValue("@department", comboBox2.Text);
                    komut.Parameters.AddWithValue("@hospitalName", textBox5.Text);
                    komut.Parameters.AddWithValue("@hospitalid", adminInformation3.hospitalid);
                    komut.Parameters.AddWithValue("@policlinicid", comboBox2.SelectedValue);
                    komut.ExecuteNonQuery();

                    connect.Close();
                    MessageBox.Show("Başarıyla Kayıt Olundu!");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu!" + hata.Message);
                }
            }
  
                //komut.Parameters.AddWithValue("@policlinicid", );


            if (comboBox1.SelectedItem == "Doktor")
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("Select * from employeeInformation where tcNo='" + txtTc.Text + "'", connect);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    employee = Convert.ToInt32(dr["id"]);
                }
                else
                {

                }
                connect.Close();
            }
            if (comboBox1.SelectedItem == "Doktor")
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    string kayit = "insert into complaintNotification(complaintNotification,employeeid) values(@complaintNotification,@employeeid)";
                    SqlCommand komut = new SqlCommand(kayit, connect);
                    komut.Parameters.AddWithValue("@complaintNotification", 0);
                    komut.Parameters.AddWithValue("@employeeid", employee);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel Bildirimleri Kullanımda.");
                    connect.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu!" + hata.Message);
                }
            }


            txtName.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            txtPassword.Text = "";
            richTextBox1.Text = "";
            txtTc.Text = "";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation2 = adminInformation3;
            form3.label1.Text = "Hoşgeldiniz Sayın" + " " + adminInformation3.nameSurname;
            form3.Show();
            this.Close();
        }
    }

}


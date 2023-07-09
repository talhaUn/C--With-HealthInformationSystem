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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        public EmployeeInformation employeeInformation4 { get; set; }
        DateTime dateTime = DateTime.Now.Date;

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(1000, 9999);
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into patientInformation(nameSurname,tcNo,telNo,dateOfBirth,eMail,gender,password,address,hospitalName,dateOfRegistration,secretaryName) values(@nameSurname,@tcNo,@telNo,@dateOfBirth,@eMail,@gender,@password,@address,@hospitalName,@dateOfRegistration,@secretaryName)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@nameSurname",txtAd.Text);
                komut.Parameters.AddWithValue("@tcNo",mskdtxtTc.Text);
                komut.Parameters.AddWithValue("@telNo",mskdtxtTel.Text);
                komut.Parameters.AddWithValue("@dateOfBirth",dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@eMail",txtMail.Text);
                if(radioButton1.Checked == true)
                {
                    komut.Parameters.AddWithValue("@gender","Erkek");
                }
                if (radioButton2.Checked == true)
                {
                    komut.Parameters.AddWithValue("@gender","Kadın");
                }
                komut.Parameters.AddWithValue("@password",rnd.ToString());
                komut.Parameters.AddWithValue("@address",richTextBox1.Text);
                komut.Parameters.AddWithValue("@hospitalName",employeeInformation4.hospitalName);
                komut.Parameters.AddWithValue("@dateOfRegistration", dateTime.ToString().TrimEnd('0', ':'));
                komut.Parameters.AddWithValue("@secretaryName",employeeInformation4.nameSurname);

                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Başarıyla Kayıt Olundu!" + " " + "Hasta Randevu Giriş Şifresi =" + rnd + "'dir.");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            textBox3.Text = employeeInformation4.nameSurname;
            textBox4.Text = employeeInformation4.hospitalName;
            textBox5.Text = dateTime.ToString().TrimEnd('0', ':');
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.employeeInformation2 = employeeInformation4;
            form9.Show();
            form9.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation4.nameSurname;
            this.Close();
        }
    }
}


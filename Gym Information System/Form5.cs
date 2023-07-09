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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public adminInformation adminInformation5 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");


        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into gymEmployee(nameSurname,telNo,eMail,address,tcNo,date,companyid) values(@nameSurname,@telNo,@eMail,@address,@tcNo,@date,@companyid)";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@nameSurname", txtAd.text);
                komut.Parameters.AddWithValue("@telNo", txtTel.text);
                komut.Parameters.AddWithValue("@eMail", txtmail.text);
                komut.Parameters.AddWithValue("@tcNo", txtTc.text);
                komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                komut.Parameters.AddWithValue("@address", richTextBox1.Text);
                komut.Parameters.AddWithValue("@companyid", adminInformation5.companyid);
                komut.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Personel Kayıt Edildi","Kayıt Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation3 = adminInformation5;
            form3.bunifuMaterialTextbox1.Text = adminInformation5.nameSurname;
            form3.bunifuMaterialTextbox2.Text = adminInformation5.companyName;
            form3.Show();
            this.Close();
        }
    }
}

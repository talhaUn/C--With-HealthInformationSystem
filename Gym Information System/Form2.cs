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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        SqlDataReader dr;
        int id;



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into companyInformation(companyName,adminTc) values(@companyName,@adminTc)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@companyName", txtIsletme.Text);
                komut.Parameters.AddWithValue("@adminTc", txtTc.Text);
                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Şirket Sisteme Eklendi","Şirket Bilgisi", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }

            connect.Open();
            SqlCommand cmd = new SqlCommand("Select * from companyInformation where adminTc='" + txtTc.Text + "'", connect);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = Convert.ToInt32(dr["id"]);
            }
            else
            {

            }
            connect.Close();

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into gymAdmin(nameSurname,tcNo,telNo,eMail,address,companyName,companyid,password) values(@nameSurname,@tcNo,@telNo,@eMail,@address,@companyName,@companyid,@password)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@companyName", txtIsletme.Text);
                komut.Parameters.AddWithValue("@nameSurname", txtAd.Text);
                komut.Parameters.AddWithValue("@tcNo", txtTc.Text);
                komut.Parameters.AddWithValue("@telNo", txtTel.Text);
                komut.Parameters.AddWithValue("@eMail", txtMail.Text);
                komut.Parameters.AddWithValue("@address", richTextBox1.Text);
                komut.Parameters.AddWithValue("@companyid", id);
                komut.Parameters.AddWithValue("@password", txtsifre.Text);
                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Kayıt Olundu","Kayıt Bilgisi", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

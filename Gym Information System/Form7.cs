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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public adminInformation adminInformation7 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into productInformation(productName,stock,date,companyid,money) values(@productName,@stock,@date,@companyid,@money)";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@productName", txtUrun.Text);
                komut.Parameters.AddWithValue("@stock", txtStok.Text);
                komut.Parameters.AddWithValue("@companyid", adminInformation7.companyid);
                komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                komut.Parameters.AddWithValue("@money", Convert.ToDecimal(txtFiyat.Text));
                komut.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Ürün Eklendi","Ürün Ekleme", MessageBoxButtons.OK,MessageBoxIcon.Information);

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
            Form6 form6 = new Form6();
            form6.adminInformation6 = adminInformation7;
            form6.Show();
            this.Close();
        }
    }
    
}

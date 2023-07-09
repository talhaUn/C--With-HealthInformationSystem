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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        public adminInformation adminInformation17 { get; set; }

        private void Form17_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From policlinic where hospitalid ='" + adminInformation17.hospitalid + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "policlinic");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into policlinic(hospitalid,policlinicName) values(@hospitalid,@policlinicName)";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@hospitalid", adminInformation17.hospitalid);
                komut.Parameters.AddWithValue("@policlinicName", textBox1.Text);

                komut.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Poliklinik Eklendi.");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }

            SqlDataAdapter da = new SqlDataAdapter("Select * From policlinic where hospitalid ='" + adminInformation17.hospitalid + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "policlinic");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation2 = adminInformation17;
            form3.label1.Text = "Hoşgeldiniz Sayın" + " " + adminInformation17.nameSurname;
            form3.Show();
            this.Close();
        }
    }
}

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
    public partial class Form5 : Form
    {
        public adminInformation adminInformation4 { get; set; }

        SqlDataReader dr;
        SqlCommand com;
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");

        DataTable Yenile()
        {
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From employeeInformation where hospitalName ='" + adminInformation4.hospitalName + "'", con);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            con.Close();
            return tablo;

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From employeeInformation where hospitalName ='" + adminInformation4.hospitalName + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }


        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From employeeInformation where tcNo ='" + textBox1.Text +"'AND hospitalName ='" + adminInformation4.hospitalName + "'" ,con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("delete from employeeInformation where id='" + dataGridView1.SelectedRows[i].Cells["id"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                con.Close();
            }
            dataGridView1.DataSource = Yenile();
            MessageBox.Show("Personel Silindi.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation2 = adminInformation4;
            form3.label1.Text = "Hoşgeldiniz Sayın" + " " + adminInformation4.nameSurname;
            form3.Show();
            this.Close();
        }
    }
}

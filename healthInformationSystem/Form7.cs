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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public adminInformation adminInformation7 { get; set; }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * From employeeInformation where hospitalName ='" + adminInformation7.hospitalName + "'", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From employeeInformation where tcNo ='" + textBox1.Text + "'AND hospitalName ='" + adminInformation7.hospitalName + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

            if(textBox1.Text == "")
            {
                con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
                con.Open();
                da = new SqlDataAdapter("Select * From employeeInformation where hospitalName ='" + adminInformation7.hospitalName + "'", con);
                cmdb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "employeeInformation");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.Update(ds, "employeeInformation");
            MessageBox.Show("Kayıt güncellendi");

            con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * From employeeInformation where hospitalName ='" + adminInformation7.hospitalName + "'", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation2 = adminInformation7;
            form3.label1.Text = "Hoşgeldiniz Sayın" + " " + adminInformation7.nameSurname;
            form3.Show();
            this.Close();
        }
    }
}

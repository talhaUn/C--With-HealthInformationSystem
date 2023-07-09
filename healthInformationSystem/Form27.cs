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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation27 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataReader dr;

        private void Form27_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit(); 
        }

        private void Form27_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select id,patientName AS 'Hasta Adı', employeeid AS 'Doktor ID No', employeeName AS 'Doktorun Adı',reasonForComplaint AS 'Şikayet Nedeni', date AS 'Tarih', reading AS 'Durum' From complaint where employeeid ='" + employeeInformation27.id + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int message = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            richTextBox1.Visible = true;

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("Select*from complaint where id='" + dataGridView1.SelectedRows[i].Cells["id"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    textBox1.Text = ((dr["patientName"].ToString()));
                    textBox2.Text = (dr["date"]).ToString();
                    richTextBox1.Text = dr["reasonForComplaint"].ToString();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
                con.Close();
            }


            try
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();

                var kayit = "UPDATE complaint Set reading=@reading WHERE  id=" + dataGridView1.SelectedRows[i].Cells["id"].Value.ToString();
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@reading", "Okundu");
                komut.ExecuteNonQuery();
                con.Close();
                }
         
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("Select count (*) from complaint where employeeid='" + employeeInformation27.id + "' And reading='" + "Okunmamış" + "'", con);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                message = Convert.ToInt32(dr[0]);
            }
            else
            {
                MessageBox.Show("Hata var.");
            }
            con.Close();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                var kayit = "UPDATE complaintNotification Set complaintNotification=@complaintNotification WHERE  employeeid=" + employeeInformation27.id;
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@complaintNotification", message);
                komut.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }

            SqlDataAdapter da = new SqlDataAdapter("Select id,patientName AS 'Hasta Adı', employeeid AS 'Doktor ID No', employeeName AS 'Doktorun Adı',reasonForComplaint AS 'Şikayet Nedeni', date AS 'Tarih', reading AS 'Durum' From complaint where employeeid ='" + employeeInformation27.id + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.employeeInformation3 = employeeInformation27;
            form10.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation27.nameSurname;
            form10.Show();
            this.Close();
        }
    }
}

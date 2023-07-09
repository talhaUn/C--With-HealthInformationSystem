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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }
        public adminInformation adminInformation30 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataReader dr;

        private void Form30_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select id,patientName AS 'Hasta Adı', employeeid AS 'Doktor ID No', employeeName AS 'Doktorun Adı',hospitalid AS 'Hastane ID No',reasonForComplaint AS 'Şikayet Nedeni', date AS 'Tarih', reading AS 'Durum' From complaint where hospitalid ='" + adminInformation30.hospitalid + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        int message = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            richTextBox1.Visible = true;
            pictureBox2.Visible = true;

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
                    textBox4.Text = (dr["employeeName"]).ToString();
                    textBox3.Text = (dr["policlinicName"]).ToString();
                    richTextBox1.Text = dr["reasonForComplaint"].ToString();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("delete from complaint where id='" + dataGridView1.SelectedRows[i].Cells["id"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                con.Close();
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("Select count (*) from complaint where employeeid='" + adminInformation30.hospitalid + "'", con);
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

                var kayit = "UPDATE complaintNotification Set complaintNotification=@complaintNotification WHERE  hospitalid=" + adminInformation30.hospitalid;
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@complaintNotification", message);
                komut.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }

            SqlDataAdapter da = new SqlDataAdapter("Select id,patientName AS 'Hasta Adı', employeeid AS 'Doktor ID No', employeeName AS 'Doktorun Adı',hospitalid AS 'Hastane ID No',reasonForComplaint AS 'Şikayet Nedeni', date AS 'Tarih', reading AS 'Durum' From complaint where employeeid ='" + adminInformation30.hospitalid + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            MessageBox.Show("Şikayet Silindi");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation2 = adminInformation30;
            form3.label1.Text = "Hoşgeldiniz Sayın" + " " + adminInformation30.nameSurname;
            form3.Show();
            this.Close();
        }
    }
}

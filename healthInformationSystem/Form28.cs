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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }
        public patientInformation patientInformation28 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataReader dr;

        private void Form28_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select id,patientName AS 'Hasta Adı',patientTc AS 'Hasta T.C No:', employeeid AS 'Doktor ID No', employeeName AS 'Doktorun Adı',conformity AS 'Spora Uygunluk', date AS 'Tarih', eligibilityDetail AS 'Kısmi Uygunluk',diagnosis AS 'Teşhis' From diagnosis where patientid ='" + patientInformation28.id + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("Select*from diagnosis where id='" + dataGridView1.SelectedRows[i].Cells["id"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    textBox1.Text = ((dr["employeeName"].ToString()));
                    textBox2.Text = (dr["hospitalName"]).ToString();
                    textBox3.Text = (dr["policlinicName"]).ToString();
                    textBox4.Text = (dr["date"]).ToString();
                    textBox5.Text = (dr["conformity"]).ToString();
                    richTextBox2.Text = dr["eligibilityDetail"].ToString();
                    richTextBox1.Text = dr["diagnosis"].ToString();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
                con.Close();
            }
        }

        private void Form28_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.patientInformation1 = patientInformation28;
            form15.label1.Text = "Hoşgeldiniz Sayın" + " " + patientInformation28.nameSurname;
            form15.Show();
            this.Close();
        }
    }
}

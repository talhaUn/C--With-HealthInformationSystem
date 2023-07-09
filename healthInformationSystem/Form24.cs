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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }
        public patientInformation patientInformation24 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataReader dr;

        private void Form24_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select id, patientTc AS 'Hasta T.C No:', patientName AS 'Hasta Adı', city AS 'Şehir', district AS 'İlçe', hospitalName AS 'Hastane Adı', employeeid AS 'Doktor ID', employeeName AS 'Doktor Adı', date AS 'Tarih' From appointmentHistory where patientid ='" + patientInformation24.id + "'", con);
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
                SqlCommand komut = new SqlCommand("Select * from employeeInformation where id='" + dataGridView1.SelectedRows[i].Cells["Doktor ID"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    complaint complaint = new complaint();
                    Form25 form25 = new Form25();
                    form25.patientInformation25 = patientInformation24;
                    form25.textBox1.Text = dr["nameSurname"].ToString();
                    complaint.employeeName = dr["nameSurname"].ToString();
                    form25.textBox2.Text = dr["hospitalName"].ToString();
                    complaint.hospitalName = dr["hospitalName"].ToString();
                    form25.textBox3.Text = dr["department"].ToString();
                    complaint.policlinicName = dr["department"].ToString();
                    complaint.employeeid = Convert.ToInt32(dr["id"]);
                    complaint.hospitalid = Convert.ToInt32(dr["hospitalid"]);
                    complaint.policlinicid = Convert.ToInt32(dr["policlinicid"]);
                    form25.complaint25 = complaint;
                    form25.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("Select * from employeeInformation where id='" + dataGridView1.SelectedRows[i].Cells["Doktor ID"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    complaint complaint = new complaint();
                    Form26 form26 = new Form26();
                    form26.patientInformation26 = patientInformation24;
                    form26.textBox1.Text = dr["nameSurname"].ToString();
                    complaint.employeeName = dr["nameSurname"].ToString();
                    form26.textBox2.Text = dr["hospitalName"].ToString();
                    complaint.hospitalName = dr["hospitalName"].ToString();
                    form26.textBox3.Text = dr["department"].ToString();
                    complaint.policlinicName = dr["department"].ToString();
                    complaint.employeeid = Convert.ToInt32(dr["id"]);
                    complaint.hospitalid = Convert.ToInt32(dr["hospitalid"]);
                    complaint.policlinicid = Convert.ToInt32(dr["policlinicid"]);
                    form26.complaint26 = complaint;
                    form26.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.patientInformation1 = patientInformation24;
            form15.label1.Text = "Hoşgeldiniz Sayın" + " " + patientInformation24.nameSurname;
            form15.Show();
            this.Close();
        }
    }
}

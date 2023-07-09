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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation20 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataReader dr;

        private void Form20_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select id,patientTc,patientName,date,time From patientAppointment where employeeid ='" + employeeInformation20.id + "'And date='" + DateTime.Now.ToLongDateString() + "'", con);
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
                SqlCommand komut = new SqlCommand("Select * from patientAppointment where id='" + dataGridView1.SelectedRows[i].Cells["id"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    appointment appointment1 = new appointment();
                    Form21 form21 = new Form21();                    
                    form21.employeeInformation21 = employeeInformation20;
                    form21.label1.Text = dr["patientid"].ToString();
                    appointment1.patientid = Convert.ToInt32(dr["patientid"]);
                    form21.label2.Text = dr["patientTc"].ToString();
                    appointment1.patientTc = dr["patientTc"].ToString();
                    appointment1.patientName = dr["patientName"].ToString();
                    form21.label3.Text = dr["patientName"].ToString();
                    appointment1.city = dr["city"].ToString();
                    appointment1.district = dr["district"].ToString();
                    form21.label4.Text = "Randevu Tarihi:" + " " + dr["date"].ToString();
                    form21.label5.Text = "Randevu Saati:" + " " + dr["time"].ToString();
                    appointment1.appointmentid = Convert.ToInt32(dr["id"]);
                    form21.appointment21 = appointment1;
                    form21.Show();
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
            Form10 form10 = new Form10();
            form10.employeeInformation3 = employeeInformation20;
            form10.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation20.nameSurname;
            form10.Show();
            this.Close();
        }
    }
}

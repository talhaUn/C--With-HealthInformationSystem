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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        public patientInformation patientInformation3 { get; set; }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthInformationSystemDataSet.employeeInformation' table. You can move, or remove it, as needed.
            this.employeeInformationTableAdapter.Fill(this.healthInformationSystemDataSet.employeeInformation);
            // TODO: This line of code loads data into the 'healthInformationSystemDataSet.policlinic' table. You can move, or remove it, as needed.
            this.policlinicTableAdapter.Fill(this.healthInformationSystemDataSet.policlinic);
            // TODO: This line of code loads data into the 'healthInformationSystemDataSet.hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter.Fill(this.healthInformationSystemDataSet.hospital);
            // TODO: This line of code loads data into the 'healthInformationSystemDataSet.district' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.healthInformationSystemDataSet.district);
            // TODO: This line of code loads data into the 'healthInformationSystemDataSet.city' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.healthInformationSystemDataSet.city);
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(15);
            dateTimePicker1.MinDate = DateTime.Now;

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox6.DisplayMember = "time";
            comboBox6.ValueMember = "id";
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into patientAppointment(patientid,patientTc,patientName,city,district,hospitalName,employeeid,employeeName,department,date,timeid,time,policlinicid) values(@patientid,@patientTc,@patientName,@city,@district,@hospitalName,@employeeid,@employeeName,@department,@date,@timeid,@time,@policlinicid)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@patientid", patientInformation3.id);
                komut.Parameters.AddWithValue("@patientTc", patientInformation3.tcNo);
                komut.Parameters.AddWithValue("@patientName", patientInformation3.nameSurname);
                komut.Parameters.AddWithValue("@city", comboBox1.Text);
                komut.Parameters.AddWithValue("@district", comboBox2.Text);
                komut.Parameters.AddWithValue("@hospitalName", comboBox3.Text);
                komut.Parameters.AddWithValue("@employeeid", comboBox5.SelectedValue);
                komut.Parameters.AddWithValue("@employeeName", comboBox5.Text);
                komut.Parameters.AddWithValue("@department", comboBox4.Text);
                komut.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@timeid", comboBox6.SelectedValue);
                komut.Parameters.AddWithValue("@time", comboBox6.Text); 
                komut.Parameters.AddWithValue("@policlinicid", comboBox4.SelectedValue); 

                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Randevunuz Başarıyla Alınmıştır.", "Randevu Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                comboBox6.DataSource = null;
                SqlCommand cmd = new SqlCommand("SELECT * FROM time WHERE id NOT IN (SELECT timeid FROM patientAppointment WHERE policlinicid ='" + comboBox4.SelectedValue + "'And employeeid ='" + comboBox5.SelectedValue + "'And date = '" + dateTimePicker1.Text + "')", connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox6.DisplayMember = "time";
                comboBox6.ValueMember = "id";
                comboBox6.DataSource = dt;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void Form16_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.DataSource = null;
            SqlCommand komut = new SqlCommand("SELECT * FROM time WHERE id NOT IN (SELECT timeid FROM patientAppointment WHERE policlinicid ='" + comboBox4.SelectedValue + "'And employeeid ='" + comboBox5.SelectedValue + "'And date = '" + dateTimePicker1.Text + "')", connect);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox6.DisplayMember = "time";
            comboBox6.ValueMember = "id";
            comboBox6.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox6.DataSource = null;
            SqlCommand komut = new SqlCommand("SELECT * FROM time WHERE id NOT IN (SELECT timeid FROM patientAppointment WHERE policlinicid ='" + comboBox4.SelectedValue + "'And employeeid ='" + comboBox5.SelectedValue + "'And date = '" + dateTimePicker1.Text + "')", connect);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox6.DisplayMember = "time";
            comboBox6.ValueMember = "id";
            comboBox6.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.patientInformation1 = patientInformation3;
            form15.label1.Text = "Hoşgeldiniz Sayın" + " " + patientInformation3.nameSurname;
            form15.Show();
            this.Close();
        }
    }
}

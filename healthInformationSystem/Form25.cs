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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }
        public patientInformation patientInformation25 { get; set; }
        public complaint complaint25 { get; set; }
        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void Form25_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into complaint(patientid,patientName,employeeid,employeeName,hospitalid,hospitalName,policlinicid,policlinicName,reasonForComplaint,date,reading) values(@patientid,@patientName,@employeeid,@employeeName,@hospitalid,@hospitalName,@policlinicid,@policlinicName,@reasonForComplaint,@date,@reading)";
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@patientid", patientInformation25.id);
                komut.Parameters.AddWithValue("@patientName", patientInformation25.nameSurname);
                komut.Parameters.AddWithValue("@employeeid", complaint25.employeeid);
                komut.Parameters.AddWithValue("@employeeName", complaint25.employeeName);
                komut.Parameters.AddWithValue("@hospitalid", complaint25.hospitalid);
                komut.Parameters.AddWithValue("@hospitalName", complaint25.hospitalName);
                komut.Parameters.AddWithValue("@policlinicid", complaint25.policlinicid);
                komut.Parameters.AddWithValue("@policlinicName", complaint25.policlinicName);
                komut.Parameters.AddWithValue("@reasonForComplaint", richTextBox1.Text);
                komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                komut.Parameters.AddWithValue("@reading", "Okunmamış");
                komut.ExecuteNonQuery();
                MessageBox.Show("Şikayetiniz Alınmıştır.");
                connect.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.patientInformation24 = patientInformation25;
            form24.Show();
            this.Close();
        }
    }
}

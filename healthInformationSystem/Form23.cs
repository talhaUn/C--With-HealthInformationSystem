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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }
        public patientInformation patientInformation23 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");

        private void Form23_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select id, prescription AS 'İlaç Adı', patientName AS 'Hasta Adı', employeeName AS 'Doktor Adı', hospitalName AS 'Hastane Adı', policlinicName AS 'Poliklinik Adı', date AS 'Tarih', lengthOfStay AS 'Yatış Süresi' From prescription where patientid ='" + patientInformation23.id + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "employeeInformation");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Form23_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.patientInformation1 = patientInformation23;
            form15.label1.Text = "Hoşgeldiniz Sayın" + " " + patientInformation23.nameSurname;
            form15.Show();
            this.Close();
        }
    }
}

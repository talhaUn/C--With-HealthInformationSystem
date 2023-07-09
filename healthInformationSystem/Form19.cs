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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation19 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");

        DataTable Yenile()
        {
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From workingHourInformation where tcNo ='" + employeeInformation19.tcNo + "'", con);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            con.Close();
            return tablo;

        }


        private void btnMesaiBaslat_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into workingHourInformation(nameSurname,tcNo,title,department,hospitalName,date,startTime) values(@nameSurname,@tcNo,@title,@department,@hospitalName,@date,@startTime)";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@nameSurname", employeeInformation19.nameSurname);
                komut.Parameters.AddWithValue("@tcNo", employeeInformation19.tcNo);
                komut.Parameters.AddWithValue("@title", employeeInformation19.title);
                komut.Parameters.AddWithValue("@department", employeeInformation19.department);
                komut.Parameters.AddWithValue("@hospitalName", employeeInformation19.hospitalName);
                komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                komut.Parameters.AddWithValue("@startTime", DateTime.Now.ToLongTimeString());

                komut.ExecuteNonQuery();

                con.Close();
                dataGridView1.DataSource = Yenile();
                MessageBox.Show("Mesainiz Başlatılmıştır.", "Mesai Bilgisi!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Yenile();
        }

        private void btnMesaiBitir_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    var kayit = "UPDATE workingHourInformation Set finishTime=@finishTime  WHERE  id=" + dataGridView1.SelectedRows[i].Cells["id"].Value.ToString();
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.Parameters.AddWithValue("@finishTime", DateTime.Now.ToLongTimeString());
                    komut.ExecuteNonQuery();
                    con.Close();
                }
                dataGridView1.DataSource = Yenile();
                MessageBox.Show("Mesainiz Bitmiştir.", "Mesai Bilgisi!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.employeeInformation3 = employeeInformation19;
            form10.Show();
            form10.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation19.nameSurname;
            this.Hide();
        }
    }
}

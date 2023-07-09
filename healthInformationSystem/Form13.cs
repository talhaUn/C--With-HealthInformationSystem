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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation13 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");

        DataTable Yenile()
        {
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From workingHourInformation where tcNo ='" + employeeInformation13.tcNo + "'", con);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            con.Close();
            return tablo;

        }

        private void Form13_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }


        private void Form13_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Yenile();
        }

        private void btnMesaiBaslat_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into workingHourInformation(nameSurname,tcNo,title,department,hospitalName,date,startTime) values(@nameSurname,@tcNo,@title,@department,@hospitalName,@date,@startTime)";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@nameSurname", employeeInformation13.nameSurname);
                komut.Parameters.AddWithValue("@tcNo", employeeInformation13.tcNo);
                komut.Parameters.AddWithValue("@title", employeeInformation13.title);
                komut.Parameters.AddWithValue("@department", employeeInformation13.department);
                komut.Parameters.AddWithValue("@hospitalName", employeeInformation13.hospitalName);
                komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                komut.Parameters.AddWithValue("@startTime", DateTime.Now.ToLongTimeString());

                komut.ExecuteNonQuery();

                con.Close();
                dataGridView1.DataSource = Yenile();
                MessageBox.Show("Mesainiz Başlatılmıştır.","Mesai Bilgisi!",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }         
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
                dataGridView1.DataSource=Yenile();
                MessageBox.Show("Mesainiz Bitmiştir.","Mesai Bilgisi!",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.employeeInformation2 = employeeInformation13;
            form9.Show();
            form9.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation13.nameSurname;
            this.Close();
        }
    }
}

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
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation31 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataReader dr;

        private void Form31_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
        int points = 0;
        private void Form31_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select id,patientName AS 'Yorumu Yapan',employeeid AS 'Doktor ID No:', employeeName AS 'Doktorun Adı',hospitalName AS 'Hastane Adı',policlinicName AS 'Poliklinik Adı',points AS 'Puanı',comment AS 'Yorum', date AS 'Tarih' From comment where employeeid ='" + employeeInformation31.id + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "comment");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();


            int sumPoints = 0;
            
            
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Sum(points) from comment where employeeid='" + employeeInformation31.id + "'", con);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sumPoints = Convert.ToInt32(dr[0]);
                }
                else
                {
                    MessageBox.Show("Hata var.");
                }
                con.Close();
            

            int count = 0;
            int avgPoint = 0;

                con.Open();
                SqlCommand komut = new SqlCommand("Select count(*) from comment where employeeid='" + employeeInformation31.id + "'", con);
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    count = Convert.ToInt32(dr[0]);
                    avgPoint = sumPoints / count;

                    if (avgPoint == 1)
                    {
                        label7.ForeColor = Color.Yellow;
                        label20.ForeColor = Color.Black;
                        label21.ForeColor = Color.Black;
                        label22.ForeColor = Color.Black;
                        label23.ForeColor = Color.Black;
                    }
                    if (avgPoint == 2)
                    {
                        label7.ForeColor = Color.Yellow;
                        label20.ForeColor = Color.Yellow;
                        label21.ForeColor = Color.Black;
                        label22.ForeColor = Color.Black;
                        label23.ForeColor = Color.Black;
                    }
                    if (avgPoint == 3)
                    {
                        label7.ForeColor = Color.Yellow;
                        label20.ForeColor = Color.Yellow;
                        label21.ForeColor = Color.Yellow;
                        label22.ForeColor = Color.Black;
                        label23.ForeColor = Color.Black;
                    }
                    if (avgPoint == 4)
                    {
                        label7.ForeColor = Color.Yellow;
                        label20.ForeColor = Color.Yellow;
                        label21.ForeColor = Color.Yellow;
                        label22.ForeColor = Color.Yellow;
                        label23.ForeColor = Color.Black;
                    }
                    if (avgPoint == 5)
                    {
                        label7.ForeColor = Color.Yellow;
                        label20.ForeColor = Color.Yellow;
                        label21.ForeColor = Color.Yellow;
                        label22.ForeColor = Color.Yellow;
                        label23.ForeColor = Color.Yellow;
                    }
                }
                else
                {
                    MessageBox.Show("Hata var.");
                }
                con.Close();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            label1.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            richTextBox1.Visible = true;

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("Select * from comment where id='" + dataGridView1.SelectedRows[i].Cells["id"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    points = Convert.ToInt32(dr["points"]);
                    textBox6.Text = ((dr["patientName"].ToString()));
                    textBox7.Text = (dr["date"]).ToString();
                    richTextBox1.Text = dr["comment"].ToString();
                    if (points == 1)
                    {
                        label14.ForeColor = Color.Yellow;
                        label15.ForeColor = Color.Black;
                        label16.ForeColor = Color.Black;
                        label17.ForeColor = Color.Black;
                        label18.ForeColor = Color.Black;
                    }
                    if (points == 2)
                    {
                        label14.ForeColor = Color.Yellow;
                        label15.ForeColor = Color.Yellow;
                        label16.ForeColor = Color.Black;
                        label17.ForeColor = Color.Black;
                        label18.ForeColor = Color.Black;
                    }
                    if (points == 3)
                    {
                        label14.ForeColor = Color.Yellow;
                        label15.ForeColor = Color.Yellow;
                        label16.ForeColor = Color.Yellow;
                        label17.ForeColor = Color.Black;
                        label18.ForeColor = Color.Black;
                    }
                    if (points == 4)
                    {
                        label14.ForeColor = Color.Yellow;
                        label15.ForeColor = Color.Yellow;
                        label16.ForeColor = Color.Yellow;
                        label17.ForeColor = Color.Yellow;
                        label18.ForeColor = Color.Black;
                    }
                    if (points == 5)
                    {
                        label14.ForeColor = Color.Yellow;
                        label15.ForeColor = Color.Yellow;
                        label16.ForeColor = Color.Yellow;
                        label17.ForeColor = Color.Yellow;
                        label18.ForeColor = Color.Yellow;
                    }

                }
                else
                {
                    MessageBox.Show("Hata");
                }
                con.Close();
    }   }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.employeeInformation3 = employeeInformation31;
            form10.label1.Text = "Hoşgeldiniz Sayın" + " " + employeeInformation31.nameSurname;
            form10.Show();
            this.Close();
        }
    }   
}
    


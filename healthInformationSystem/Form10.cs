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
using System.Media;

namespace healthInformationSystem
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation3 { get; set; }
        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        SqlDataReader dr ,reader;

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
        int employee;
        private void Form10_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer2.Interval = 5000;
            timer2.Enabled = true;

            connect.Open();
            SqlCommand komut = new SqlCommand("Select * from complaintNotification where employeeid='" + employeeInformation3.id + "'", connect);
            komut.ExecuteNonQuery();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                employee = Convert.ToInt32(dr["employeeid"]);
                label4.Text = (dr["complaintNotification"]).ToString();
            }
            else
            {
                
            }
            connect.Close();
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;

            
            
            connect.Open();
            SqlCommand cmd = new SqlCommand("Select count (*) from comment where employeeid='" + employeeInformation3.id +  "'", connect);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Hata var.");
            }
            connect.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            if (label3.Text == "16:59:59")
            {
                MessageBox.Show("Mesainiz Bitmiştir. Eğer ek mesainiz varsa bu uyarıyı dikkate almayınız.", "Mesai Bitimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (label3.Text == "23:59:59")
            {
                MessageBox.Show("Mesainiz Bitmiştir. Eğer ek mesainiz varsa bu uyarıyı dikkate almayınız.", "Mesai Bitimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (label3.Text == "07:59:59")
            {
                MessageBox.Show("Mesainiz Bitmiştir. Eğer ek mesainiz varsa bu uyarıyı dikkate almayınız.", "Mesai Bitimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int message = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
            label4.Visible = false;
            MessageBox.Show("Bildirimler Kapatıldı.", "Bildirim Bilgisi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label4.Visible = true;
            MessageBox.Show("Bildirimler Açıldı.", "Bildirim Bilgisi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Yellow;
        }

        private void Form10_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(247, 241, 227);
            label8.ForeColor = Color.FromArgb(247, 241, 227);
            label9.ForeColor = Color.FromArgb(247, 241, 227);
            label10.ForeColor = Color.FromArgb(247, 241, 227);
            label11.ForeColor = Color.FromArgb(247, 241, 227);
            label12.ForeColor = Color.FromArgb(247, 241, 227);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.employeeInformation20 = employeeInformation3;
            form20.Show();
            this.Close();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Yellow;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form27 form27 = new Form27();
            form27.employeeInformation27 = employeeInformation3;
            form27.Show();
            this.Close();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Yellow;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.employeeInformation22 = employeeInformation3;
            form22.Show();
            this.Close();
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Yellow;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.employeeInformation19 = employeeInformation3;
            form19.Show();
            this.Close();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = Color.Yellow;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form31 form31 = new Form31();
            form31.employeeInformation31 = employeeInformation3;
            form31.Show();
            this.Close();
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Red;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int sayac1;
            sayac1 = Convert.ToInt32(label4.Text);
            connect.Open();
            SqlCommand cmd = new SqlCommand("Select count (*) from complaint where employeeid='" + employeeInformation3.id + "' And reading='" + "Okunmamış" + "'", connect);
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
            connect.Close();

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                var kayit = "UPDATE complaintNotification Set complaintNotification=@complaintNotification WHERE  employeeid=" + employeeInformation3.id;
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@complaintNotification", message);
                komut.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
            int sayac = 0;
            connect.Open();
            SqlCommand save = new SqlCommand("Select complaintNotification from complaintNotification where employeeid='" + employeeInformation3.id + "'", connect);
            save.ExecuteNonQuery();
            dr = save.ExecuteReader();
            if (dr.Read())
            {
                sayac = Convert.ToInt32(dr["complaintNotification"]);
                if(sayac1 < sayac)
                {
                    label4.Text = sayac.ToString();
                    SoundPlayer sound = new SoundPlayer();
                    sound.SoundLocation = @"C:\Users\Talha\source\repos\healthInformationSystem\Resources\sound.wav";
                    sound.Play();
                }
            }
            else
            {

            }
            connect.Close();
            if(sayac1 < sayac)
            {
                MessageBox.Show("Bir adet bildiriminiz var", "Bildirim Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connect.Open();
            SqlCommand comment = new SqlCommand("Select count (*) from comment where employeeid='" + employeeInformation3.id + "'", connect);
            comment.ExecuteNonQuery();
            dr = comment.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Hata var.");
            }
            connect.Close();

        }


    }
}

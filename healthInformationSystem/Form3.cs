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
    public partial class Form3 : Form
    {
        public adminInformation adminInformation2 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataReader dr;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        int hospital;
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Enabled = true;

            con.Open();
            SqlCommand komut = new SqlCommand("Select * from complaintNotification where hospitalid='" + adminInformation2.hospitalid + "'", con);
            komut.ExecuteNonQuery();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                hospital = Convert.ToInt32(dr["hospitalid"]);
                label4.Text = (dr["complaintNotification"]).ToString();
            }
            else
            {

            }
            con.Close();
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;

            con.Open();
            SqlCommand appointment = new SqlCommand("Select count (*) from patientAppointment where hospitalName='" + adminInformation2.hospitalName + "' AND date = '" + DateTime.Now.ToLongDateString() + "'", con);
            appointment.ExecuteNonQuery();
            dr = appointment.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Hata var.");
            }
            con.Close();

            con.Open();
            SqlCommand complaint = new SqlCommand("Select count (*) from complaint where hospitalid='" + adminInformation2.hospitalid + "'", con);
            complaint.ExecuteNonQuery();
            dr = complaint.ExecuteReader();
            if (dr.Read())
            {
                label6.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Hata var.");
            }
            con.Close();

            con.Open();
            SqlCommand employee = new SqlCommand("Select count (*) from employeeInformation where hospitalid='" + adminInformation2.hospitalid + "'", con);
            employee.ExecuteNonQuery();
            dr = employee.ExecuteReader();
            if (dr.Read())
            {
                label8.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Hata var.");
            }
            con.Close();
        }

        int message = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayac1;
            sayac1 = Convert.ToInt32(label4.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count (*) from complaint where hospitalid='" + adminInformation2.hospitalid +  "'", con);
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
            con.Close();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                var kayit = "UPDATE complaintNotification Set complaintNotification=@complaintNotification WHERE  hospitalid=" + adminInformation2.hospitalid;
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@complaintNotification", message);
                komut.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
            int sayac = 0;
            con.Open();
            SqlCommand save = new SqlCommand("Select complaintNotification from complaintNotification where hospitalid='" + adminInformation2.hospitalid + "'", con);
            save.ExecuteNonQuery();
            dr = save.ExecuteReader();
            if (dr.Read())
            {
                sayac = Convert.ToInt32(dr["complaintNotification"]);
                if (sayac1 < sayac)
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
            con.Close();
            if (sayac1 < sayac)
            {
                MessageBox.Show("Bir adet bildiriminiz var", "Bildirim Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            con.Open();
            SqlCommand appointment = new SqlCommand("Select count (*) from patientAppointment where hospitalName='" + adminInformation2.hospitalName + "' AND date = '" + DateTime.Now.ToLongDateString() + "'", con);
            appointment.ExecuteNonQuery();
            dr = appointment.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Hata var.");
            }
            con.Close();

            con.Open();
            SqlCommand complaint = new SqlCommand("Select count (*) from complaint where hospitalid='" + adminInformation2.hospitalid + "'", con);
            complaint.ExecuteNonQuery();
            dr = complaint.ExecuteReader();
            if (dr.Read())
            {
                label6.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Hata var.");
            }
            con.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
            label4.Visible = false;
            MessageBox.Show("Bildirimler Kapatıldı.", "Bildirim Bilgisi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label4.Visible = true;
            MessageBox.Show("Bildirimler Açıldı.", "Bildirim Bilgisi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Lime;
        }

        private void Form3_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.adminInformation3 = adminInformation2;
            form4.Show();
            //MessageBox.Show("Hasta Kayıt Bölümündesiniz");
            this.Close();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Lime;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30();
            form30.adminInformation30 = adminInformation2;
            form30.Show();
            this.Close();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = Color.Lime;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.adminInformation4 = adminInformation2;
            form5.Show();
            this.Close();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Lime;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.adminInformation6 = adminInformation2;
            form6.Show();
            this.Close();
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Lime;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.adminInformation17 = adminInformation2;
            form17.Show();
            this.Close();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Lime;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.adminInformation7 = adminInformation2;
            form7.Show();
            this.Close();
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Red;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


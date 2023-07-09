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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        public patientInformation patientInformation26 { get; set; }
        public complaint complaint26 { get; set; }
        bool color = false;
        bool color1 = false;

        public void label1_MouseEnter(object sender, EventArgs e)
        {
            if (color1 == false)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
        }

        public void Form26_MouseEnter(object sender, EventArgs e)
        {
            
            if (color == false)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            if (color1 == false)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            if (color1 == false)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            if (color1 == false)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Yellow;
                label5.ForeColor = Color.Black;
            }
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            if (color1 == false)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Yellow;
                label5.ForeColor = Color.Yellow;
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            color = true;
            color1 = true;
            if(color == true && color1 == true)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            color = true;
            color1 = true;
            if (color == true && color1 == true)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            color = true;
            color1 = true;
            if (color == true && color1 == true)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            color = true;
            color1 = true;
            if (color == true && color1 == true)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Yellow;
                label5.ForeColor = Color.Black;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            color = true;
            color1 = true;
            if (color == true && color1 == true)
            {
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Yellow;
                label5.ForeColor = Color.Yellow;
            }
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Gönderdiğiniz Yorumlarda Hakaret İçeren Kelimeler Olmasın. Aksi Takdirde Karşı Karşıya Kalabileceğiniz Hukuki Süreçler Olabilir.", "Yorum Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;

            if(label5.ForeColor == Color.Yellow)
            {
                points = 5;
            }
            if(label4.ForeColor == Color.Yellow && label5.ForeColor == Color.Black)
            {
                points = 4;
            }
            if(label3.ForeColor == Color.Yellow && label4.ForeColor == Color.Black)
            {
                points = 3;
            }
            if(label2.ForeColor == Color.Yellow && label3.ForeColor == Color.Black)
            {
                points = 2;
            }
            if (label1.ForeColor == Color.Yellow && label2.ForeColor == Color.Black)
            {
                points=1;
            }
            if(points == 0)
            {
                MessageBox.Show("Lütfen Yorum Yaptığınız Doktoru Puanlandırınız", "Puanlandırma Bilgisi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if(points != 0)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    string kayit = "insert into comment(patientid,patientName,employeeid,employeeName,hospitalid,hospitalName,policlinicid,policlinicName,points,comment,date) values(@patientid,@patientName,@employeeid,@employeeName,@hospitalid,@hospitalName,@policlinicid,@policlinicName,@points,@comment,@date)";
                    SqlCommand komut = new SqlCommand(kayit, connect);
                    komut.Parameters.AddWithValue("@patientid", patientInformation26.id);
                    komut.Parameters.AddWithValue("@patientName", patientInformation26.nameSurname);
                    komut.Parameters.AddWithValue("@employeeid", complaint26.employeeid);
                    komut.Parameters.AddWithValue("@employeeName", complaint26.employeeName);
                    komut.Parameters.AddWithValue("@hospitalid", complaint26.hospitalid);
                    komut.Parameters.AddWithValue("@hospitalName", complaint26.hospitalName);
                    komut.Parameters.AddWithValue("@policlinicid", complaint26.policlinicid);
                    komut.Parameters.AddWithValue("@policlinicName", complaint26.policlinicName);
                    komut.Parameters.AddWithValue("@points", points);
                    komut.Parameters.AddWithValue("@comment", richTextBox1.Text);
                    komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yorumunuz Gönderildi.", "Yorum Yapıldı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu!" + hata.Message);
                }
            }
        }

        private void Form26_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.patientInformation24 = patientInformation26;
            form24.Show();
            this.Close();
        }
    }
}

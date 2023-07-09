using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Information_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public adminInformation adminInformation3 { get; set; }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.adminInformation5 = adminInformation3;
            form5.Show();
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(24, 220, 255);
        }

        private void Form3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.adminInformation10 = adminInformation3;
            form10.Show();
            this.Close();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(24, 220, 255);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.adminInformation4 = adminInformation3;
            form4.Show();
            this.Close();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(24, 220, 255);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.adminInformation9 = adminInformation3;
            form9.Show();
            this.Close();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(24, 220, 255);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.adminInformation6 = adminInformation3;
            form6.Show();
            this.Close();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(24, 220, 255);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

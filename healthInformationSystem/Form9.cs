using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace healthInformationSystem
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation2 { get; set; }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Yellow;
        }

        private void Form9_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.employeeInformation4 = employeeInformation2;
            form11.Show();
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Yellow;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.employeeInformation12 = employeeInformation2;
            form12.Show();
            this.Close();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Yellow;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.employeeInformation13 = employeeInformation2;
            form13.Show();
            this.Close();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

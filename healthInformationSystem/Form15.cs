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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        public patientInformation patientInformation1 { get; set; }

        private void Form15_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Yellow;
        }
       
        private void Form15_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            this.BackColor = Color.FromArgb(29, 209, 161);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.patientInformation5 = patientInformation1;
            form18.Show();
            this.Close();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Yellow;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23();
            form23.patientInformation23 = patientInformation1;
            form23.Show();
            this.Close();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Yellow;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form29 form29 = new Form29();
            form29.patientInformation29 = patientInformation1;
            form29.Show();
            this.Close();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Yellow;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.patientInformation3 = patientInformation1;
            form16.Show();
            this.Close();
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Yellow;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form28 form28 = new Form28();
            form28.patientInformation28 = patientInformation1;
            form28.Show();
            this.Close();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Yellow;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.patientInformation24 = patientInformation1;
            form24.Show();
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}

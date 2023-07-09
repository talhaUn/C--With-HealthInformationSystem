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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public adminInformation adminInformation6 { get; set; }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LimeGreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.adminInformation7 = adminInformation6;
            form7.Show();
            this.Close();
        }

        private void bunifuGradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.LimeGreen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.adminInformation8 = adminInformation6;
            form8.Show();
            this.Close();
        }

        private void bunifuGradientPanel2_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor= Color.White;
            label2.ForeColor= Color.White;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation3 = adminInformation6;
            form3.bunifuMaterialTextbox1.Text = adminInformation6.nameSurname;
            form3.bunifuMaterialTextbox2.Text = adminInformation6.companyName;
            form3.Show();
            this.Close();
        }
    }
}

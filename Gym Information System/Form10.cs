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

namespace Gym_Information_System
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public adminInformation adminInformation10 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");

        private void Form10_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From gymEmployee where companyid ='" + adminInformation10.companyid + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "gymEmployee");
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bunifuCustomDataGrid1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("delete from gymEmployee where id='" + bunifuCustomDataGrid1.SelectedRows[i].Cells["id"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter("Select * From gymEmployee where companyid ='" + adminInformation10.companyid + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "gymEmployee");
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            con.Close();
            MessageBox.Show("Personel Silindi","Personel Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.adminInformation3 = adminInformation10;
            form3.bunifuMaterialTextbox1.Text = adminInformation10.nameSurname;
            form3.bunifuMaterialTextbox2.Text = adminInformation10.companyName;
            form3.Show();
            this.Close();
        }
    }
}


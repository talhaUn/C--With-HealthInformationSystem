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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public adminInformation adminInformation8 { get; set; }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True");
        SqlDataReader dr;

   

        private void Form8_Load(object sender, EventArgs e)
        {

            SqlDataAdapter data = new SqlDataAdapter("Select id,productName AS 'Ürün Adı', stock AS 'Stok', money AS 'Fiyat' From productInformation where companyid ='" + adminInformation8.companyid + "'", con);
            DataSet dst = new DataSet();
            con.Open();
            data.Fill(dst, "productInformation");
            bunifuCustomDataGrid1.DataSource = dst.Tables[0];
            con.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            decimal fiyat, toplamFiyat;
            int adet;
            for (int i = 0; i < bunifuCustomDataGrid1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("Select * from productInformation where id='" + bunifuCustomDataGrid1.SelectedRows[i].Cells["id"].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    fiyat = Convert.ToDecimal(dr["money"]);
                    adet = Convert.ToInt32(bunifuTextbox1.text);
                    toplamFiyat = fiyat * adet;
                    label2.Text = toplamFiyat.ToString();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
                con.Close();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < bunifuCustomDataGrid1.SelectedRows.Count; i++)
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string kayit = "insert into saleProduct(saleProduct,saleStock) values(@saleProduct,@saleStock)";
                    SqlCommand komut = new SqlCommand(kayit, con);

                    komut.Parameters.AddWithValue("@saleProduct", bunifuCustomDataGrid1.SelectedRows[i].Cells["id"].Value);
                    komut.Parameters.AddWithValue("@saleStock", Convert.ToInt32(bunifuTextbox1.text));
                    komut.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Satış Yapıldı", "Satış Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
            SqlDataAdapter da = new SqlDataAdapter("Select id,productName AS 'Ürün Adı', stock AS 'Stok', money AS 'Fiyat' From productInformation where companyid ='" + adminInformation8.companyid + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "productInformation");
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.adminInformation6 = adminInformation8;
            form6.Show();
            this.Close();
        }
    }
}

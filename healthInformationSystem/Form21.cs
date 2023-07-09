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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        public EmployeeInformation employeeInformation21 { get; set; }
        public appointment appointment21 { get; set; }  
        static string conString = "Data Source=LAPTOP-H09FS3UQ\\SQLEXPRESS;Initial Catalog=healthInformationSystem;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        SqlDataReader dr;
        string city, district;

        private void Form21_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into assayEmployee(patientid,patientName,employeeid,employeeName,policlinicName,assay,explanation,hospitalid) values(@patientid,@patientName,@employeeid,@employeeName,@policlinicName,@assay,@explanation,@hospitalid)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@patientid", Convert.ToInt32(label1.Text));
                komut.Parameters.AddWithValue("@patientName", label3.Text);
                komut.Parameters.AddWithValue("@employeeid", employeeInformation21.id);
                komut.Parameters.AddWithValue("@employeeName", employeeInformation21.nameSurname);
                komut.Parameters.AddWithValue("@policlinicName", employeeInformation21.department);
                if(radioButton1.Checked == true)
                {
                    komut.Parameters.AddWithValue("@assay", "Kan Tahlili");
                }
                if (radioButton2.Checked == true)
                {
                    komut.Parameters.AddWithValue("@assay", "İdrar Tahlili");
                }
                if (radioButton3.Checked == true)
                {
                    komut.Parameters.AddWithValue("@assay", "Röntgen");
                }
                komut.Parameters.AddWithValue("@explanation", richTextBox1.Text);
                komut.Parameters.AddWithValue("@hospitalid", employeeInformation21.hospitalid);

                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Tahlil verildi.");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthInformationSystemDataSet1.policlinic' table. You can move, or remove it, as needed.
            this.policlinicTableAdapter.Fill(this.healthInformationSystemDataSet1.policlinic);
            // TODO: This line of code loads data into the 'healthInformationSystemDataSet1.hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter.Fill(this.healthInformationSystemDataSet1.hospital);
            // TODO: This line of code loads data into the 'healthInformationSystemDataSet1.district' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.healthInformationSystemDataSet1.district);
            // TODO: This line of code loads data into the 'healthInformationSystemDataSet1.city' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.healthInformationSystemDataSet1.city);

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked == true)
            {
                richTextBox2.Visible = true;
            }
            if(radioButton6.Checked == false)
            {
                richTextBox2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into prescription(prescription,patientid,patientName,employeeid,employeeName,hospitalid,hospitalName,policlinicid,policlinicName,date,lengthOfStay) values(@prescription,@patientid,@patientName,@employeeid,@employeeName,@hospitalid,@hospitalName,@policlinicid,@policlinicName,@date,@lengthOfStay)";
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@patientid", Convert.ToInt32(label1.Text));
                komut.Parameters.AddWithValue("@patientName", label3.Text);
                komut.Parameters.AddWithValue("@employeeid", employeeInformation21.id);
                komut.Parameters.AddWithValue("@employeeName", employeeInformation21.nameSurname);
                komut.Parameters.AddWithValue("@hospitalid", employeeInformation21.hospitalid);
                komut.Parameters.AddWithValue("@hospitalName", employeeInformation21.hospitalName);
                komut.Parameters.AddWithValue("@policlinicid", employeeInformation21.policlinicid);
                komut.Parameters.AddWithValue("@policlinicName", employeeInformation21.department);
                komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                
                if (radioButton4.Checked == true)
                {
                    komut.Parameters.AddWithValue("@prescription", "Serum Tedavisi Uygulandı");
                    MessageBox.Show("Serum Tedavisi Verildi");
                }
                if (radioButton5.Checked == true)
                {
                    komut.Parameters.AddWithValue("@prescription", "Yatış Verildi");
                    komut.Parameters.AddWithValue("@lengthOfStay", textBox1.Text);
                    MessageBox.Show("Yatış Verildi.");
                }
                if(radioButton5.Checked == false)
                {
                    komut.Parameters.AddWithValue("@lengthOfStay", "Yatış Süresi Verilmemiştir");
                }
                if (radioButton6.Checked == true)
                {
                    komut.Parameters.AddWithValue("@prescription", richTextBox2.Text);
                    MessageBox.Show("Reçete Oluşturuldu.");
                }

                komut.ExecuteNonQuery();

                connect.Close();
                

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked == true)
            {
                textBox1.Visible = true;
            }
            if(radioButton5.Checked == false)
            {
                textBox1.Visible=false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into dispatch(referralHospitalId,referralHospitalName,referralPolyclinicId,referralPolyclinicName,referredHospitalId,referredHospitalName,referredPoliclinicId,referredPoliclinicName,reasonForReferral,date) values(@referralHospitalId,@referralHospitalName,@referralPolyclinicId,@referralPolyclinicName,@referredHospitalId,@referredHospitalName,@referredPoliclinicId,@referredPoliclinicName,@reasonForReferral,@date)";
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@referralHospitalId", employeeInformation21.hospitalid);
                komut.Parameters.AddWithValue("@referralHospitalName", employeeInformation21.hospitalName);
                komut.Parameters.AddWithValue("@referralPolyclinicId", employeeInformation21.policlinicid);
                komut.Parameters.AddWithValue("@referralPolyclinicName", employeeInformation21.department);
                komut.Parameters.AddWithValue("@referredHospitalId", comboBox3.SelectedValue);
                komut.Parameters.AddWithValue("@referredHospitalName", comboBox3.Text);
                komut.Parameters.AddWithValue("@referredPoliclinicId", comboBox4.SelectedValue);
                komut.Parameters.AddWithValue("@referredPoliclinicName", comboBox4.Text);
                komut.Parameters.AddWithValue("@reasonForReferral", richTextBox4.Text);
                komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Hasta Belirtilen Yere Sevk Edildi.","Sevk Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton8.Checked == true)
            {
                richTextBox5.Visible = true;
            }
            if(radioButton8.Checked == false)
            {
                richTextBox5.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into diagnosis(patientid,patientName,patientTc,employeeid,employeeName,hospitalid,hospitalName,policlinicid,policlinicName,conformity,eligibilityDetail,diagnosis,date) values(@patientid,@patientName,@patientTc,@employeeid,@employeeName,@hospitalid,@hospitalName,@policlinicid,@policlinicName,@conformity,@eligibilityDetail,@diagnosis,@date)";
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@patientid", Convert.ToInt32(label1.Text));
                komut.Parameters.AddWithValue("@patientName", label3.Text);
                komut.Parameters.AddWithValue("@patientTc", label2.Text);
                komut.Parameters.AddWithValue("@employeeid", employeeInformation21.id);
                komut.Parameters.AddWithValue("@employeeName", employeeInformation21.nameSurname);
                komut.Parameters.AddWithValue("@hospitalid", employeeInformation21.hospitalid);
                komut.Parameters.AddWithValue("@hospitalName", employeeInformation21.hospitalName);
                komut.Parameters.AddWithValue("@policlinicid", employeeInformation21.policlinicid);
                komut.Parameters.AddWithValue("@policlinicName", employeeInformation21.department);
                if(radioButton7.Checked == true)
                {
                    komut.Parameters.AddWithValue("@conformity", "Uygun");
                    komut.Parameters.AddWithValue("@eligibilityDetail", "Uygun");
                }
                if (radioButton8.Checked == true)
                {
                    komut.Parameters.AddWithValue("@conformity", "Kısmi Uygun");
                    komut.Parameters.AddWithValue("@eligibilityDetail", richTextBox5.Text);
                }
                if (radioButton9.Checked == true)
                {
                    komut.Parameters.AddWithValue("@conformity", "Uygun Değil");
                    komut.Parameters.AddWithValue("@eligibilityDetail", "Uygun Değil");
                }
                komut.Parameters.AddWithValue("@diagnosis", richTextBox3.Text);
                komut.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());  
                komut.ExecuteNonQuery();

                connect.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                SqlCommand datainsert = new SqlCommand("insert into appointmentHistory (patientid,patientTc,patientName,city,district,hospitalName,employeeid,employeeName,department,date,policlinicid) values (@patientid,@patientTc,@patientName,@city,@district,@hospitalName,@employeeid,@employeeName,@department,@date,@policlinicid)", connect);
                datainsert.Parameters.AddWithValue("@patientid", appointment21.patientid);
                datainsert.Parameters.AddWithValue("@patientTc", appointment21.patientTc);
                datainsert.Parameters.AddWithValue("@patientName", appointment21.patientName);
                datainsert.Parameters.AddWithValue("@city", appointment21.city);
                datainsert.Parameters.AddWithValue("@district", appointment21.district);
                datainsert.Parameters.AddWithValue("@hospitalName", employeeInformation21.hospitalName);
                datainsert.Parameters.AddWithValue("@employeeid", employeeInformation21.id);
                datainsert.Parameters.AddWithValue("@employeeName", employeeInformation21.nameSurname);
                datainsert.Parameters.AddWithValue("@department", employeeInformation21.department);
                datainsert.Parameters.AddWithValue("@date", DateTime.Now.ToLongDateString());
                datainsert.Parameters.AddWithValue("@policlinicid", employeeInformation21.policlinicid);
                datainsert.ExecuteNonQuery();
                connect.Close();
            }

            connect.Open();
            SqlCommand cmd = new SqlCommand("delete from patientAppointment where id='" + appointment21.appointmentid + "'", connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Teşhis Konuldu.", "Teşhis Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.employeeInformation20 = employeeInformation21;
            form20.Show();
            this.Close();
        }
    }
}

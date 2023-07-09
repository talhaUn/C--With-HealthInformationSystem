namespace healthInformationSystem
{
    partial class Form16
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.healthInformationSystemDataSet = new healthInformationSystem.healthInformationSystemDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fKdistrictcityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.fKhospitaldistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.fKpoliclinichospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.fKemployeeInformationpoliclinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cityTableAdapter = new healthInformationSystem.healthInformationSystemDataSetTableAdapters.cityTableAdapter();
            this.districtTableAdapter = new healthInformationSystem.healthInformationSystemDataSetTableAdapters.districtTableAdapter();
            this.hospitalTableAdapter = new healthInformationSystem.healthInformationSystemDataSetTableAdapters.hospitalTableAdapter();
            this.policlinicTableAdapter = new healthInformationSystem.healthInformationSystemDataSetTableAdapters.policlinicTableAdapter();
            this.employeeInformationTableAdapter = new healthInformationSystem.healthInformationSystemDataSetTableAdapters.employeeInformationTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthInformationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdistrictcityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKhospitaldistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpoliclinichospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKemployeeInformationpoliclinicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cityBindingSource;
            this.comboBox1.DisplayMember = "city";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "cityid";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "city";
            this.cityBindingSource.DataSource = this.healthInformationSystemDataSet;
            // 
            // healthInformationSystemDataSet
            // 
            this.healthInformationSystemDataSet.DataSetName = "healthInformationSystemDataSet";
            this.healthInformationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.fKdistrictcityBindingSource;
            this.comboBox2.DisplayMember = "district";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "districtid";
            // 
            // fKdistrictcityBindingSource
            // 
            this.fKdistrictcityBindingSource.DataMember = "FK_district_city";
            this.fKdistrictcityBindingSource.DataSource = this.cityBindingSource;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.fKhospitaldistrictBindingSource;
            this.comboBox3.DisplayMember = "hospitalName";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(147, 113);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(214, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "hospitalid";
            // 
            // fKhospitaldistrictBindingSource
            // 
            this.fKhospitaldistrictBindingSource.DataMember = "FK_hospital_district";
            this.fKhospitaldistrictBindingSource.DataSource = this.fKdistrictcityBindingSource;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.fKpoliclinichospitalBindingSource;
            this.comboBox4.DisplayMember = "policlinicName";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(147, 147);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(214, 21);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.ValueMember = "policlinicid";
            // 
            // fKpoliclinichospitalBindingSource
            // 
            this.fKpoliclinichospitalBindingSource.DataMember = "FK_policlinic_hospital";
            this.fKpoliclinichospitalBindingSource.DataSource = this.fKhospitaldistrictBindingSource;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.fKemployeeInformationpoliclinicBindingSource;
            this.comboBox5.DisplayMember = "nameSurname";
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(641, 77);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(214, 21);
            this.comboBox5.TabIndex = 4;
            this.comboBox5.ValueMember = "id";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // fKemployeeInformationpoliclinicBindingSource
            // 
            this.fKemployeeInformationpoliclinicBindingSource.DataMember = "FK_employeeInformation_policlinic";
            this.fKemployeeInformationpoliclinicBindingSource.DataSource = this.fKpoliclinichospitalBindingSource;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(641, 114);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(214, 21);
            this.comboBox6.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(641, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şehir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(113, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "İlçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hastane:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(77, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Poliklinik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(588, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(595, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(595, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tarih:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(428, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Randevu Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // districtTableAdapter
            // 
            this.districtTableAdapter.ClearBeforeFill = true;
            // 
            // hospitalTableAdapter
            // 
            this.hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // policlinicTableAdapter
            // 
            this.policlinicTableAdapter.ClearBeforeFill = true;
            // 
            // employeeInformationTableAdapter
            // 
            this.employeeInformationTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::healthInformationSystem.Properties.Resources.pngwing_com__7_;
            this.pictureBox1.Location = new System.Drawing.Point(814, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(926, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form16_FormClosing);
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthInformationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdistrictcityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKhospitaldistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpoliclinichospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKemployeeInformationpoliclinicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private healthInformationSystemDataSet healthInformationSystemDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private healthInformationSystemDataSetTableAdapters.cityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource fKdistrictcityBindingSource;
        private healthInformationSystemDataSetTableAdapters.districtTableAdapter districtTableAdapter;
        private System.Windows.Forms.BindingSource fKhospitaldistrictBindingSource;
        private healthInformationSystemDataSetTableAdapters.hospitalTableAdapter hospitalTableAdapter;
        private System.Windows.Forms.BindingSource fKpoliclinichospitalBindingSource;
        private healthInformationSystemDataSetTableAdapters.policlinicTableAdapter policlinicTableAdapter;
        private System.Windows.Forms.BindingSource fKemployeeInformationpoliclinicBindingSource;
        private healthInformationSystemDataSetTableAdapters.employeeInformationTableAdapter employeeInformationTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace healthInformationSystem
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            this.btnMesaiBitir = new System.Windows.Forms.Button();
            this.btnMesaiBaslat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMesaiBitir
            // 
            this.btnMesaiBitir.BackColor = System.Drawing.Color.Red;
            this.btnMesaiBitir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesaiBitir.Location = new System.Drawing.Point(698, 243);
            this.btnMesaiBitir.Name = "btnMesaiBitir";
            this.btnMesaiBitir.Size = new System.Drawing.Size(90, 43);
            this.btnMesaiBitir.TabIndex = 6;
            this.btnMesaiBitir.Text = "Mesaiyi Bitir";
            this.btnMesaiBitir.UseVisualStyleBackColor = false;
            this.btnMesaiBitir.Click += new System.EventHandler(this.btnMesaiBitir_Click);
            // 
            // btnMesaiBaslat
            // 
            this.btnMesaiBaslat.BackColor = System.Drawing.Color.Lime;
            this.btnMesaiBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesaiBaslat.Location = new System.Drawing.Point(13, 243);
            this.btnMesaiBaslat.Name = "btnMesaiBaslat";
            this.btnMesaiBaslat.Size = new System.Drawing.Size(90, 43);
            this.btnMesaiBaslat.TabIndex = 5;
            this.btnMesaiBaslat.Text = "Mesaiyi Başlat";
            this.btnMesaiBaslat.UseVisualStyleBackColor = false;
            this.btnMesaiBaslat.Click += new System.EventHandler(this.btnMesaiBaslat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 223);
            this.dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::healthInformationSystem.Properties.Resources.pngwing_com__7_;
            this.pictureBox1.Location = new System.Drawing.Point(688, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMesaiBitir);
            this.Controls.Add(this.btnMesaiBaslat);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working Hour Information";
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMesaiBitir;
        private System.Windows.Forms.Button btnMesaiBaslat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
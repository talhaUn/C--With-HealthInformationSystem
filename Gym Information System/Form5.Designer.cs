namespace Gym_Information_System
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtTc = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtTel = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtmail = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 297);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 103);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Adres";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTileButton1);
            this.bunifuGradientPanel1.Controls.Add(this.txtmail);
            this.bunifuGradientPanel1.Controls.Add(this.txtTel);
            this.bunifuGradientPanel1.Controls.Add(this.txtTc);
            this.bunifuGradientPanel1.Controls.Add(this.txtAd);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.richTextBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Personel Bilgileri";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.White;
            this.txtAd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAd.BackgroundImage")));
            this.txtAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.Icon = ((System.Drawing.Image)(resources.GetObject("txtAd.Icon")));
            this.txtAd.Location = new System.Drawing.Point(55, 53);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(213, 41);
            this.txtAd.TabIndex = 1;
            this.txtAd.text = "Ad Soyad";
            // 
            // txtTc
            // 
            this.txtTc.BackColor = System.Drawing.Color.White;
            this.txtTc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTc.BackgroundImage")));
            this.txtTc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTc.ForeColor = System.Drawing.Color.Black;
            this.txtTc.Icon = ((System.Drawing.Image)(resources.GetObject("txtTc.Icon")));
            this.txtTc.Location = new System.Drawing.Point(55, 115);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(213, 41);
            this.txtTc.TabIndex = 2;
            this.txtTc.text = "T.C No";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTel.BackgroundImage")));
            this.txtTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.Icon = ((System.Drawing.Image)(resources.GetObject("txtTel.Icon")));
            this.txtTel.Location = new System.Drawing.Point(55, 175);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(213, 41);
            this.txtTel.TabIndex = 3;
            this.txtTel.text = "Telefon No";
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.White;
            this.txtmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtmail.BackgroundImage")));
            this.txtmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtmail.ForeColor = System.Drawing.Color.Black;
            this.txtmail.Icon = ((System.Drawing.Image)(resources.GetObject("txtmail.Icon")));
            this.txtmail.Location = new System.Drawing.Point(55, 238);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(213, 41);
            this.txtmail.TabIndex = 4;
            this.txtmail.text = "E-Mail";
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuTileButton1.color = System.Drawing.Color.Black;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::Gym_Information_System.Properties.Resources.pngwing_com__30_;
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Kaydet";
            this.bunifuTileButton1.Location = new System.Drawing.Point(451, 115);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(187, 164);
            this.bunifuTileButton1.TabIndex = 13;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Gym_Information_System.Properties.Resources.pngwing_com__28_;
            this.pictureBox1.Location = new System.Drawing.Point(730, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Gym_Information_System.Properties.Resources.pngwing_com__29_;
            this.pictureBox2.Location = new System.Drawing.Point(730, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kayıt";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTextbox txtmail;
        private Bunifu.Framework.UI.BunifuTextbox txtTel;
        private Bunifu.Framework.UI.BunifuTextbox txtTc;
        private Bunifu.Framework.UI.BunifuTextbox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
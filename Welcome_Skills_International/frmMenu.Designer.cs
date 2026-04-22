namespace Welcome_Skills_International
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblMenu = new System.Windows.Forms.Label();
            this.pictureBoxRegistration = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistraion = new System.Windows.Forms.Label();
            this.btContactus = new System.Windows.Forms.Label();
            this.btn2Exit = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(110, 76);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(218, 45);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Main Menu";
            // 
            // pictureBoxRegistration
            // 
            this.pictureBoxRegistration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistration.BackgroundImage")));
            this.pictureBoxRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRegistration.Location = new System.Drawing.Point(65, 170);
            this.pictureBoxRegistration.Name = "pictureBoxRegistration";
            this.pictureBoxRegistration.Size = new System.Drawing.Size(118, 91);
            this.pictureBoxRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRegistration.TabIndex = 1;
            this.pictureBoxRegistration.TabStop = false;
            this.pictureBoxRegistration.Click += new System.EventHandler(this.pictureBoxRegistration_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(65, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 108);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistraion
            // 
            this.btnRegistraion.AutoSize = true;
            this.btnRegistraion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistraion.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraion.ForeColor = System.Drawing.Color.White;
            this.btnRegistraion.Location = new System.Drawing.Point(216, 207);
            this.btnRegistraion.Name = "btnRegistraion";
            this.btnRegistraion.Size = new System.Drawing.Size(254, 22);
            this.btnRegistraion.TabIndex = 3;
            this.btnRegistraion.Text = "STUDENT REGISTRATION";
            this.btnRegistraion.Click += new System.EventHandler(this.btnRegistraion_Click);
            // 
            // btContactus
            // 
            this.btContactus.AutoSize = true;
            this.btContactus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btContactus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContactus.ForeColor = System.Drawing.Color.White;
            this.btContactus.Location = new System.Drawing.Point(216, 359);
            this.btContactus.Name = "btContactus";
            this.btContactus.Size = new System.Drawing.Size(137, 23);
            this.btContactus.TabIndex = 4;
            this.btContactus.Text = "CONTACT US";
            this.btContactus.Click += new System.EventHandler(this.btContactus_Click);
            // 
            // btn2Exit
            // 
            this.btn2Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn2Exit.Image")));
            this.btn2Exit.Location = new System.Drawing.Point(827, 3);
            this.btn2Exit.Name = "btn2Exit";
            this.btn2Exit.Size = new System.Drawing.Size(52, 51);
            this.btn2Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn2Exit.TabIndex = 5;
            this.btn2Exit.TabStop = false;
            this.btn2Exit.Click += new System.EventHandler(this.btn2Exit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(747, 474);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn2Exit);
            this.Controls.Add(this.btContactus);
            this.Controls.Add(this.btnRegistraion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxRegistration);
            this.Controls.Add(this.lblMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Menu - Skills Itnternational";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pictureBoxRegistration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btnRegistraion;
        private System.Windows.Forms.Label btContactus;
        private System.Windows.Forms.PictureBox btn2Exit;
        private System.Windows.Forms.Button btnBack;
    }
}
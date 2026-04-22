namespace Welcome_Skills_International
{
    partial class frmregistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmregistration));
            this.lblSI = new System.Windows.Forms.Label();
            this.linkLabel1Logout = new System.Windows.Forms.LinkLabel();
            this.groupBox1Studentreg = new System.Windows.Forms.GroupBox();
            this.txtRegno = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBoxParentDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.groupBoxContactDe = new System.Windows.Forms.GroupBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.groupBox2BasicDetails = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbReg = new System.Windows.Forms.ComboBox();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.linkLabelExit = new System.Windows.Forms.LinkLabel();
            this.groupBox1Studentreg.SuspendLayout();
            this.groupBoxParentDetails.SuspendLayout();
            this.groupBoxContactDe.SuspendLayout();
            this.groupBox2BasicDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSI
            // 
            this.lblSI.AutoSize = true;
            this.lblSI.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSI.Location = new System.Drawing.Point(214, 4);
            this.lblSI.Name = "lblSI";
            this.lblSI.Size = new System.Drawing.Size(248, 37);
            this.lblSI.TabIndex = 0;
            this.lblSI.Text = "Skills International";
            this.lblSI.Click += new System.EventHandler(this.lblSI_Click);
            // 
            // linkLabel1Logout
            // 
            this.linkLabel1Logout.AutoSize = true;
            this.linkLabel1Logout.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkLabel1Logout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1Logout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1Logout.Location = new System.Drawing.Point(7, 5);
            this.linkLabel1Logout.Name = "linkLabel1Logout";
            this.linkLabel1Logout.Size = new System.Drawing.Size(67, 24);
            this.linkLabel1Logout.TabIndex = 22;
            this.linkLabel1Logout.TabStop = true;
            this.linkLabel1Logout.Text = "Logout";
            this.linkLabel1Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1Logout_LinkClicked);
            // 
            // groupBox1Studentreg
            // 
            this.groupBox1Studentreg.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1Studentreg.Controls.Add(this.txtRegno);
            this.groupBox1Studentreg.Controls.Add(this.btnDelete);
            this.groupBox1Studentreg.Controls.Add(this.btnClear);
            this.groupBox1Studentreg.Controls.Add(this.btnUpdate);
            this.groupBox1Studentreg.Controls.Add(this.btnRegister);
            this.groupBox1Studentreg.Controls.Add(this.groupBoxParentDetails);
            this.groupBox1Studentreg.Controls.Add(this.groupBoxContactDe);
            this.groupBox1Studentreg.Controls.Add(this.groupBox2BasicDetails);
            this.groupBox1Studentreg.Controls.Add(this.btnSearch);
            this.groupBox1Studentreg.Controls.Add(this.cmbReg);
            this.groupBox1Studentreg.Controls.Add(this.lblRegistrationNo);
            this.groupBox1Studentreg.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1Studentreg.Location = new System.Drawing.Point(49, 40);
            this.groupBox1Studentreg.Name = "groupBox1Studentreg";
            this.groupBox1Studentreg.Size = new System.Drawing.Size(598, 690);
            this.groupBox1Studentreg.TabIndex = 2;
            this.groupBox1Studentreg.TabStop = false;
            this.groupBox1Studentreg.Text = "Student Registration";
            this.groupBox1Studentreg.Enter += new System.EventHandler(this.groupBox1Studentreg_Enter);
            // 
            // txtRegno
            // 
            this.txtRegno.Location = new System.Drawing.Point(182, 34);
            this.txtRegno.MaxLength = 10;
            this.txtRegno.Name = "txtRegno";
            this.txtRegno.Size = new System.Drawing.Size(231, 28);
            this.txtRegno.TabIndex = 1;
            this.txtRegno.TextChanged += new System.EventHandler(this.txtRegno_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(485, 642);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 39);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(367, 642);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 39);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(141, 642);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 39);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(29, 642);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(92, 39);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBoxParentDetails
            // 
            this.groupBoxParentDetails.Controls.Add(this.txtContactNo);
            this.groupBoxParentDetails.Controls.Add(this.txtNIC);
            this.groupBoxParentDetails.Controls.Add(this.txtPName);
            this.groupBoxParentDetails.Controls.Add(this.lblContactNo);
            this.groupBoxParentDetails.Controls.Add(this.lblNIC);
            this.groupBoxParentDetails.Controls.Add(this.lblParentName);
            this.groupBoxParentDetails.Location = new System.Drawing.Point(30, 480);
            this.groupBoxParentDetails.Name = "groupBoxParentDetails";
            this.groupBoxParentDetails.Size = new System.Drawing.Size(549, 158);
            this.groupBoxParentDetails.TabIndex = 5;
            this.groupBoxParentDetails.TabStop = false;
            this.groupBoxParentDetails.Text = "Parent Details";
            this.groupBoxParentDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(134, 104);
            this.txtContactNo.MaxLength = 10;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(252, 28);
            this.txtContactNo.TabIndex = 14;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(134, 69);
            this.txtNIC.MaxLength = 12;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(252, 28);
            this.txtNIC.TabIndex = 13;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(134, 34);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(396, 28);
            this.txtPName.TabIndex = 12;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(1, 111);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(125, 21);
            this.lblContactNo.TabIndex = 2;
            this.lblContactNo.Text = "Contact Number";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(21, 76);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(34, 21);
            this.lblNIC.TabIndex = 1;
            this.lblNIC.Text = "NIC";
            this.lblNIC.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(20, 41);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(101, 21);
            this.lblParentName.TabIndex = 0;
            this.lblParentName.Text = "Parent Name";
            // 
            // groupBoxContactDe
            // 
            this.groupBoxContactDe.Controls.Add(this.txtHomePhone);
            this.groupBoxContactDe.Controls.Add(this.txtMobilePhone);
            this.groupBoxContactDe.Controls.Add(this.txtEmail);
            this.groupBoxContactDe.Controls.Add(this.txtAddress);
            this.groupBoxContactDe.Controls.Add(this.lblHomePhone);
            this.groupBoxContactDe.Controls.Add(this.lblMobilePhone);
            this.groupBoxContactDe.Controls.Add(this.lblEmail);
            this.groupBoxContactDe.Controls.Add(this.lblAddress);
            this.groupBoxContactDe.Location = new System.Drawing.Point(30, 292);
            this.groupBoxContactDe.Name = "groupBoxContactDe";
            this.groupBoxContactDe.Size = new System.Drawing.Size(549, 180);
            this.groupBoxContactDe.TabIndex = 4;
            this.groupBoxContactDe.TabStop = false;
            this.groupBoxContactDe.Text = "Contact Details";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(400, 138);
            this.txtHomePhone.MaxLength = 10;
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(135, 28);
            this.txtHomePhone.TabIndex = 11;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(143, 138);
            this.txtMobilePhone.MaxLength = 10;
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(133, 28);
            this.txtMobilePhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(392, 28);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(143, 21);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(392, 63);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(294, 141);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(100, 21);
            this.lblHomePhone.TabIndex = 3;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(2, 141);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(107, 21);
            this.lblMobilePhone.TabIndex = 2;
            this.lblMobilePhone.Text = "Mobile Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 37);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 21);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // groupBox2BasicDetails
            // 
            this.groupBox2BasicDetails.Controls.Add(this.rbFemale);
            this.groupBox2BasicDetails.Controls.Add(this.rbMale);
            this.groupBox2BasicDetails.Controls.Add(this.dtpDOB);
            this.groupBox2BasicDetails.Controls.Add(this.txtLastName);
            this.groupBox2BasicDetails.Controls.Add(this.txtFirstName);
            this.groupBox2BasicDetails.Controls.Add(this.lblGender);
            this.groupBox2BasicDetails.Controls.Add(this.lblDOB);
            this.groupBox2BasicDetails.Controls.Add(this.lblLastName);
            this.groupBox2BasicDetails.Controls.Add(this.lblFirstName);
            this.groupBox2BasicDetails.Location = new System.Drawing.Point(30, 75);
            this.groupBox2BasicDetails.Name = "groupBox2BasicDetails";
            this.groupBox2BasicDetails.Size = new System.Drawing.Size(549, 208);
            this.groupBox2BasicDetails.TabIndex = 3;
            this.groupBox2BasicDetails.TabStop = false;
            this.groupBox2BasicDetails.Text = "Basic Details";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(369, 163);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(81, 25);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(153, 165);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 25);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(152, 119);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(340, 28);
            this.dtpDOB.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(152, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(340, 28);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(152, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(340, 28);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(23, 167);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 21);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(23, 119);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(98, 21);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(23, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 21);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 21);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(499, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 34);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbReg
            // 
            this.cmbReg.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReg.FormattingEnabled = true;
            this.cmbReg.Location = new System.Drawing.Point(182, 33);
            this.cmbReg.MaxLength = 10;
            this.cmbReg.Name = "cmbReg";
            this.cmbReg.Size = new System.Drawing.Size(231, 29);
            this.cmbReg.TabIndex = 2;
            this.cmbReg.Visible = false;
            this.cmbReg.SelectedIndexChanged += new System.EventHandler(this.cmbReg_SelectedIndexChanged);
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationNo.Location = new System.Drawing.Point(26, 36);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(59, 21);
            this.lblRegistrationNo.TabIndex = 0;
            this.lblRegistrationNo.Text = "Reg No";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(49, 737);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 34);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // linkLabelExit
            // 
            this.linkLabelExit.AutoSize = true;
            this.linkLabelExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelExit.Location = new System.Drawing.Point(606, 741);
            this.linkLabelExit.Name = "linkLabelExit";
            this.linkLabelExit.Size = new System.Drawing.Size(41, 24);
            this.linkLabelExit.TabIndex = 20;
            this.linkLabelExit.TabStop = true;
            this.linkLabelExit.Text = "Exit";
            this.linkLabelExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExit_LinkClicked);
            // 
            // frmregistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(690, 783);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1Studentreg);
            this.Controls.Add(this.linkLabel1Logout);
            this.Controls.Add(this.lblSI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmregistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration - Skills Internationals";
            this.Load += new System.EventHandler(this.frmregistration_Load);
            this.groupBox1Studentreg.ResumeLayout(false);
            this.groupBox1Studentreg.PerformLayout();
            this.groupBoxParentDetails.ResumeLayout(false);
            this.groupBoxParentDetails.PerformLayout();
            this.groupBoxContactDe.ResumeLayout(false);
            this.groupBoxContactDe.PerformLayout();
            this.groupBox2BasicDetails.ResumeLayout(false);
            this.groupBox2BasicDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSI;
        private System.Windows.Forms.LinkLabel linkLabel1Logout;
        private System.Windows.Forms.GroupBox groupBox1Studentreg;
        private System.Windows.Forms.GroupBox groupBoxContactDe;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox groupBox2BasicDetails;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbReg;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.GroupBox groupBoxParentDetails;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel linkLabelExit;
        private System.Windows.Forms.TextBox txtRegno;
    }
}
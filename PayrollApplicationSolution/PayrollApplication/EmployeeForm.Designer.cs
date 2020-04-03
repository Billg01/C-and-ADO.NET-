namespace PayrollApplication
{
    partial class EmployeeForm
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
            this.grpEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.chkUnionMember = new System.Windows.Forms.CheckBox();
            this.txtNationalInsuranceNo = new System.Windows.Forms.TextBox();
            this.lblUnionMembership = new System.Windows.Forms.Label();
            this.grpMaritalStatus = new System.Windows.Forms.GroupBox();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblNationalInsID = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.grpEmployeeContactDetails = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpEmployeeInformation.SuspendLayout();
            this.grpMaritalStatus.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpEmployeeContactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeInformation
            // 
            this.grpEmployeeInformation.Controls.Add(this.dtpDateOfBirth);
            this.grpEmployeeInformation.Controls.Add(this.chkUnionMember);
            this.grpEmployeeInformation.Controls.Add(this.txtNationalInsuranceNo);
            this.grpEmployeeInformation.Controls.Add(this.lblUnionMembership);
            this.grpEmployeeInformation.Controls.Add(this.grpMaritalStatus);
            this.grpEmployeeInformation.Controls.Add(this.lblDateOfBirth);
            this.grpEmployeeInformation.Controls.Add(this.lblNationalInsID);
            this.grpEmployeeInformation.Controls.Add(this.grpGender);
            this.grpEmployeeInformation.Controls.Add(this.txtLastName);
            this.grpEmployeeInformation.Controls.Add(this.txtFirstName);
            this.grpEmployeeInformation.Controls.Add(this.lblLastName);
            this.grpEmployeeInformation.Controls.Add(this.lblFirstName);
            this.grpEmployeeInformation.Controls.Add(this.txtEmployeeID);
            this.grpEmployeeInformation.Controls.Add(this.lblEmployeeID);
            this.grpEmployeeInformation.Location = new System.Drawing.Point(56, 53);
            this.grpEmployeeInformation.Name = "grpEmployeeInformation";
            this.grpEmployeeInformation.Size = new System.Drawing.Size(425, 548);
            this.grpEmployeeInformation.TabIndex = 0;
            this.grpEmployeeInformation.TabStop = false;
            this.grpEmployeeInformation.Text = "Employee Information";
            this.grpEmployeeInformation.Enter += new System.EventHandler(this.grpEmployeeInformation_Enter);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(160, 368);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 6;
            // 
            // chkUnionMember
            // 
            this.chkUnionMember.AutoSize = true;
            this.chkUnionMember.Location = new System.Drawing.Point(236, 494);
            this.chkUnionMember.Name = "chkUnionMember";
            this.chkUnionMember.Size = new System.Drawing.Size(81, 17);
            this.chkUnionMember.TabIndex = 9;
            this.chkUnionMember.Text = "Is Member :";
            this.chkUnionMember.UseVisualStyleBackColor = true;
            // 
            // txtNationalInsuranceNo
            // 
            this.txtNationalInsuranceNo.Location = new System.Drawing.Point(260, 320);
            this.txtNationalInsuranceNo.Name = "txtNationalInsuranceNo";
            this.txtNationalInsuranceNo.Size = new System.Drawing.Size(100, 20);
            this.txtNationalInsuranceNo.TabIndex = 5;
            this.txtNationalInsuranceNo.TextChanged += new System.EventHandler(this.txtNationalInsID_TextChanged);
            // 
            // lblUnionMembership
            // 
            this.lblUnionMembership.AutoSize = true;
            this.lblUnionMembership.Location = new System.Drawing.Point(63, 494);
            this.lblUnionMembership.Name = "lblUnionMembership";
            this.lblUnionMembership.Size = new System.Drawing.Size(101, 13);
            this.lblUnionMembership.TabIndex = 11;
            this.lblUnionMembership.Text = "Union Membership :";
            // 
            // grpMaritalStatus
            // 
            this.grpMaritalStatus.Controls.Add(this.rdbSingle);
            this.grpMaritalStatus.Controls.Add(this.rdbMarried);
            this.grpMaritalStatus.Location = new System.Drawing.Point(66, 408);
            this.grpMaritalStatus.Name = "grpMaritalStatus";
            this.grpMaritalStatus.Size = new System.Drawing.Size(273, 57);
            this.grpMaritalStatus.TabIndex = 10;
            this.grpMaritalStatus.TabStop = false;
            this.grpMaritalStatus.Text = "Marital Status :";
            this.grpMaritalStatus.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(164, 19);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(57, 17);
            this.rdbSingle.TabIndex = 8;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single ";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(23, 20);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(63, 17);
            this.rdbMarried.TabIndex = 7;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married ";
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(66, 374);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(74, 13);
            this.lblDateOfBirth.TabIndex = 9;
            this.lblDateOfBirth.Text = "Date Of Birth :";
            this.lblDateOfBirth.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblNationalInsID
            // 
            this.lblNationalInsID.AutoSize = true;
            this.lblNationalInsID.Location = new System.Drawing.Point(63, 323);
            this.lblNationalInsID.Name = "lblNationalInsID";
            this.lblNationalInsID.Size = new System.Drawing.Size(119, 13);
            this.lblNationalInsID.TabIndex = 8;
            this.lblNationalInsID.Text = "National Insurance No :";
            this.lblNationalInsID.Click += new System.EventHandler(this.label8_Click);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdbFemale);
            this.grpGender.Controls.Add(this.rdbMale);
            this.grpGender.Location = new System.Drawing.Point(69, 232);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(270, 63);
            this.grpGender.TabIndex = 7;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender :";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(161, 29);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 4;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(20, 29);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 3;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(184, 173);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(176, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(184, 122);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(66, 176);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(63, 122);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(66, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name : ";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(184, 66);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(63, 73);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(73, 13);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID :";
            // 
            // grpEmployeeContactDetails
            // 
            this.grpEmployeeContactDetails.Controls.Add(this.cmbCountry);
            this.grpEmployeeContactDetails.Controls.Add(this.txtNotes);
            this.grpEmployeeContactDetails.Controls.Add(this.txtPhoneNumber);
            this.grpEmployeeContactDetails.Controls.Add(this.txtEmailAddress);
            this.grpEmployeeContactDetails.Controls.Add(this.txtPostCode);
            this.grpEmployeeContactDetails.Controls.Add(this.txtCity);
            this.grpEmployeeContactDetails.Controls.Add(this.txtAddress);
            this.grpEmployeeContactDetails.Controls.Add(this.lblNotes);
            this.grpEmployeeContactDetails.Controls.Add(this.lblEmailAddress);
            this.grpEmployeeContactDetails.Controls.Add(this.lblPhoneNumber);
            this.grpEmployeeContactDetails.Controls.Add(this.lblCountry);
            this.grpEmployeeContactDetails.Controls.Add(this.lblPostCode);
            this.grpEmployeeContactDetails.Controls.Add(this.lblCity);
            this.grpEmployeeContactDetails.Controls.Add(this.lblAddress);
            this.grpEmployeeContactDetails.Location = new System.Drawing.Point(556, 53);
            this.grpEmployeeContactDetails.Name = "grpEmployeeContactDetails";
            this.grpEmployeeContactDetails.Size = new System.Drawing.Size(412, 548);
            this.grpEmployeeContactDetails.TabIndex = 1;
            this.grpEmployeeContactDetails.TabStop = false;
            this.grpEmployeeContactDetails.Text = "Employee Contact Details";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Italy",
            "United Kingdom",
            "United States",
            "Canada",
            "Israel"});
            this.cmbCountry.Location = new System.Drawing.Point(152, 201);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(216, 21);
            this.cmbCountry.TabIndex = 14;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(152, 350);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(216, 115);
            this.txtNotes.TabIndex = 13;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(152, 254);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(216, 20);
            this.txtPhoneNumber.TabIndex = 12;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(152, 304);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(216, 20);
            this.txtEmailAddress.TabIndex = 11;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(152, 162);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(216, 20);
            this.txtPostCode.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(152, 113);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(216, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(152, 70);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(58, 353);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 13);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes :";
            this.lblNotes.Click += new System.EventHandler(this.lblNotes_Click);
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(58, 304);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(79, 13);
            this.lblEmailAddress.TabIndex = 5;
            this.lblEmailAddress.Text = "Email Address :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(58, 257);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number :";
            this.lblPhoneNumber.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(58, 210);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(49, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country :";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(58, 162);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(62, 13);
            this.lblPostCode.TabIndex = 2;
            this.lblPostCode.Text = "Post Code :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(58, 113);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(58, 66);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address :";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(844, 626);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(699, 626);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(114, 41);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(56, 626);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(115, 41);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(231, 626);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(112, 41);
            this.btnUpdateEmployee.TabIndex = 5;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(392, 626);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteEmployee.TabIndex = 6;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(553, 626);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 41);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1091, 694);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpEmployeeContactDetails);
            this.Controls.Add(this.grpEmployeeInformation);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employee";
            this.grpEmployeeInformation.ResumeLayout(false);
            this.grpEmployeeInformation.PerformLayout();
            this.grpMaritalStatus.ResumeLayout(false);
            this.grpMaritalStatus.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpEmployeeContactDetails.ResumeLayout(false);
            this.grpEmployeeContactDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeInformation;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox grpEmployeeContactDetails;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblNationalInsID;
        private System.Windows.Forms.Label lblUnionMembership;
        private System.Windows.Forms.GroupBox grpMaritalStatus;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNationalInsuranceNo;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.CheckBox chkUnionMember;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnReset;
    }
}


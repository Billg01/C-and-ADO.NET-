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
            this.grpEmployeeContactDetails = new System.Windows.Forms.GroupBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblNationalInsID = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.grpMaritalStatus = new System.Windows.Forms.GroupBox();
            this.lblUnionMembership = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtNationalInsID = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.ckbIsMember = new System.Windows.Forms.CheckBox();
            this.grpEmployeeInformation.SuspendLayout();
            this.grpEmployeeContactDetails.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpMaritalStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeInformation
            // 
            this.grpEmployeeInformation.Controls.Add(this.ckbIsMember);
            this.grpEmployeeInformation.Controls.Add(this.txtDateOfBirth);
            this.grpEmployeeInformation.Controls.Add(this.txtNationalInsID);
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
            // grpEmployeeContactDetails
            // 
            this.grpEmployeeContactDetails.Controls.Add(this.txtNotes);
            this.grpEmployeeContactDetails.Controls.Add(this.txtPhoneNumber);
            this.grpEmployeeContactDetails.Controls.Add(this.textBox5);
            this.grpEmployeeContactDetails.Controls.Add(this.txtCountry);
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
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(63, 73);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(73, 13);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID :";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(160, 66);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeID.TabIndex = 1;
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
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(66, 176);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(160, 122);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 20);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(160, 176);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(176, 20);
            this.txtLastName.TabIndex = 6;
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
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(20, 29);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(161, 29);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(807, 618);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
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
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(58, 113);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City :";
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
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(58, 210);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(49, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country :";
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
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(58, 303);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(84, 13);
            this.lblEmailAddress.TabIndex = 5;
            this.lblEmailAddress.Text = "Phone Number :";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(58, 353);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes";
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
            // lblUnionMembership
            // 
            this.lblUnionMembership.AutoSize = true;
            this.lblUnionMembership.Location = new System.Drawing.Point(63, 494);
            this.lblUnionMembership.Name = "lblUnionMembership";
            this.lblUnionMembership.Size = new System.Drawing.Size(101, 13);
            this.lblUnionMembership.TabIndex = 11;
            this.lblUnionMembership.Text = "Union Membership :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(152, 66);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(152, 113);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(216, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(152, 162);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(216, 20);
            this.txtPostCode.TabIndex = 9;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(152, 207);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(216, 20);
            this.txtCountry.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(152, 254);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(216, 20);
            this.textBox5.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(152, 303);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(216, 20);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(152, 353);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(216, 20);
            this.txtNotes.TabIndex = 13;
            // 
            // txtNationalInsID
            // 
            this.txtNationalInsID.Location = new System.Drawing.Point(236, 323);
            this.txtNationalInsID.Name = "txtNationalInsID";
            this.txtNationalInsID.Size = new System.Drawing.Size(100, 20);
            this.txtNationalInsID.TabIndex = 0;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(236, 367);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.txtDateOfBirth.TabIndex = 12;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(23, 20);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(66, 17);
            this.rdbMarried.TabIndex = 0;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married :";
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(164, 19);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(60, 17);
            this.rdbSingle.TabIndex = 1;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single :";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // ckbIsMember
            // 
            this.ckbIsMember.AutoSize = true;
            this.ckbIsMember.Location = new System.Drawing.Point(236, 494);
            this.ckbIsMember.Name = "ckbIsMember";
            this.ckbIsMember.Size = new System.Drawing.Size(81, 17);
            this.ckbIsMember.TabIndex = 13;
            this.ckbIsMember.Text = "Is Member :";
            this.ckbIsMember.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1091, 694);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpEmployeeContactDetails);
            this.Controls.Add(this.grpEmployeeInformation);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employee";
            this.grpEmployeeInformation.ResumeLayout(false);
            this.grpEmployeeInformation.PerformLayout();
            this.grpEmployeeContactDetails.ResumeLayout(false);
            this.grpEmployeeContactDetails.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpMaritalStatus.ResumeLayout(false);
            this.grpMaritalStatus.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtNationalInsID;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.CheckBox ckbIsMember;
    }
}


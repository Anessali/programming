namespace Ch11EmployeeClass
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdBtnPT = new System.Windows.Forms.RadioButton();
            this.rdBtnFT = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSsn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateHired = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpTax = new System.Windows.Forms.TextBox();
            this.chkBxManagement = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(143, 41);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(193, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(143, 92);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(193, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(220, 212);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(116, 72);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Enabled = false;
            this.txtEmpSalary.Location = new System.Drawing.Point(492, 210);
            this.txtEmpSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.ReadOnly = true;
            this.txtEmpSalary.Size = new System.Drawing.Size(164, 26);
            this.txtEmpSalary.TabIndex = 5;
            this.txtEmpSalary.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pay(hourly/salary):";
            // 
            // rdBtnPT
            // 
            this.rdBtnPT.AutoSize = true;
            this.rdBtnPT.Location = new System.Drawing.Point(90, 212);
            this.rdBtnPT.Name = "rdBtnPT";
            this.rdBtnPT.Size = new System.Drawing.Size(94, 24);
            this.rdBtnPT.TabIndex = 7;
            this.rdBtnPT.TabStop = true;
            this.rdBtnPT.Text = "Part Time";
            this.rdBtnPT.UseVisualStyleBackColor = true;
            // 
            // rdBtnFT
            // 
            this.rdBtnFT.AutoSize = true;
            this.rdBtnFT.Location = new System.Drawing.Point(90, 253);
            this.rdBtnFT.Name = "rdBtnFT";
            this.rdBtnFT.Size = new System.Drawing.Size(90, 24);
            this.rdBtnFT.TabIndex = 10;
            this.rdBtnFT.TabStop = true;
            this.rdBtnFT.Text = "Full Time";
            this.rdBtnFT.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 143);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(463, 143);
            this.txtTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(193, 26);
            this.txtTax.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tax Rate";
            // 
            // txtSsn
            // 
            this.txtSsn.Location = new System.Drawing.Point(463, 92);
            this.txtSsn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSsn.Name = "txtSsn";
            this.txtSsn.Size = new System.Drawing.Size(193, 26);
            this.txtSsn.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "SSN";
            // 
            // txtDateHired
            // 
            this.txtDateHired.Location = new System.Drawing.Point(463, 41);
            this.txtDateHired.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateHired.Name = "txtDateHired";
            this.txtDateHired.Size = new System.Drawing.Size(193, 26);
            this.txtDateHired.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date Hired";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Taxes:";
            // 
            // txtEmpTax
            // 
            this.txtEmpTax.Enabled = false;
            this.txtEmpTax.Location = new System.Drawing.Point(492, 258);
            this.txtEmpTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpTax.Name = "txtEmpTax";
            this.txtEmpTax.ReadOnly = true;
            this.txtEmpTax.Size = new System.Drawing.Size(164, 26);
            this.txtEmpTax.TabIndex = 20;
            this.txtEmpTax.TabStop = false;
            // 
            // chkBxManagement
            // 
            this.chkBxManagement.AutoSize = true;
            this.chkBxManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxManagement.Location = new System.Drawing.Point(107, 283);
            this.chkBxManagement.Name = "chkBxManagement";
            this.chkBxManagement.Size = new System.Drawing.Size(106, 20);
            this.chkBxManagement.TabIndex = 22;
            this.chkBxManagement.Text = "Management";
            this.chkBxManagement.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 307);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bonus:";
            // 
            // txtBonus
            // 
            this.txtBonus.Enabled = false;
            this.txtBonus.Location = new System.Drawing.Point(492, 303);
            this.txtBonus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.ReadOnly = true;
            this.txtBonus.Size = new System.Drawing.Size(164, 26);
            this.txtBonus.TabIndex = 23;
            this.txtBonus.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 353);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.chkBxManagement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpTax);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSsn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDateHired);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdBtnFT);
            this.Controls.Add(this.rdBtnPT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpSalary);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Employee Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdBtnPT;
        private System.Windows.Forms.RadioButton rdBtnFT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSsn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDateHired;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpTax;
        private System.Windows.Forms.CheckBox chkBxManagement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBonus;
    }
}


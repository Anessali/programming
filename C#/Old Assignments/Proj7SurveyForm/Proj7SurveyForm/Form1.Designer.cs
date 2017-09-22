namespace Proj7SurveyForm
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdM = new System.Windows.Forms.RadioButton();
            this.rdF = new System.Windows.Forms.RadioButton();
            this.rdO = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numSatisfaction = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNewsLetter = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSatisfaction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your information";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(133, 68);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.TextChanged += new System.EventHandler(this.txtFirst_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(356, 69);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // rdM
            // 
            this.rdM.AutoSize = true;
            this.rdM.Location = new System.Drawing.Point(133, 143);
            this.rdM.Name = "rdM";
            this.rdM.Size = new System.Drawing.Size(48, 17);
            this.rdM.TabIndex = 5;
            this.rdM.Text = "Male";
            this.rdM.UseVisualStyleBackColor = true;
            // 
            // rdF
            // 
            this.rdF.AutoSize = true;
            this.rdF.Location = new System.Drawing.Point(187, 143);
            this.rdF.Name = "rdF";
            this.rdF.Size = new System.Drawing.Size(59, 17);
            this.rdF.TabIndex = 6;
            this.rdF.Text = "Female";
            this.rdF.UseVisualStyleBackColor = true;
            // 
            // rdO
            // 
            this.rdO.AutoSize = true;
            this.rdO.Checked = true;
            this.rdO.Location = new System.Drawing.Point(252, 143);
            this.rdO.Name = "rdO";
            this.rdO.Size = new System.Drawing.Size(51, 17);
            this.rdO.TabIndex = 7;
            this.rdO.TabStop = true;
            this.rdO.Text = "Other";
            this.rdO.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender:";
            // 
            // numSatisfaction
            // 
            this.numSatisfaction.Location = new System.Drawing.Point(343, 193);
            this.numSatisfaction.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSatisfaction.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSatisfaction.Name = "numSatisfaction";
            this.numSatisfaction.Size = new System.Drawing.Size(120, 20);
            this.numSatisfaction.TabIndex = 9;
            this.numSatisfaction.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 54);
            this.label5.TabIndex = 10;
            this.label5.Text = "How would you rate your satisfaction with the company?";
            // 
            // chkNewsLetter
            // 
            this.chkNewsLetter.Location = new System.Drawing.Point(350, 238);
            this.chkNewsLetter.Name = "chkNewsLetter";
            this.chkNewsLetter.Size = new System.Drawing.Size(106, 56);
            this.chkNewsLetter.TabIndex = 11;
            this.chkNewsLetter.Text = "Check the box if you would like to sign up for our newsletter";
            this.chkNewsLetter.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(69, 172);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(343, 324);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(156, 125);
            this.lblOutput.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(69, 376);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 515);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.chkNewsLetter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSatisfaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdO);
            this.Controls.Add(this.rdF);
            this.Controls.Add(this.rdM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Customer Satisfaction Survey";
            ((System.ComponentModel.ISupportInitialize)(this.numSatisfaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdM;
        private System.Windows.Forms.RadioButton rdF;
        private System.Windows.Forms.RadioButton rdO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSatisfaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNewsLetter;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnSubmit;
    }
}


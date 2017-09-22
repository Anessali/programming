namespace Employee_Form
{
    partial class NewEmployeeForm
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmNew = new System.Windows.Forms.Button();
            this.btnCancelNew = new System.Windows.Forms.Button();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(21, 39);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(132, 22);
            this.txtFirst.TabIndex = 0;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(194, 39);
            this.txtLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(132, 22);
            this.txtLast.TabIndex = 1;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(20, 105);
            this.txtJob.Margin = new System.Windows.Forms.Padding(4);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(132, 22);
            this.txtJob.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Job Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salary";
            // 
            // btnConfirmNew
            // 
            this.btnConfirmNew.Location = new System.Drawing.Point(192, 164);
            this.btnConfirmNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmNew.Name = "btnConfirmNew";
            this.btnConfirmNew.Size = new System.Drawing.Size(100, 47);
            this.btnConfirmNew.TabIndex = 8;
            this.btnConfirmNew.Text = "Confirm";
            this.btnConfirmNew.UseVisualStyleBackColor = true;
            this.btnConfirmNew.Click += new System.EventHandler(this.btnConfirmNew_Click);
            // 
            // btnCancelNew
            // 
            this.btnCancelNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelNew.Location = new System.Drawing.Point(51, 164);
            this.btnCancelNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelNew.Name = "btnCancelNew";
            this.btnCancelNew.Size = new System.Drawing.Size(100, 47);
            this.btnCancelNew.TabIndex = 9;
            this.btnCancelNew.Text = "Cancel";
            this.btnCancelNew.UseVisualStyleBackColor = true;
            // 
            // nudSalary
            // 
            this.nudSalary.DecimalPlaces = 2;
            this.nudSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSalary.Location = new System.Drawing.Point(194, 105);
            this.nudSalary.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(120, 22);
            this.nudSalary.TabIndex = 10;
            this.nudSalary.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 254);
            this.ControlBox = false;
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.btnCancelNew);
            this.Controls.Add(this.btnConfirmNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NewEmployeeForm";
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.NewEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmNew;
        private System.Windows.Forms.Button btnCancelNew;
        private System.Windows.Forms.NumericUpDown nudSalary;
    }
}
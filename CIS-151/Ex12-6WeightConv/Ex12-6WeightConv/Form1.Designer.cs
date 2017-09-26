namespace Ex12_6WeightConv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtTempIn = new System.Windows.Forms.TextBox();
            this.txtTempOut = new System.Windows.Forms.TextBox();
            this.cboBxTwo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBxOne = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTempIn
            // 
            this.txtTempIn.Location = new System.Drawing.Point(140, 100);
            this.txtTempIn.Name = "txtTempIn";
            this.txtTempIn.Size = new System.Drawing.Size(112, 24);
            this.txtTempIn.TabIndex = 1;
            // 
            // txtTempOut
            // 
            this.txtTempOut.Location = new System.Drawing.Point(36, 202);
            this.txtTempOut.Name = "txtTempOut";
            this.txtTempOut.ReadOnly = true;
            this.txtTempOut.Size = new System.Drawing.Size(324, 24);
            this.txtTempOut.TabIndex = 2;
            this.txtTempOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboBxTwo
            // 
            this.cboBxTwo.FormattingEnabled = true;
            this.cboBxTwo.Items.AddRange(new object[] {
            "grams",
            "kilograms",
            "pounds",
            "ounces"});
            this.cboBxTwo.Location = new System.Drawing.Point(239, 43);
            this.cboBxTwo.Name = "cboBxTwo";
            this.cboBxTwo.Size = new System.Drawing.Size(121, 26);
            this.cboBxTwo.TabIndex = 4;
            this.cboBxTwo.Text = "ounces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "To...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboBxOne
            // 
            this.cboBxOne.FormattingEnabled = true;
            this.cboBxOne.Items.AddRange(new object[] {
            "grams",
            "kilograms",
            "pounds",
            "ounces"});
            this.cboBxOne.Location = new System.Drawing.Point(27, 43);
            this.cboBxOne.Name = "cboBxOne";
            this.cboBxOne.Size = new System.Drawing.Size(121, 26);
            this.cboBxOne.TabIndex = 6;
            this.cboBxOne.Text = "grams";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 274);
            this.Controls.Add(this.cboBxOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBxTwo);
            this.Controls.Add(this.txtTempOut);
            this.Controls.Add(this.txtTempIn);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Weight Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTempIn;
        private System.Windows.Forms.TextBox txtTempOut;
        private System.Windows.Forms.ComboBox cboBxTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBxOne;
    }
}


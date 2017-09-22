namespace AnimalTester
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
            this.txtSpecies = new System.Windows.Forms.Label();
            this.txtBxSpecies = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSpecies
            // 
            this.txtSpecies.AutoSize = true;
            this.txtSpecies.Location = new System.Drawing.Point(13, 13);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(59, 20);
            this.txtSpecies.TabIndex = 0;
            this.txtSpecies.Text = "Species";
            // 
            // txtBxSpecies
            // 
            this.txtBxSpecies.Location = new System.Drawing.Point(79, 12);
            this.txtBxSpecies.Name = "txtBxSpecies";
            this.txtBxSpecies.Size = new System.Drawing.Size(100, 26);
            this.txtBxSpecies.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(17, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(44, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Name";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(79, 48);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 26);
            this.txtBxName.TabIndex = 3;
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(17, 131);
            this.txtBxResult.Multiline = true;
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(366, 138);
            this.txtBxResult.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(266, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 62);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(406, 356);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBxSpecies);
            this.Controls.Add(this.txtSpecies);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Animal Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSpecies;
        private System.Windows.Forms.TextBox txtBxSpecies;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Button btnOk;
    }
}


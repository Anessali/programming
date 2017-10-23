namespace Ch14_memberDBApp
{
    partial class DBGui
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
            this.lstBxMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBxMembers
            // 
            this.lstBxMembers.FormattingEnabled = true;
            this.lstBxMembers.ItemHeight = 20;
            this.lstBxMembers.Location = new System.Drawing.Point(212, 135);
            this.lstBxMembers.Name = "lstBxMembers";
            this.lstBxMembers.Size = new System.Drawing.Size(213, 124);
            this.lstBxMembers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Members";
            // 
            // btnLoad
            // 
            this.btnLoad.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnLoad.Location = new System.Drawing.Point(271, 282);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 47);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 427);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 3;
            // 
            // DBGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(647, 452);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxMembers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DBGui";
            this.Text = "Accessing Database Records...";
            this.Load += new System.EventHandler(this.DBGui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblMessage;
    }
}


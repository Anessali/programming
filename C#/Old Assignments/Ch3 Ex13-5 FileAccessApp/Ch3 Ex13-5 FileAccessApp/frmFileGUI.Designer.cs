namespace Ch3_Ex13_5_FileAccessApp
{
    partial class frmFileGUI
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
            this.lstBxNames = new System.Windows.Forms.ListBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBxNames
            // 
            this.lstBxNames.FormattingEnabled = true;
            this.lstBxNames.ItemHeight = 16;
            this.lstBxNames.Location = new System.Drawing.Point(134, 86);
            this.lstBxNames.Name = "lstBxNames";
            this.lstBxNames.Size = new System.Drawing.Size(256, 212);
            this.lstBxNames.TabIndex = 0;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(184, 55);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(126, 16);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "Names stored in file";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(29, 544);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 2;
            // 
            // frmFileGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(530, 569);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lstBxNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFileGUI";
            this.Text = "File Access App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFileGUI_FormClosing);
            this.Load += new System.EventHandler(this.frmFileGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxNames;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblMessage;
    }
}


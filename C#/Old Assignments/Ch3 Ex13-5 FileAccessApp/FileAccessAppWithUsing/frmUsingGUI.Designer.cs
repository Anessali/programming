namespace FileAccessAppWithUsing
{
    partial class frmUsingGUI
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.lstBxNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 428);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 5;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(189, 66);
            this.lblHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(126, 16);
            this.lblHead.TabIndex = 4;
            this.lblHead.Text = "Names stored in file";
            // 
            // lstBxNames
            // 
            this.lstBxNames.FormattingEnabled = true;
            this.lstBxNames.ItemHeight = 16;
            this.lstBxNames.Location = new System.Drawing.Point(122, 104);
            this.lstBxNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBxNames.Name = "lstBxNames";
            this.lstBxNames.Size = new System.Drawing.Size(340, 260);
            this.lstBxNames.TabIndex = 3;
            // 
            // frmUsingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(578, 486);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lstBxNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUsingGUI";
            this.Text = "File with using";
            this.Load += new System.EventHandler(this.frmUsingGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.ListBox lstBxNames;
    }
}


namespace Ch13_SayingsApp102
{
    partial class frmSayingsGUI
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
            this.txtBxSaying = new System.Windows.Forms.TextBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Favorite Saying";
            // 
            // txtBxSaying
            // 
            this.txtBxSaying.Location = new System.Drawing.Point(47, 98);
            this.txtBxSaying.Multiline = true;
            this.txtBxSaying.Name = "txtBxSaying";
            this.txtBxSaying.Size = new System.Drawing.Size(352, 191);
            this.txtBxSaying.TabIndex = 1;
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStore.Location = new System.Drawing.Point(149, 314);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(145, 37);
            this.btnStore.TabIndex = 2;
            this.btnStore.Text = "Store Saying";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 413);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 3;
            // 
            // frmSayingsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(446, 440);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.txtBxSaying);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSayingsGUI";
            this.Text = "Favorite Sayings Storing App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSayingsGUI_FormClosing);
            this.Load += new System.EventHandler(this.frmSayingsGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxSaying;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Label lblMessage;
    }
}


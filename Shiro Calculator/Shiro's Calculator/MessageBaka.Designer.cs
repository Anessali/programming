namespace Shiro_s_Calculator
{
    partial class MessageBaka
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAwayFromMe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Shiro_s_Calculator.Properties.Resources.Touka_Blushing;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 409);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnAwayFromMe
            // 
            this.btnAwayFromMe.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAwayFromMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAwayFromMe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAwayFromMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAwayFromMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAwayFromMe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAwayFromMe.Location = new System.Drawing.Point(0, 328);
            this.btnAwayFromMe.Name = "btnAwayFromMe";
            this.btnAwayFromMe.Size = new System.Drawing.Size(310, 39);
            this.btnAwayFromMe.TabIndex = 1;
            this.btnAwayFromMe.Text = "Away from me, woman!";
            this.btnAwayFromMe.UseVisualStyleBackColor = false;
            this.btnAwayFromMe.Click += new System.EventHandler(this.btnAwayFromMe_Click);
            // 
            // MessageBaka
            // 
            this.BackgroundImage = global::Shiro_s_Calculator.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnAwayFromMe;
            this.ClientSize = new System.Drawing.Size(310, 409);
            this.Controls.Add(this.btnAwayFromMe);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MessageBaka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Did you just say 69?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAwayFromMe;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
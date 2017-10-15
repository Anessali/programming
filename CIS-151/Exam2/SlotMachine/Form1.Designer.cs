namespace SlotMachine
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
            this.pBx1 = new System.Windows.Forms.PictureBox();
            this.pBx2 = new System.Windows.Forms.PictureBox();
            this.pBx3 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx3)).BeginInit();
            this.SuspendLayout();
            // 
            // pBx1
            // 
            this.pBx1.Location = new System.Drawing.Point(39, 37);
            this.pBx1.Margin = new System.Windows.Forms.Padding(4);
            this.pBx1.Name = "pBx1";
            this.pBx1.Size = new System.Drawing.Size(180, 180);
            this.pBx1.TabIndex = 0;
            this.pBx1.TabStop = false;
            // 
            // pBx2
            // 
            this.pBx2.Location = new System.Drawing.Point(253, 37);
            this.pBx2.Margin = new System.Windows.Forms.Padding(4);
            this.pBx2.Name = "pBx2";
            this.pBx2.Size = new System.Drawing.Size(180, 180);
            this.pBx2.TabIndex = 1;
            this.pBx2.TabStop = false;
            // 
            // pBx3
            // 
            this.pBx3.Location = new System.Drawing.Point(460, 37);
            this.pBx3.Margin = new System.Windows.Forms.Padding(4);
            this.pBx3.Name = "pBx3";
            this.pBx3.Size = new System.Drawing.Size(180, 180);
            this.pBx3.TabIndex = 2;
            this.pBx3.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(382, 317);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(125, 39);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(515, 317);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 39);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCredit
            // 
            this.txtCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.Location = new System.Drawing.Point(515, 256);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(125, 24);
            this.txtCredit.TabIndex = 5;
            this.txtCredit.TextChanged += new System.EventHandler(this.txtCredit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Credit:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pBx3);
            this.Controls.Add(this.pBx2);
            this.Controls.Add(this.pBx1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Slots";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBx1;
        private System.Windows.Forms.PictureBox pBx2;
        private System.Windows.Forms.PictureBox pBx3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label1;
    }
}


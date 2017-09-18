namespace Week02_Petals
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
            this.pictureOne = new System.Windows.Forms.PictureBox();
            this.pictureTwo = new System.Windows.Forms.PictureBox();
            this.pictureThree = new System.Windows.Forms.PictureBox();
            this.pictureFour = new System.Windows.Forms.PictureBox();
            this.pictureFive = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.txtBxGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRolls = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBestRun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFive)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOne
            // 
            this.pictureOne.Image = global::Week02_Petals.Properties.Resources.rose;
            this.pictureOne.Location = new System.Drawing.Point(13, 106);
            this.pictureOne.Name = "pictureOne";
            this.pictureOne.Size = new System.Drawing.Size(133, 114);
            this.pictureOne.TabIndex = 0;
            this.pictureOne.TabStop = false;
            // 
            // pictureTwo
            // 
            this.pictureTwo.Image = global::Week02_Petals.Properties.Resources.rose;
            this.pictureTwo.Location = new System.Drawing.Point(169, 106);
            this.pictureTwo.Name = "pictureTwo";
            this.pictureTwo.Size = new System.Drawing.Size(133, 114);
            this.pictureTwo.TabIndex = 1;
            this.pictureTwo.TabStop = false;
            // 
            // pictureThree
            // 
            this.pictureThree.Image = global::Week02_Petals.Properties.Resources.rose;
            this.pictureThree.Location = new System.Drawing.Point(326, 106);
            this.pictureThree.Name = "pictureThree";
            this.pictureThree.Size = new System.Drawing.Size(133, 114);
            this.pictureThree.TabIndex = 2;
            this.pictureThree.TabStop = false;
            // 
            // pictureFour
            // 
            this.pictureFour.Image = global::Week02_Petals.Properties.Resources.rose;
            this.pictureFour.Location = new System.Drawing.Point(483, 106);
            this.pictureFour.Name = "pictureFour";
            this.pictureFour.Size = new System.Drawing.Size(133, 114);
            this.pictureFour.TabIndex = 3;
            this.pictureFour.TabStop = false;
            // 
            // pictureFive
            // 
            this.pictureFive.Image = global::Week02_Petals.Properties.Resources.rose;
            this.pictureFive.Location = new System.Drawing.Point(639, 106);
            this.pictureFive.Name = "pictureFive";
            this.pictureFive.Size = new System.Drawing.Size(133, 114);
            this.pictureFive.TabIndex = 4;
            this.pictureFive.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(251, 235);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(289, 65);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(251, 339);
            this.txtBxResult.Multiline = true;
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.ReadOnly = true;
            this.txtBxResult.Size = new System.Drawing.Size(289, 26);
            this.txtBxResult.TabIndex = 6;
            // 
            // txtBxGuess
            // 
            this.txtBxGuess.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxGuess.Location = new System.Drawing.Point(251, 307);
            this.txtBxGuess.Name = "txtBxGuess";
            this.txtBxGuess.Size = new System.Drawing.Size(137, 26);
            this.txtBxGuess.TabIndex = 7;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(394, 307);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(146, 26);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "Accept Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your Guess:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(759, 74);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Rolls: ";
            // 
            // lblRolls
            // 
            this.lblRolls.AutoSize = true;
            this.lblRolls.Location = new System.Drawing.Point(655, 235);
            this.lblRolls.Name = "lblRolls";
            this.lblRolls.Size = new System.Drawing.Size(16, 20);
            this.lblRolls.TabIndex = 12;
            this.lblRolls.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Correct:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(655, 257);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(16, 20);
            this.lblCorrect.TabIndex = 14;
            this.lblCorrect.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Best Run:";
            // 
            // lblBestRun
            // 
            this.lblBestRun.AutoSize = true;
            this.lblBestRun.Location = new System.Drawing.Point(655, 280);
            this.lblBestRun.Name = "lblBestRun";
            this.lblBestRun.Size = new System.Drawing.Size(16, 20);
            this.lblBestRun.TabIndex = 16;
            this.lblBestRun.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(787, 381);
            this.Controls.Add(this.lblBestRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRolls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtBxGuess);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pictureFive);
            this.Controls.Add(this.pictureFour);
            this.Controls.Add(this.pictureThree);
            this.Controls.Add(this.pictureTwo);
            this.Controls.Add(this.pictureOne);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Petals Around The Rose";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOne;
        private System.Windows.Forms.PictureBox pictureTwo;
        private System.Windows.Forms.PictureBox pictureThree;
        private System.Windows.Forms.PictureBox pictureFour;
        private System.Windows.Forms.PictureBox pictureFive;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.TextBox txtBxGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRolls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBestRun;
    }
}


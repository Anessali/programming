namespace Hot_and_Cold_Game
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblHighLow = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtOpMessage = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(44, 95);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(132, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "0";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblHighLow
            // 
            this.lblHighLow.AutoSize = true;
            this.lblHighLow.Location = new System.Drawing.Point(40, 137);
            this.lblHighLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighLow.Name = "lblHighLow";
            this.lblHighLow.Size = new System.Drawing.Size(98, 16);
            this.lblHighLow.TabIndex = 1;
            this.lblHighLow.Text = "Enter a number";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(213, 137);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 16);
            this.lblTest.TabIndex = 2;
            // 
            // txtOpMessage
            // 
            this.txtOpMessage.AutoSize = true;
            this.txtOpMessage.Location = new System.Drawing.Point(40, 21);
            this.txtOpMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtOpMessage.Name = "txtOpMessage";
            this.txtOpMessage.Size = new System.Drawing.Size(45, 16);
            this.txtOpMessage.TabIndex = 3;
            this.txtOpMessage.Text = "label1";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Enabled = false;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(204, 95);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(303, 180);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtOpMessage);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblHighLow);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Hot or Cold?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblHighLow;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label txtOpMessage;
        private System.Windows.Forms.Button btnNewGame;
    }
}


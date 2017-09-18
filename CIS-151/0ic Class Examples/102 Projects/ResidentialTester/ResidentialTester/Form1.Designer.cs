namespace ResidentialTester
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxPropValue = new System.Windows.Forms.TextBox();
            this.txtBxPropAddress1 = new System.Windows.Forms.TextBox();
            this.txtBxPropName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPropNo = new System.Windows.Forms.TextBox();
            this.grpResidential = new System.Windows.Forms.GroupBox();
            this.txtBxAcreage = new System.Windows.Forms.TextBox();
            this.txtAcreage = new System.Windows.Forms.Label();
            this.txtLawnCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCommercial = new System.Windows.Forms.GroupBox();
            this.txtSecCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLotCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtBxRent = new System.Windows.Forms.TextBox();
            this.grpResidential.SuspendLayout();
            this.grpCommercial.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Commercial",
            "Residential"});
            this.cboType.Location = new System.Drawing.Point(194, 39);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 24);
            this.cboType.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Property Type";
            // 
            // txtBxPropValue
            // 
            this.txtBxPropValue.Location = new System.Drawing.Point(194, 163);
            this.txtBxPropValue.Name = "txtBxPropValue";
            this.txtBxPropValue.Size = new System.Drawing.Size(94, 22);
            this.txtBxPropValue.TabIndex = 20;
            this.txtBxPropValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxPropAddress1
            // 
            this.txtBxPropAddress1.Location = new System.Drawing.Point(195, 135);
            this.txtBxPropAddress1.Name = "txtBxPropAddress1";
            this.txtBxPropAddress1.Size = new System.Drawing.Size(199, 22);
            this.txtBxPropAddress1.TabIndex = 19;
            // 
            // txtBxPropName
            // 
            this.txtBxPropName.Location = new System.Drawing.Point(195, 103);
            this.txtBxPropName.Name = "txtBxPropName";
            this.txtBxPropName.Size = new System.Drawing.Size(200, 22);
            this.txtBxPropName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Property Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Property Address1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Property Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Property No";
            // 
            // txtBxPropNo
            // 
            this.txtBxPropNo.Location = new System.Drawing.Point(195, 71);
            this.txtBxPropNo.Name = "txtBxPropNo";
            this.txtBxPropNo.Size = new System.Drawing.Size(96, 22);
            this.txtBxPropNo.TabIndex = 13;
            // 
            // grpResidential
            // 
            this.grpResidential.Controls.Add(this.txtBxAcreage);
            this.grpResidential.Controls.Add(this.txtAcreage);
            this.grpResidential.Controls.Add(this.txtLawnCost);
            this.grpResidential.Controls.Add(this.label7);
            this.grpResidential.Controls.Add(this.txtType);
            this.grpResidential.Controls.Add(this.label6);
            this.grpResidential.Location = new System.Drawing.Point(478, 30);
            this.grpResidential.Name = "grpResidential";
            this.grpResidential.Size = new System.Drawing.Size(263, 171);
            this.grpResidential.TabIndex = 23;
            this.grpResidential.TabStop = false;
            this.grpResidential.Text = "Residential";
            this.grpResidential.Visible = false;
            // 
            // txtBxAcreage
            // 
            this.txtBxAcreage.Location = new System.Drawing.Point(92, 98);
            this.txtBxAcreage.Name = "txtBxAcreage";
            this.txtBxAcreage.Size = new System.Drawing.Size(137, 22);
            this.txtBxAcreage.TabIndex = 5;
            // 
            // txtAcreage
            // 
            this.txtAcreage.AutoSize = true;
            this.txtAcreage.Location = new System.Drawing.Point(17, 101);
            this.txtAcreage.Name = "txtAcreage";
            this.txtAcreage.Size = new System.Drawing.Size(60, 16);
            this.txtAcreage.TabIndex = 4;
            this.txtAcreage.Text = "Acreage";
            // 
            // txtLawnCost
            // 
            this.txtLawnCost.Location = new System.Drawing.Point(92, 66);
            this.txtLawnCost.Name = "txtLawnCost";
            this.txtLawnCost.Size = new System.Drawing.Size(137, 22);
            this.txtLawnCost.TabIndex = 3;
            this.txtLawnCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Lawn $";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(92, 36);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(137, 22);
            this.txtType.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Type";
            // 
            // grpCommercial
            // 
            this.grpCommercial.Controls.Add(this.txtSecCost);
            this.grpCommercial.Controls.Add(this.label9);
            this.grpCommercial.Controls.Add(this.txtLotCost);
            this.grpCommercial.Controls.Add(this.label10);
            this.grpCommercial.Location = new System.Drawing.Point(478, 207);
            this.grpCommercial.Name = "grpCommercial";
            this.grpCommercial.Size = new System.Drawing.Size(265, 198);
            this.grpCommercial.TabIndex = 24;
            this.grpCommercial.TabStop = false;
            this.grpCommercial.Text = "Commercial";
            // 
            // txtSecCost
            // 
            this.txtSecCost.Location = new System.Drawing.Point(39, 129);
            this.txtSecCost.Name = "txtSecCost";
            this.txtSecCost.Size = new System.Drawing.Size(137, 22);
            this.txtSecCost.TabIndex = 9;
            this.txtSecCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Security Cost";
            // 
            // txtLotCost
            // 
            this.txtLotCost.Location = new System.Drawing.Point(39, 70);
            this.txtLotCost.Name = "txtLotCost";
            this.txtLotCost.Size = new System.Drawing.Size(137, 22);
            this.txtLotCost.TabIndex = 7;
            this.txtLotCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Parking Lot Cost";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(180, 224);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(146, 75);
            this.btnShow.TabIndex = 25;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtBxRent
            // 
            this.txtBxRent.Location = new System.Drawing.Point(195, 325);
            this.txtBxRent.Name = "txtBxRent";
            this.txtBxRent.Size = new System.Drawing.Size(100, 22);
            this.txtBxRent.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 417);
            this.Controls.Add(this.txtBxRent);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.grpCommercial);
            this.Controls.Add(this.grpResidential);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxPropValue);
            this.Controls.Add(this.txtBxPropAddress1);
            this.Controls.Add(this.txtBxPropName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxPropNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Residential Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpResidential.ResumeLayout(false);
            this.grpResidential.PerformLayout();
            this.grpCommercial.ResumeLayout(false);
            this.grpCommercial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxPropValue;
        private System.Windows.Forms.TextBox txtBxPropAddress1;
        private System.Windows.Forms.TextBox txtBxPropName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPropNo;
        private System.Windows.Forms.GroupBox grpResidential;
        private System.Windows.Forms.TextBox txtBxAcreage;
        private System.Windows.Forms.Label txtAcreage;
        private System.Windows.Forms.TextBox txtLawnCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpCommercial;
        private System.Windows.Forms.TextBox txtSecCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLotCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtBxRent;
    }
}


namespace Proj9PizzaDelivery
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxToppings = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPizza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCrust = new System.Windows.Forms.ComboBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDrinkPrices = new System.Windows.Forms.Label();
            this.numUDSoda = new System.Windows.Forms.NumericUpDown();
            this.numUDLemonade = new System.Windows.Forms.NumericUpDown();
            this.numUDTea = new System.Windows.Forms.NumericUpDown();
            this.cbLemonade = new System.Windows.Forms.ComboBox();
            this.cbSoda = new System.Windows.Forms.ComboBox();
            this.cbTea = new System.Windows.Forms.ComboBox();
            this.chkBxLemonade = new System.Windows.Forms.CheckBox();
            this.chkBxSoda = new System.Windows.Forms.CheckBox();
            this.chkBxTea = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSidesPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboSides = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLemonade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTea)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage1);
            this.tabMenu.Controls.Add(this.tabPage2);
            this.tabMenu.Controls.Add(this.tabPage3);
            this.tabMenu.Controls.Add(this.tabPage4);
            this.tabMenu.Location = new System.Drawing.Point(12, 1);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(385, 261);
            this.tabMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cbxToppings);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblPizza);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboCrust);
            this.tabPage1.Controls.Add(this.comboSize);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Choose Your Pizza";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Choose your topping";
            // 
            // cbxToppings
            // 
            this.cbxToppings.FormattingEnabled = true;
            this.cbxToppings.Items.AddRange(new object[] {
            "Cheese",
            "Sausage",
            "Pepperoni",
            "Bacon",
            "Canadian Bacon",
            "Mushrooms",
            "Black Olives",
            "Green Pepper",
            "Anchovies"});
            this.cbxToppings.Location = new System.Drawing.Point(226, 55);
            this.cbxToppings.Name = "cbxToppings";
            this.cbxToppings.Size = new System.Drawing.Size(121, 21);
            this.cbxToppings.TabIndex = 7;
            this.cbxToppings.Text = "Cheese";
            this.cbxToppings.SelectedIndexChanged += new System.EventHandler(this.cbxToppings_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price:";
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(65, 162);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(35, 13);
            this.lblPizza.TabIndex = 5;
            this.lblPizza.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type of Crust";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose your size";
            // 
            // comboCrust
            // 
            this.comboCrust.FormattingEnabled = true;
            this.comboCrust.Items.AddRange(new object[] {
            "Regular",
            "Thin",
            "Deep Dish",
            "Pan",
            "Cheese-filled"});
            this.comboCrust.Location = new System.Drawing.Point(30, 103);
            this.comboCrust.Name = "comboCrust";
            this.comboCrust.Size = new System.Drawing.Size(121, 21);
            this.comboCrust.TabIndex = 1;
            this.comboCrust.Text = "Regular";
            this.comboCrust.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // comboSize
            // 
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.comboSize.Location = new System.Drawing.Point(30, 55);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(121, 21);
            this.comboSize.TabIndex = 0;
            this.comboSize.Text = "medium";
            this.comboSize.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblDrinkPrices);
            this.tabPage2.Controls.Add(this.numUDSoda);
            this.tabPage2.Controls.Add(this.numUDLemonade);
            this.tabPage2.Controls.Add(this.numUDTea);
            this.tabPage2.Controls.Add(this.cbLemonade);
            this.tabPage2.Controls.Add(this.cbSoda);
            this.tabPage2.Controls.Add(this.cbTea);
            this.tabPage2.Controls.Add(this.chkBxLemonade);
            this.tabPage2.Controls.Add(this.chkBxSoda);
            this.tabPage2.Controls.Add(this.chkBxTea);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(377, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Drinks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your total cost of drinks is: ";
            // 
            // lblDrinkPrices
            // 
            this.lblDrinkPrices.AutoSize = true;
            this.lblDrinkPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkPrices.Location = new System.Drawing.Point(237, 168);
            this.lblDrinkPrices.Name = "lblDrinkPrices";
            this.lblDrinkPrices.Size = new System.Drawing.Size(39, 16);
            this.lblDrinkPrices.TabIndex = 9;
            this.lblDrinkPrices.Text = "$0.00";
            // 
            // numUDSoda
            // 
            this.numUDSoda.InterceptArrowKeys = false;
            this.numUDSoda.Location = new System.Drawing.Point(252, 110);
            this.numUDSoda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDSoda.Name = "numUDSoda";
            this.numUDSoda.Size = new System.Drawing.Size(45, 20);
            this.numUDSoda.TabIndex = 8;
            this.numUDSoda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDSoda.Click += new System.EventHandler(this.chkBxTea_CheckedChanged);
            this.numUDSoda.DoubleClick += new System.EventHandler(this.chkBxTea_CheckedChanged);
            this.numUDSoda.Validated += new System.EventHandler(this.chkBxTea_CheckedChanged);
            // 
            // numUDLemonade
            // 
            this.numUDLemonade.InterceptArrowKeys = false;
            this.numUDLemonade.Location = new System.Drawing.Point(252, 77);
            this.numUDLemonade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDLemonade.Name = "numUDLemonade";
            this.numUDLemonade.Size = new System.Drawing.Size(45, 20);
            this.numUDLemonade.TabIndex = 7;
            this.numUDLemonade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDLemonade.Click += new System.EventHandler(this.chkBxTea_CheckedChanged);
            this.numUDLemonade.DoubleClick += new System.EventHandler(this.chkBxTea_CheckedChanged);
            this.numUDLemonade.Validated += new System.EventHandler(this.chkBxTea_CheckedChanged);
            // 
            // numUDTea
            // 
            this.numUDTea.InterceptArrowKeys = false;
            this.numUDTea.Location = new System.Drawing.Point(252, 45);
            this.numUDTea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDTea.Name = "numUDTea";
            this.numUDTea.Size = new System.Drawing.Size(45, 20);
            this.numUDTea.TabIndex = 6;
            this.numUDTea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDTea.Click += new System.EventHandler(this.chkBxTea_CheckedChanged);
            this.numUDTea.DoubleClick += new System.EventHandler(this.chkBxTea_CheckedChanged);
            this.numUDTea.Validated += new System.EventHandler(this.chkBxTea_CheckedChanged);
            // 
            // cbLemonade
            // 
            this.cbLemonade.FormattingEnabled = true;
            this.cbLemonade.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.cbLemonade.Location = new System.Drawing.Point(110, 77);
            this.cbLemonade.Name = "cbLemonade";
            this.cbLemonade.Size = new System.Drawing.Size(121, 21);
            this.cbLemonade.TabIndex = 5;
            this.cbLemonade.Text = "medium";
            this.cbLemonade.SelectedIndexChanged += new System.EventHandler(this.chkBxTea_CheckedChanged);
            this.cbLemonade.Validated += new System.EventHandler(this.chkBxTea_CheckedChanged);
            // 
            // cbSoda
            // 
            this.cbSoda.FormattingEnabled = true;
            this.cbSoda.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.cbSoda.Location = new System.Drawing.Point(110, 110);
            this.cbSoda.Name = "cbSoda";
            this.cbSoda.Size = new System.Drawing.Size(121, 21);
            this.cbSoda.TabIndex = 4;
            this.cbSoda.Text = "medium";
            this.cbSoda.SelectedIndexChanged += new System.EventHandler(this.chkBxTea_CheckedChanged);
            // 
            // cbTea
            // 
            this.cbTea.FormattingEnabled = true;
            this.cbTea.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.cbTea.Location = new System.Drawing.Point(110, 45);
            this.cbTea.Name = "cbTea";
            this.cbTea.Size = new System.Drawing.Size(121, 21);
            this.cbTea.TabIndex = 3;
            this.cbTea.Text = "medium";
            this.cbTea.SelectedIndexChanged += new System.EventHandler(this.chkBxTea_CheckedChanged);
            this.cbTea.Validated += new System.EventHandler(this.chkBxTea_CheckedChanged);
            // 
            // chkBxLemonade
            // 
            this.chkBxLemonade.AutoSize = true;
            this.chkBxLemonade.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBxLemonade.Location = new System.Drawing.Point(18, 81);
            this.chkBxLemonade.Name = "chkBxLemonade";
            this.chkBxLemonade.Size = new System.Drawing.Size(76, 17);
            this.chkBxLemonade.TabIndex = 2;
            this.chkBxLemonade.Text = "Lemonade";
            this.chkBxLemonade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxLemonade.UseVisualStyleBackColor = true;
            this.chkBxLemonade.CheckedChanged += new System.EventHandler(this.chkBxTea_CheckedChanged);
            // 
            // chkBxSoda
            // 
            this.chkBxSoda.AutoSize = true;
            this.chkBxSoda.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBxSoda.Location = new System.Drawing.Point(43, 114);
            this.chkBxSoda.Name = "chkBxSoda";
            this.chkBxSoda.Size = new System.Drawing.Size(51, 17);
            this.chkBxSoda.TabIndex = 1;
            this.chkBxSoda.Text = "Soda";
            this.chkBxSoda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxSoda.UseVisualStyleBackColor = true;
            this.chkBxSoda.CheckedChanged += new System.EventHandler(this.chkBxTea_CheckedChanged);
            // 
            // chkBxTea
            // 
            this.chkBxTea.AutoSize = true;
            this.chkBxTea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBxTea.Location = new System.Drawing.Point(49, 49);
            this.chkBxTea.Name = "chkBxTea";
            this.chkBxTea.Size = new System.Drawing.Size(45, 17);
            this.chkBxTea.TabIndex = 0;
            this.chkBxTea.Text = "Tea";
            this.chkBxTea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxTea.UseVisualStyleBackColor = true;
            this.chkBxTea.CheckedChanged += new System.EventHandler(this.chkBxTea_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSidesPrice);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.comboSides);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(377, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sides";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblSidesPrice
            // 
            this.lblSidesPrice.AutoSize = true;
            this.lblSidesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidesPrice.Location = new System.Drawing.Point(191, 143);
            this.lblSidesPrice.Name = "lblSidesPrice";
            this.lblSidesPrice.Size = new System.Drawing.Size(39, 16);
            this.lblSidesPrice.TabIndex = 4;
            this.lblSidesPrice.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Price: ";
            // 
            // comboSides
            // 
            this.comboSides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSides.FormattingEnabled = true;
            this.comboSides.Items.AddRange(new object[] {
            "",
            "Cheese Sticks",
            "Cinnamon Sticks",
            "Salad",
            "Chicken Tenders"});
            this.comboSides.Location = new System.Drawing.Point(123, 82);
            this.comboSides.Name = "comboSides";
            this.comboSides.Size = new System.Drawing.Size(121, 21);
            this.comboSides.TabIndex = 1;
            this.comboSides.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose a side";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtNumber);
            this.tabPage4.Controls.Add(this.txtAddress);
            this.tabPage4.Controls.Add(this.txtName);
            this.tabPage4.Controls.Add(this.submit);
            this.tabPage4.Controls.Add(this.lblTotalPrice);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(377, 235);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Place Order";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Address:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name: ";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(135, 93);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 67);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(140, 174);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(190, 142);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(45, 16);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "label6";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your total comes to:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proj9PizzaDelivery.Properties.Resources.Lucky__Earth_616__04;
            this.pictureBox1.Location = new System.Drawing.Point(226, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 104);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proj9PizzaDelivery.Properties.Resources.Lucky__Earth_616__04;
            this.pictureBox2.Location = new System.Drawing.Point(241, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 104);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 273);
            this.Controls.Add(this.tabMenu);
            this.Name = "Form1";
            this.Text = "Pizza Mutt - Meal Customizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLemonade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTea)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboCrust;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBxLemonade;
        private System.Windows.Forms.CheckBox chkBxSoda;
        private System.Windows.Forms.CheckBox chkBxTea;
        private System.Windows.Forms.NumericUpDown numUDSoda;
        private System.Windows.Forms.NumericUpDown numUDTea;
        private System.Windows.Forms.ComboBox cbLemonade;
        private System.Windows.Forms.ComboBox cbSoda;
        private System.Windows.Forms.ComboBox cbTea;
        private System.Windows.Forms.Label lblDrinkPrices;
        private System.Windows.Forms.NumericUpDown numUDLemonade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboSides;
        private System.Windows.Forms.Label lblSidesPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox cbxToppings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
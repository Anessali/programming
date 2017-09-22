using System;
using System.Windows.Forms;

/*
    Name:   TJ
    Date:   4/16/2017
                        */

namespace HardwareStore
{
    public partial class Form1 : Form
    {
        //global variables
        decimal itemPrice;
        decimal tax = 0.075m;
        Hardware[] hardwareItems = new Hardware[5];
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try{ 
                if (txtQty.Text != "" && 
                    Convert.ToInt32(txtQty.Text) <= hardwareItems[ProductBox.SelectedIndex].Qty)
                {
                    //adds items
                    for (int i = 0; i < Convert.ToInt32(txtQty.Text); i++) {
                        hardwareItems[ProductBox.SelectedIndex].Qty //this code subtracts from quantity
                            = hardwareItems[ProductBox.SelectedIndex].Qty - 1;
                        itemPrice = itemPrice + hardwareItems[ProductBox.SelectedIndex].Price; //calculates price
                        ReceiptBox.Items.Add(ProductBox.SelectedItem); //to add selected item to ReceiptBox
                        #region removed due to bug - it was supposed to remove item when quantity hits 0
                        //if (hardwareItems[ProductBox.SelectedIndex].Qty == 0) //removes item when quantity hits 0
                        //{
                        //    ProductBox.Items.RemoveAt(ProductBox.SelectedIndex);
                        //}
                        #endregion
                    }
                }
                else if (Convert.ToInt32(txtQty.Text) > hardwareItems[ProductBox.SelectedIndex].Qty) {
                    MessageBox.Show("I'm sorry, but we do not have that many available. " + 
                        "We have " + hardwareItems[ProductBox.SelectedIndex].Qty.ToString() 
                        + " of that item remaining.");
                }
            }
            catch
            {
                MessageBox.Show("Please add a valid number of items", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//allows adding selected items to ReceiptBox
        private void btnReset_Click(object sender, EventArgs e)
        {
            ReceiptBox.Items.Clear();
            ProductBox.Items.Clear();
            itemPrice = 0;
            GenerateListBox();
            CalcOutput();
        }//resets the form
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateListBox();
            CalcOutput();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalcOutput();
        }
        public void GenerateListBox()
        {
            //declare items in arrays
            hardwareItems[0] = new Hardware(1010, "Hammer", 10, 14.99m);
            hardwareItems[1] = new Hardware(1056, "Bag of Nails", 90, 19.99m);
            hardwareItems[2] = new Hardware(2001, "Saw", 5, 29.99m);
            hardwareItems[3] = new Hardware(2005, "Chainsaw", 2, 69.99m);
            hardwareItems[4] = new Hardware(3090, "Ladder", 4, 109.99m);
            //add
            for (int i = 0; i < 5; i++)
            {
                ProductBox.Items.Add(hardwareItems[i]);
            }
        }//Creates arrays stored in ProductBox
        public void CalcOutput()
        {
            lblSub.Text = itemPrice.ToString("C"); //subtotal
            lblTax.Text = (itemPrice * tax).ToString("C"); //tax
            lblTotal.Text = ((itemPrice * tax) + itemPrice).ToString("C"); //total
        }//calculates prices
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                decimal change = Convert.ToDecimal(txtCalcChange.Text) -
                    ((itemPrice * tax) + itemPrice); //calculates change
                MessageBox.Show("Change Due: " + change.ToString("C"));
            }
            catch
            {
                MessageBox.Show("Please enter a valid number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//generates owned change
    }
}
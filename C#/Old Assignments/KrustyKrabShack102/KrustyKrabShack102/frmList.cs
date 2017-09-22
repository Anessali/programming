using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace KrustyKrabShack102
{
    public partial class frmList : Form
    {
        // Instance variables (global)
        Krusty[] kItems = new Krusty[25];
        Krusty[] kCart = new Krusty[25];
        int fileIndex = 0;      // count of records

        int lastCartItem = 0;
        decimal totalAmtDue;
        // the current file name
        string currentFileName = "kItems.txt";
        public frmList()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            // allocate our stream reader
            StreamReader kInFile = new StreamReader(currentFileName);
            try
            {
                // read the first line from our file
                string kInItem = kInFile.ReadLine();
                while (kInItem != null)
                {
                    // call our method to process a record
                    ProcessInputLine(kInItem, fileIndex);

                    // read another line from our input file
                    kInItem = kInFile.ReadLine();

                    // add to our record number
                    fileIndex++;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            finally
            {
                kInFile.Close();
            }
        }
        private void ProcessInputLine(string kInItem, int kIndex)
        {
            // split the line into our fields
            string[] fields = kInItem.Split(',');
            // get each field from the split array
            // convert as necessary
            int itemNo = Convert.ToInt32(fields[0]);
            string prodName = fields[1];
            int qty = Convert.ToInt32(fields[2]);
            decimal price = Convert.ToDecimal(fields[3]);
            // create a Krusty inventory object with the data
            kItems[kIndex] = new Krusty(itemNo, prodName, qty, price);
            // add the Krusty inventory object to the list box on our form
            lstBxInventory.Items.Add(kItems[kIndex]);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lstBxInventory.SelectedIndex;
                int numWanted = Convert.ToInt32(txtBxNum.Text);
                if (kItems[index].Qty < numWanted)
                    MessageBox.Show("Requested amount not available", "Krusty");
                else
                    UpdateInventory(index, numWanted);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input");
            }
        }
        private void UpdateInventory(int index, int numWanted)
        {
            // declare our variables
            int itemNo;
            string prodName;
            int qty;
            decimal price;

            // update the quantity of the inventory item
            kItems[index].Qty = kItems[index].Qty - numWanted;
            // get the data from the inventory item
            itemNo = kItems[index].ItemNo;
            prodName = kItems[index].ProdName;
            price = kItems[index].Price;

            for (int i = 0; i < numWanted; i++)
            {
                kCart[lastCartItem] = new Krusty(itemNo,
                    prodName, 1, price);
                lstBxCart.Items.Add(kCart[lastCartItem]);

                // update item number for next item
                lastCartItem++;
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal temp;
            temp = Krusty.CalculateSubTotal(kCart);
            lblSubtotal.Text = temp.ToString("C");

            temp = Krusty.CalculateTax(kCart);
            lblTax.Text = temp.ToString("C");

            totalAmtDue = Krusty.CalculateTotal(kCart);
            lblTotal.Text = totalAmtDue.ToString("C");
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amtGiven = Convert.ToDecimal(txtBxAmtGiven.Text);
                decimal changeDue = amtGiven - totalAmtDue;
                string msg = string.Format("Change due = {0:C}",
                    changeDue);
                MessageBox.Show(msg, "Krusty");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }
        /// <summary>
        /// Display the sub form to allow add of an item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddInv_Click(object sender, EventArgs e)
        {
            Krusty emptyOne = new Krusty();
            formProperties subForm = new formProperties(ref emptyOne);
            subForm.ShowDialog();
            //we return from the subform
            if (emptyOne.ProdName != null)
            {
                // create a Krusty inventory object with the data
                kItems[fileIndex] = emptyOne;
                // add the Krusty inventory object to the list box on our form
                lstBxInventory.Items.Add(kItems[fileIndex]);
                fileIndex++;
                lblMessage.Text = "Krusty item added!";
            }
            else
            {
                lblMessage.Text = "Krusty add cancelled";
            }
        }
        /// <summary>
        /// Update an inventory item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstBxInventory.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item", "Krusty");
            }
            else
            {
                //save the index of the selected item
                int thisListItem = lstBxInventory.SelectedIndex;
                //create an instance of a Krusty with this item
                Krusty thisKrusty = kItems[thisListItem];

                //create an instance of the Properties form
                //pass in the Krusty by reference
                formProperties subForm = new formProperties(ref thisKrusty);
                subForm.ShowDialog();

                //update the Krusty array and list box with the new values
                kItems[thisListItem] = thisKrusty;
                lstBxInventory.Items[thisListItem] = thisKrusty;
                lblMessage.Text = "Inventory item updated";
            }
        }
        private void lstBxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this event uses the update button event
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBxInventory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to delete", "Krusty");
            }
            else
            {
                //save the index of the selected item
                int thisListItem = lstBxInventory.SelectedIndex;
                //verify the delete with a messagebox
                DialogResult dr = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //remove from inventory listbox
                    lstBxInventory.Items.RemoveAt(thisListItem);
                    kItems = RemoveFromArray(kItems, thisListItem);
                    lblMessage.Text = "Inventory Deleted";
                }
                else
                {
                    lblMessage.Text = "Deletion cancelled";
                }
            }
        }//deletes an item from our list and array
        private Krusty[] RemoveFromArray(Krusty[] theItems, int removeAt)
        {
            //allocate a temp array
            Krusty[] tempArray = new Krusty[theItems.Length - 1];
            //set up our index
            int i = 0; //use for our theItems array
            int j = 0; //use for new temp array

            while (i < theItems.Length)
            {
                if (i != removeAt) //keep this one
                {
                    tempArray[j] = theItems[i];
                    j++;
                }  //end of if
                i++;
            }  //end of while
            return tempArray;
        }
        private void frmList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //allocate our stream writer
            StreamWriter kOutFile = new StreamWriter(currentFileName);
            try
            {
                foreach(Krusty item in kItems)
                {
                    //int itemNo = item.ItemNo
                    if (item is Krusty)
                    {
                        kOutFile.WriteLine(
                            item.ItemNo + "," +
                            item.ProdName + "," +
                            item.Qty + "," +
                            item.Price);
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            finally
            {
                kOutFile.Close();
            }
        }
    }
}

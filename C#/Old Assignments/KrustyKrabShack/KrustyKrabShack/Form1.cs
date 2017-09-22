using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace KrustyKrabShack
{
    public partial class Form1 : Form
    {
        //instance variables - global
        Krusty[] kItems = new Krusty [25];
        Krusty[] kCart = new Krusty[25];

        int lastCartItem = 0;
        decimal totalAmtDue;
        //the current file name
        string currentFileName = "../../kItems.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int fileIndex = 0;      //count of records
            //allocate our stream reader
            StreamReader kInFile = new StreamReader(currentFileName);
            try
            {
                //read the first line from our file
                string kInItem = kInFile.ReadLine();
                while (kInItem != null)
                {
                    //call our method to process a record
                    ProcessInputLine(kInItem, fileIndex);

                    //read another line from out input file
                    kInItem = kInFile.ReadLine();

                    //add to our record number
                    fileIndex++;
                }


                ////put class data into the array entries
                //kItems[0] = new Krusty(1010, "Tasty Crab", 15, 24.99m);
                //kItems[1] = new Krusty(1020, "Lobster", 16, 35.99m);
                ////add the array items to our listbox
                //lstBxInventory.Items.Add(kItems[0]);
                //lstBxInventory.Items.Add(kItems[1]);
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
            //split the line into our fields
            string[] fields = kInItem.Split(',');
            //get each field from the split array
            //convert as necessary
            int itemNo = Convert.ToInt32(fields[0]);
            string prodName = fields[1];
            int qty = Convert.ToInt32(fields[2]);
            decimal price = Convert.ToDecimal(fields[3]);
            //create a Krusty inventory object with the data
            kItems[kIndex] = new Krusty(itemNo, prodName, qty, price);
            //add the Krusty inventory object to the list box on our form
            lstBxInventory.Items.Add(kItems[kIndex]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lstBxInventory.SelectedIndex;
                int numWanted = Convert.ToInt32(txtNum.Text);
                if (kItems[index].Qty < numWanted)
                {
                    MessageBox.Show("Requested amount not available", "Krusty");
                }
                else
                {
                    UpdateInventory(index, numWanted);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input");
            }
        }//btnAdd
        private void UpdateInventory(int index, int numWanted)
        {
            //declare our variables
            int itemNo,
                qty;
            string prodName;
            decimal price;
            //update the quantity of the inventory item
            kItems[index].Qty = kItems[index].Qty - numWanted;
            itemNo = kItems[index].ItemNo;
            prodName = kItems[index].ProdName;
            price = kItems[index].Price;

            for (int i = 0; i < numWanted; i++)
            {
                kCart[lastCartItem] = new Krusty(itemNo, prodName,
                    1, price);
                lstBxCart.Items.Add(kCart[lastCartItem]);

                //update item number for next item
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

        private void btChange_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amtGiven = Convert.ToDecimal(txtChange.Text);
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
    }
}
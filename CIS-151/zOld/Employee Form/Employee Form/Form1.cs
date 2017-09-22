using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Employee_Form
{
    public partial class Form1 : Form
    {
        //global variables
        string lastFileLocation; //this variable stores locaton of last used file
        Employee[] eObjects = new Employee[30];
        int eIndex = 0; //counts
        public Form1()
        {
            InitializeComponent();
        }
        #region called methods - contains most of the code
        private void ErrorBox()
        {
            MessageBox.Show("Unexpected error. Please contact developer.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } //unexpected error message
        //private void GetLine()
        //{

        //}//retrieve line number
        #region file load methods
        private void FileLoad()
        {
            //shows dialog box
            openDialog.ShowDialog();
            try
            {
                //allocates the stream reader
                StreamReader openFile = new StreamReader(openDialog.FileName);
                lastFileLocation = openDialog.FileName;
                string itemVar = openFile.ReadLine(); //sets itemVar string to read from openFile
                while (itemVar != null)
                {
                    EmployeeLoad(itemVar, eIndex);
                    itemVar = openFile.ReadLine(); //reads another line from file
                    eIndex++; //advances index
                    lblStatus.Text = "File Loaded";
                }
                openFile.Close();
            }
            catch (FileNotFoundException){}
            catch //displays MessageBox if unexpected error is encountered
            {
                ErrorBox();
            }
        }
        private void EmployeeLoad(string itemVar, int eIndex)
        {
            //splits items
            string[] fields = itemVar.Split(',');
            //set fields and convert if needed
            string lastName = fields[0];
            string firstName = fields[1];
            string dateHired = fields[2];
            int ssn = Convert.ToInt32(fields[3]);
            string email = fields[4];
            decimal tax = Convert.ToDecimal(fields[5]);
            //creates new object with data
            eObjects[eIndex] = new Employee(lastName, firstName, dateHired, ssn, email, tax);
            //adds new Employee to listbox
            lstBxEmployees.Items.Add(eObjects[eIndex]);
        }
        #endregion
        #region save handling
        private void SaveStatusLable()
        {
            lblStatus.Text = "File successfully saved";
        }
        private void SaveFile()
        {
            saveDialog.ShowDialog();
            try
            {
                StreamWriter saveFile = new StreamWriter(saveDialog.FileName);
                lastFileLocation = saveDialog.FileName; //stores saved file location
                //saves everything in listbox in file
                foreach (Employee item in eObjects)
                {
                    if(item is Employee)
                    {
                        saveFile.WriteLine(
                            item.LastName + "," +
                            item.FirstName + "," +
                            item.DateHired + "," +
                            item.Ssn + "," +
                            item.Email + "," +
                            item.TaxRate
                            );
                    }
                }
                saveFile.Close();
                SaveStatusLable();
            }
            catch (ArgumentException){}
            catch //displays MessageBox if unexpected error is encountered
            {
                ErrorBox();
            }
        }//code responsible for saving via menu
        private void QuickSave()
        {
            //empty file locaton detection
            if (lastFileLocation != null)
            {
                try
                {
                    StreamWriter quickSave = new StreamWriter(lastFileLocation);
                    //saves everything in listbox in file
                    foreach (Employee item in eObjects)
                    {
                        if (item is Employee)
                        {
                            quickSave.WriteLine(
                                item.LastName + "," +
                                item.FirstName + "," +
                                item.DateHired + "," +
                                item.Ssn + "," +
                                item.Email + "," +
                                item.TaxRate
                                );
                        }
                    }
                    quickSave.Close();
                    SaveStatusLable();
                }
                catch //displays MessageBox if unexpected error is encountered
                {
                    ErrorBox();
                }
            }
            //prompts the user to save if no file is detected
            else
            {
                MessageBox.Show("No save file detected", "Invalid Path",
                    MessageBoxButtons.OK , MessageBoxIcon.Information);
                SaveFile();
            }
        }//allows user to quick save to the last file used
        #endregion
        #region deleting items
        private void DeleteItem()
        {
            if(lstBxEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item to delete","Delete", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //saves index of selected item
                int selectedItem = lstBxEmployees.SelectedIndex;
                //needed to use dialog results
                DialogResult choice = MessageBox.Show("Are you sure you wish to delete?", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //item will be removed if user selected yes
                if (choice == DialogResult.Yes)
                {
                    lstBxEmployees.Items.RemoveAt(selectedItem);
                    eObjects = DeleteFromArray(eObjects, selectedItem);
                    lblStatus.Text = "Item Deleted";
                }
                else
                {
                    lblStatus.Text = "Cancelled Deletion";
                }
            }
        }
        private Employee[] DeleteFromArray(Employee[] items, int removeAt)
        {
            //allocate temp array
            Employee[] tempArray = new Employee[items.Length - 1];
            //sets up index
            int x = 0; //for items array
            int y = 0; //for tempArray

            while(x < items.Length)
            {
                if (x != removeAt) //items here kept
                {
                    tempArray[y] = items[x];
                    y++;
                }
                x++;
            }
            return tempArray;
        }
        #endregion
        private void AddNew()
        {
            try
            {
                Employee emptyVar = new Employee();
                NewEmployeeForm newForm = new NewEmployeeForm(ref emptyVar);
                newForm.ShowDialog(); //displays new form
                if (emptyVar.FirstName != null)
                {
                    //creates Employee object with data
                    eObjects[eIndex] = emptyVar;
                    //adds object to the list box
                    lstBxEmployees.Items.Add(eObjects[eIndex]);
                    eIndex++;
                }
            }
            catch //displays MessageBox if unexpected error is encountered
            {
                ErrorBox();
            }
        }//code responsible for adding new item    
        private void ItemProperties()
        {
            if (lstBxEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item", "Properties");
            }
            else
            {
                //get index of selected item
                int itemIndex = lstBxEmployees.SelectedIndex;
                Employee selected = eObjects[itemIndex];

                //generates instance of form with Employee object
                NewEmployeeForm newForm = new NewEmployeeForm(ref selected);
                newForm.ShowDialog();

                //update listbox + array with new values
                eObjects[itemIndex] = selected;
                lstBxEmployees.Items[itemIndex] = selected;
                lblStatus.Text = "Employee updated";
            }
        }
        #endregion
        #region Windows Forms generated methods
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }//links SaveFile
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNew();
        }//links AddNew
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLoad();
        }//links FileLoad
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickSave();
        }//links QuickSave
        private void saveButton_Click(object sender, EventArgs e)
        {
            QuickSave();
        }//links QuickSave
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }//closes program
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }//links DeleteItem
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }//links DeleteItem
        private void lstBxEmployees_DoubleClick(object sender, EventArgs e)
        {
            ItemProperties();
        }//links ItemProperties
        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemProperties();
        }//links ItemProperties
        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            ItemProperties();
        }//links ItemProperties
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About showWindow = new About();
            showWindow.ShowDialog();
        }//displays About page
        #endregion
    }
}
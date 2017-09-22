using System;
using System.IO;
using System.Windows.Forms;

namespace File_Stream
{
    /// <summary>
    /// Name:   TJ Liggett
    /// Program:File Stream
    /// Date:   4/24/2017
    /// </summary>
    public partial class Form1 : Form
    {
        //creates StreamWriters
        private StreamReader openFile;
        private StreamWriter saveFile;
        //global variables
        string errorMsg = "Error. We have run into a problem";
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            try
            {
                string storage; //variable to store student information
                storage = (txtLast.Text + ", " + txtFirst.Text + "\t\t" + txtID.Text + "\t" 
                    + txtClass.Text + "\t" + txtGrade.Text + "\r\n");
                txtOutput.Text += storage;
                ClearForm();
                if (txtOutput.Text != "")
                {
                    btnSave.Enabled = true;
                }
                lblStatus.Text = "Data entered";
            }

            catch (Exception exc)
            {
                MessageBox.Show(errorMsg);
            }
            finally
            {
                btnEnter.Enabled = false;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                openDialog.ShowDialog();
                openFile = new StreamReader(openDialog.FileName);
                txtOutput.Text = File.ReadAllText(openDialog.FileName);
                openFile.Close();
                lblStatus.Text = "File loaded";
            }
            catch (FileNotFoundException)
            {

            }
        }//load button
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveDialog.ShowDialog();
                saveFile = new StreamWriter(saveDialog.FileName);
                saveFile.WriteLine(txtOutput.Text);
                saveFile.Close();
                lblStatus.Text = "File saved";
            }
            catch (Exception exc)
            {
                MessageBox.Show(errorMsg);
            }
        }//the save button
        public void ClearForm()
        {
            txtLast.Text = "";
            txtFirst.Text = "";
            txtID.Text = "";
            txtClass.Text = "";
            txtGrade.Text = "";
        } //clears the form
        private void txtLast_TextChanged(object sender, EventArgs e)
        {
            if ((txtLast != null) && (txtFirst != null) && (txtGrade != null) 
                && (txtID != null) && (txtGrade != null))
            {
                btnEnter.Enabled = true;
            }
        }
    }
}

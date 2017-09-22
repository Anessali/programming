using System;
using System.IO;
using System.Windows.Forms;

namespace Ch_13_Ex_13_10_FileAccessAppDialogs
{
    /// <summary>
    /// Program:    FileAccessAppDialogs
    /// Developer:  Me
    /// Date:       4/24/2017
    /// Purpose:    Use common windows dialogs for Open and Save
    /// </summary>
    public partial class Form1 : Form
    {
        //class level variables
        StreamReader inFile;
        StreamWriter outFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                inFile = new StreamReader(openFileDialog1.FileName);
                lblMessage.Text = "File " + openFileDialog1.FileName;
                inFile.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                string testValue =
                    "This is an example using Dialog boxes";
                outFile = new StreamWriter(saveFileDialog1.FileName);
                outFile.WriteLine(testValue);
                outFile.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace FileAccessAppWithUsing
{
    /// <summary>
    /// Program:    FileAccessAppWithUsing
    /// Developer:  TJ Liggett
    /// Date:       4/24/2017
    /// Purpose:    Place our file access with the Using statement
    /// </summary>
    public partial class frmUsingGUI : Form
    {
        public frmUsingGUI()
        {
            InitializeComponent();
        }

        private void frmUsingGUI_Load(object sender, EventArgs e)
        {
            string inValue; //hold our read record
            try
            {
                using (StreamReader inFile =
                    new StreamReader("../../name.txt"))
                {//begin using
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        this.lstBxNames.Items.Add(inValue);
                    }//end while
                }//end using
            }//end try
            catch (FileNotFoundException exc)
            {
                lblMessage.Text = "File Not Found !\n" +
                    exc.Message;
            }
            catch(Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }
    }
}

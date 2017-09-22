using System;
using System.IO;
using System.Windows.Forms;

namespace Ch3_Ex13_5_FileAccessApp
{
    /// <summary>
    /// Program:    FileAccessApp
    /// Developer:  TJ Liggett
    /// Date:       4/24/2017
    /// Purpose:    Read an input file to display in list box
    /// </summary>
    public partial class frmFileGUI : Form
    {
        //instance level variable declaration
        private StreamReader inFile;    //declares our file stream object

        public frmFileGUI()
        {
            InitializeComponent();
        }

        private void frmFileGUI_Load(object sender, EventArgs e)
        {
            string inValue;     //hold our input line

            if (File.Exists("../../name.txt"))
            {
                try
                {
                    inFile = new StreamReader("../../name.txt");
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        this.lstBxNames.Items.Add(inValue);
                    }//end of while
                }//end of try
                catch (System.IO.IOException exc)
                {
                    lblHead.Text = exc.Message;
                }//end of catch
            }//end of if
            else
            {
                lblHead.Text = "File unavailable";
            }
        }

        private void frmFileGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                inFile.Close();
            }
            catch
            {

            }
        }
    }
}

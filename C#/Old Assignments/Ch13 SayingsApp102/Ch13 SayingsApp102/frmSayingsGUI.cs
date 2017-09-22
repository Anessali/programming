using System;
using System.IO;
using System.Windows.Forms;

namespace Ch13_SayingsApp102
{
    public partial class frmSayingsGUI : Form
    {
        //class (instance) variable - global
        private StreamWriter fil;
        public frmSayingsGUI()
        {
            InitializeComponent();
        }

        private void frmSayingsGUI_Load(object sender, EventArgs e)
        {
            try
            {
                fil = new StreamWriter(@"saying.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                lblMessage.Text = "Invalid directory" + 
                    exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            try
            {
                fil.WriteLine(txtBxSaying.Text);
                txtBxSaying.Text = "";
                txtBxSaying.Focus();
            }
            catch (System.IO.IOException exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void frmSayingsGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
            }
            catch (Exception exc) //catches all exceptions
            {
                lblMessage.Text = exc.Message;
            }
        }
    }
}

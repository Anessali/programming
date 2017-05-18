using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shiro_s_Calculator
{
    public partial class MessageBaka : Form
    {
        //global variables
        private bool touka = false;
        public MessageBaka()
        {
            InitializeComponent();
        }
        #region getters and setters
        public bool Touka
        {
            get
            {
                return touka;
            }
            set
            {
                touka = value;
            }
        }
        #endregion
        public MessageBaka(bool annoyingTouka)
        {
            touka = annoyingTouka;
        }
        private void btnAwayFromMe_Click(object sender, EventArgs e)
        {
            touka = false;
            this.Close();
        }
    }
}

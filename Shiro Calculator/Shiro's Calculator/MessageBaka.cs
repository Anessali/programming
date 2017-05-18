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
        public MessageBaka()
        {
            InitializeComponent();
        }

        private void btnAwayFromMe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

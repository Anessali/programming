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
    public partial class Form1 : Form
    {
        class NoSelectButton : Button
        {
            public NoSelectButton()
            {
                SetStyle(ControlStyles.Selectable, false);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_click(object sender, EventArgs e)
        {
            
        }
    }
}

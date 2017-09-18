using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02_Petals
{
    public partial class Congratulations : Form
    {
        public Congratulations()
        {
            InitializeComponent();
        }

        private void Congratulations_Load(object sender, EventArgs e)
        {
            txtMessage.Text = "I think it's safe to say you've got this, so I'd like to congratulate you" +
                " on becoming a Potentate of the Rose. " + 
                "Be sure to torture your friends with this game.";
        }
    }
}

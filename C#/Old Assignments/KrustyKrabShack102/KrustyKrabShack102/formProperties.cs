using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrustyKrabShack102
{
    public partial class formProperties : Form
    {
        Krusty globalOne;
        public formProperties(ref Krusty thisOne)
        {
            InitializeComponent();
            globalOne = thisOne;

        }

        /// <summary>
        /// The ok button will populate our Krusty object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            globalOne.ItemNo = Convert.ToInt32(txtItemNo.Text);
            globalOne.ProdName = txtProduct.Text;
            globalOne.Qty = Convert.ToInt32(nudQty.Value);
            globalOne.Price = nudPrice.Value;
            this.Close();
        }

        /// <summary>
        /// if cancel is clicked, empty the Krusty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //globalOne.ItemNo = 0;
            //globalOne.ProdName = "";
            //globalOne.Qty = 0;
            //globalOne.Price = 0;
            //this.Close();
        }

        private void formProperties_Load(object sender, EventArgs e)
        {
            txtItemNo.Text = globalOne.ItemNo.ToString();
            txtProduct.Text = globalOne.ProdName;
            nudQty.Value = globalOne.Qty;
            nudPrice.Value = globalOne.Price;

        }
    }
}

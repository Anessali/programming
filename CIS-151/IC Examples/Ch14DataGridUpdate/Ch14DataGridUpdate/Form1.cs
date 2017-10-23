using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Ch14DataGridUpdate
{
    public partial class Form1 : Form
    {
        private OleDbDataAdapter memberDataAdap;
        private DataSet memberDS;
        private OleDbCommandBuilder cBuilder;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConnection;
        private string sql;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source = memberDB.accdb";
            }
            catch
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _10FamilyDB
{
    public partial class Form1 : Form
    {
        //sets up connection
        private OleDbDataAdapter familyData;
        private DataSet familyDS;

        //holds command                         
        private OleDbCommandBuilder familyBuilder;
        private OleDbConnection familyConnection;              
        private OleDbCommand familyCmd;

        //strings to hold data
        private string sConnection;
        private string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //sets up a connection
                sConnection =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=familyDB.accdb;";
                familyConnection = new OleDbConnection(sConnection);

                //this builds a sql statement
                sql = "SELECT * FROM familyTable " +
                        "ORDER BY LastName ASC, FirstName ASC;";

                //creates an instance of familyCmd
                familyCmd = new OleDbCommand();
                familyCmd.CommandText = sql;
                familyCmd.Connection = familyConnection;

                //creates a data adapter
                familyData = new OleDbDataAdapter();
                familyData.SelectCommand = familyCmd;

                //connects data to the data grid
                dGrd.DataSource = familyDS;
                dGrd.DataMember = "familyTable";

                familyConnection.Open();

            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }
    }
}

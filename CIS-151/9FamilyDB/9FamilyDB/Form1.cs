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

namespace _9FamilyDB
{
    public partial class Form1 : Form
    {
        private OleDbConnection dbConnection; //this object will hold our connection info
        private string sConnection;     //Hold our connection information
        private OleDbCommand dbCmd;     //object to hold our SQl command
        private string sql;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                /*Construct an object of the OleDbConnection
                  class to store the connection string
                  representing the type of data provider
                  (database) and the source (actual db)      */

                //google c# connection string for microsoft access

                sConnection =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=memberDB.accdb;";
                dbConnection = new OleDbConnection(sConnection);
                dbConnection.Open();

                //build our sql statement
                sql = "SELECT * FROM membersTable " +
                        "ORDER BY LastName ASC, FirstName ASC;";

                dbCmd = new OleDbCommand();     //creates instance of our cmd
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConnection;
            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }
    }
}

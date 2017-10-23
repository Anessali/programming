using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ch14_memberDBApp
{
    public partial class DBGui : Form
    {
        private OleDbConnection dbConn; //this object will hold our connection info
        private string sConnection;     //Hold our connection information

        private OleDbCommand dbCmd;     //object to hold our SQl command
        private string sql;

        private OleDbDataReader dbReader;
        private Member aMember;

                
        public DBGui()
        {
            InitializeComponent();
        }

        private void DBGui_Load(object sender, EventArgs e)
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
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();
                                                
                //build our sql statement
                sql = "SELECT * FROM memberTable " +
                        "ORDER BY LastName ASC, FirstName ASC;";
                                                                            
                dbCmd = new OleDbCommand();     //creates instance of our cmd
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;
                //create our reader object
                dbReader = dbCmd.ExecuteReader( );
                while (dbReader.Read())
                {
                    aMember = new Member(dbReader["LastName"].ToString(), 
                                        dbReader["FirstName"].ToString());
                    lstBxMembers.Items.Add(aMember);
                }
                dbReader.Close();
                dbConn.Close();
            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }
    }
}

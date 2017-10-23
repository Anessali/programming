using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLMemberDBApp
{
    public partial class DBGui : Form
    {
        private SqlConnection dbConn;   // to hold our connection info
        private string sConnection;     // Hold our connection information

        private SqlCommand dbCmd;     //object to hold our SQl command
        private string sql;

        private SqlDataReader dbReader;
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
                    @"Server = cis-sql.otc.edu\\sql,9191;" +
                    "Database = tl0464984;" + 
                    "Trusted_Connection = True;";
                dbConn = new SqlConnection(sConnection);
                dbConn.Open();
                                                
                //build our sql statement
                sql = "SELECT * FROM memberTable " +
                        "ORDER BY LastName ASC, FirstName ASC;";
                                                                            
                dbCmd = new SqlCommand();     //creates instance of our cmd
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

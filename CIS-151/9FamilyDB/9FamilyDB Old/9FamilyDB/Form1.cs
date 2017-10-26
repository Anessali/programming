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

/* **************************
 * This program pulls data  *
 * from the access database.*
 * Similar to what we did   *
 * in class.                *
 * ************************ */

namespace _9FamilyDB
{
    public partial class Form1 : Form
    {
        //sets up connection
        private OleDbConnection dbConnection;   
        private string sConnection;             
                                                
        //holds command                         
        private OleDbCommand dbCmd;             
        private string sql;                     
                                                
        //sets up reader                        
        private OleDbDataReader familyReader;
        private Family familyObj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sConnection =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=familyDB.accdb;";
                dbConnection = new OleDbConnection(sConnection);
                dbConnection.Open();

                //build our sql statement
                sql = "SELECT * FROM familyTable " +
                        "ORDER BY LastName ASC, FirstName ASC;";

                //instance of cmd is created
                dbCmd = new OleDbCommand();     
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConnection;
                //create reader object
                familyReader = dbCmd.ExecuteReader();
                while (familyReader.Read())
                {
                    familyObj = new Family(familyReader["FirstName"].ToString(),
                        familyReader["LastName"].ToString(),
                        familyReader["Relationship"].ToString(),
                        familyReader["Hometown"].ToString()
                        );
                    lstFamily.Items.Add(familyObj);
                }
                familyReader.Close();
            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }
    }
}

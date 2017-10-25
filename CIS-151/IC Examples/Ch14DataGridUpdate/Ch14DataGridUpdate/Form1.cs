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
                dbConn = new OleDbConnection(sConnection);

                sql = "SELECT * FROM memberTable " + 
                    "ORDER BY LastName, FirstName";

                //create our command object
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                //create a data adapter object
                memberDataAdap = new OleDbDataAdapter();
                memberDataAdap.SelectCommand = dbCmd;

                //create a data set
                memberDS = new DataSet();
                memberDataAdap.Fill(memberDS, "memberTable");

                //connect the data set to the data grid on the form
                dataGridView1.DataSource = memberDS;
                dataGridView1.DataMember = "memberTable";

                dbConn.Open();

                

            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //use the command builder to update the database
            try
            {
                cBuilder = new OleDbCommandBuilder(memberDataAdap);
                memberDataAdap.Update(memberDS, "memberTable");
            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }
    }
}

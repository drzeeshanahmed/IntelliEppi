using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace IntelliEppi
{
    public partial class frmDataCenter : Form
    {


        //Message Notes
        string strMsgCancel = "Do you really want to cancel ?";
        string strMsgSaveFileWithData = "Do you want to save existing data in new file and continue ?";
        string strMsgNoValueExists = "No Value Exists";
        string strNoFileOpened = "No file is in use";
        string strMsgDeleteValue = "Do you really want to delete selected record ?";
        string strMsgAlert = "Alert";
        string strMsgFileInformation = "Please provide file information";
        string strMsgLoadData = "Do you want to load data from Database ?";
        string strMsgInsertData = "Do you want to store data in Database ?";
        string strMsgTruncateDatabase = "Do you really want to remove all data from Database ?";
        string strMsgAddedinDatabase = "Data Matrix Added into Database";

        //Database
        string strDBConString;
        string strServer;
        string strDatabaseName;
        string strUserID;
        string strUserPassword;

        MySqlConnection objDBCon;

        public frmDataCenter()
        {
            InitializeComponent();
        }

        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            try
            {
                loadData_fromDB();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        /* 
        * Method to Insert Data into DB 
        */
        private void truncateDataBase()
        {
            madeDbConnection();
            string strQuery = "TRUNCATE Table metabolitedata"; ;
            MySqlCommand objCommand = new MySqlCommand(strQuery, objDBCon);
            objCommand.ExecuteNonQuery();

            closeDbConnection();
        }

        /* 
        * Method to establish default DB connection
        */
        private bool madeDbConnection()
        {
            try
            {

                strServer = "localhost;";
                strDatabaseName = "intellieppi;";
                strUserID = "root;";
                strUserPassword = "zeeshan;";
                strDBConString = "SERVER=" + strServer + ";" + "DATABASE=" + strDatabaseName + ";" + "UID=" + strUserID + ";" + "PASSWORD=" + strUserPassword + ";";

                objDBCon = new MySqlConnection(strDBConString);
                objDBCon.Open();

                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        /* 
        * Method to close default DB connection
        */
        private bool closeDbConnection()
        {
            try
            {
                objDBCon.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /* 
       * Method to Load Data from DB
       */
        private void loadDBData(string strFileData)
        {
            /* Parsing all string by ',' */
            char[] chrColSplit = { ';' };
            string[] strColParseValues = strFileData.Split(chrColSplit);

            lvDM.Items.Add(strColParseValues[0]);
            for (int mColCount = 1; mColCount < strColParseValues.Length - 1; mColCount++)
            {
                lvDM.Items[lvDM.Items.Count - 1].SubItems.Add(strColParseValues[mColCount]);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                Search_DataMatrix();
                
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
             try
            {
            
                if (e.KeyCode == Keys.Enter)
                {
                    Search_DataMatrix();
                }
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        public void Search_DataMatrix()
        {
             lvDM.Items.Clear();

                if (txt_Search.Text != "")
                {
                    madeDbConnection();

                    string str_Keyword = txt_Search.Text;

                    MySqlCommand objCommand = objDBCon.CreateCommand();
                    MySqlDataReader ObjReader;
                    objCommand.CommandText = "select * from DataMatrix where DM_Experiment = '" + str_Keyword 
                        + "%' OR DM_Researcher LIKE '%" + str_Keyword
                        + "%' OR DM_TubeNumber LIKE '%" + str_Keyword
                        + "%' OR DM_RackNumber LIKE '%" + str_Keyword
                        + "%' OR DM_Position LIKE '%" + str_Keyword
                        + "%' OR DM_Strain LIKE '%" + str_Keyword + "%'";

                    ObjReader = objCommand.ExecuteReader();
                    while (ObjReader.Read())
                    {
                        string str_DB_Data = "";
                        for (int i = 0; i < ObjReader.FieldCount; i++)
                            str_DB_Data += ObjReader.GetValue(i).ToString() + ";";

                        loadDBData(str_DB_Data);
                    }
                    closeDbConnection();
                }
        }

        public void loadData_fromDB()
        {
            lvDM.Items.Clear();

            madeDbConnection();

            MySqlCommand objCommand = objDBCon.CreateCommand();
            MySqlDataReader ObjReader;
            objCommand.CommandText = "select * from DataMatrix";

            ObjReader = objCommand.ExecuteReader();
            while (ObjReader.Read())
            {
                string str_DB_Data = "";
                for (int i = 0; i < ObjReader.FieldCount; i++)
                    str_DB_Data += ObjReader.GetValue(i).ToString() + ";";

                loadDBData(str_DB_Data);
            }
            closeDbConnection();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvDM.Items.Count > 0)
                {
                    string str_id = "NA";

                    for (int i = 0; i < lvDM.SelectedItems.Count; i++)
                    {
                        ListViewItem objLvItem = lvDM.SelectedItems[i];
                        str_id = objLvItem.SubItems[0].Text;
                    }

                    DialogResult objDLR;
                    objDLR = MessageBox.Show(strMsgDeleteValue + " : " + str_id, strMsgAlert, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (objDLR == DialogResult.Yes)
                    {
                        madeDbConnection();
             
                        string strQuery = "Delete from DataMatrix where DM_ID = " + str_id;

                        MySqlCommand objCommand = new MySqlCommand(strQuery, objDBCon);
                        objCommand.ExecuteNonQuery();

                        closeDbConnection();
                    }
                }

                loadData_fromDB();

            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

      
    }
}

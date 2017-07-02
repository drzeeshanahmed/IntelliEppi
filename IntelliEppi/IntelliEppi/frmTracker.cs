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

using DataMatrix.net;

namespace IntelliEppi
{
    public partial class frmTracker : Form
    {
        //Message Notes
        string strMsgCancel = "Do you really want to cancel ?";
        string strMsgSaveFileWithData = "Do you want to save existing data in new file and continue ?";
        string strMsgNoValueExists = "No Value Exists";
        string strNoFileOpened = "No file is in use";
        string strMsgDeleteValue = "Do you really want to delete selected value from list view ?";
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

        public frmTracker()
        {
            InitializeComponent();
        }

        private string DecodeImage(String strImageFileNamePathInUse)
        {
            
            DmtxImageDecoder decoder = new DmtxImageDecoder();
            System.Drawing.Bitmap oBitmap = new System.Drawing.Bitmap(strImageFileNamePathInUse);
            List<string> oList = decoder.DecodeImage(oBitmap);

            StringBuilder sb = new StringBuilder();
            sb.Length = 0;
            foreach (string s in oList)
            {
                sb.Append(s);
            }

            String str_Text = sb.ToString();
            
            return str_Text;
         
        }

        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog.Title = "Select Image File";

                    //Save file name and address
                    String strImageFileNamePathInUse = openFileDialog.FileName;
                    if (strImageFileNamePathInUse != "")
                    {
                        // Load Image in Picture Box
                        pictureBox_Tracker.Image = Image.FromFile(strImageFileNamePathInUse);

                        String str_Decoded_Text = DecodeImage(strImageFileNamePathInUse);
                        lbl_DataMatrix.Text= str_Decoded_Text;

                        string[] arr_str_Split_Decoded_Text = str_Decoded_Text.Split('|');

                        Search_DataMatrix(arr_str_Split_Decoded_Text[0]);

                        txt_Experiment.Text = "";
                        txt_Researcher.Text = "";
                        txt_TubeNo.Text = arr_str_Split_Decoded_Text[0];
                        txt_RackNo.Text = arr_str_Split_Decoded_Text[1];
                        txt_Position.Text = arr_str_Split_Decoded_Text[2];
                        txt_Strain.Text = arr_str_Split_Decoded_Text[3];
                       
                    }
                }


            }
            catch (Exception ObjExp)
            {
                MessageBox.Show(ObjExp.Message);
            }
        }

        public void Search_DataMatrix(string str_Keyword)
        {
            lvDM.Items.Clear();

                madeDbConnection();

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

        private void btn_InsertIntoDB_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult objDLR;
                objDLR = MessageBox.Show(strMsgInsertData, strMsgAlert, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (objDLR == DialogResult.Yes)
                {
                    insertDBData();
                }
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }
        /* 
      * Method to Insert Data into DB 
      */
        private void insertDBData()
        {
            madeDbConnection();

            string str_Experiment = txt_Experiment.Text;
            string str_Researher = txt_Researcher.Text;
            string str_TubeNo = txt_TubeNo.Text;
            string str_RackNo = txt_RackNo.Text;
            string str_Position = txt_Position.Text;
            string str_Strain = txt_Strain.Text;
            string str_DateTime = dtp_Generator.Value.ToString("yyyy-MM-dd HH:mm:ss");

            string strQuery = "INSERT INTO DataMatrix(DM_Experiment, DM_Researcher, DM_TubeNumber, DM_RackNumber, DM_Position, DM_Strain, DM_DateTime)" +
                                        "VALUES('" + str_Experiment + "', '" + str_Researher + "', '" + str_TubeNo + "', '" + str_RackNo + "', '" + str_Position + "', '" + str_Strain + "', '" + str_DateTime + "')";

            MySqlCommand objCommand = new MySqlCommand(strQuery, objDBCon);
            objCommand.ExecuteNonQuery();

            closeDbConnection();

            MessageBox.Show(strMsgAddedinDatabase);
        }
    }
}

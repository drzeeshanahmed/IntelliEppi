using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

using DataMatrix.net;

namespace IntelliEppi
{
    public partial class frmGenerator : Form
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

        public frmGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str_Experiment = txt_Experiment.Text;
                string str_Researher = txt_Researcher.Text;
                string str_TubeNo = txt_TubeNo.Text;
                string str_RackNo = txt_RackNo.Text;
                string str_Position = txt_Position.Text;
                string str_Strain = txt_Strain.Text;
                string str_DateTime = dtp_Generator.Value.ToString();

                string str_Encode_Text = str_TubeNo + "|" +
                                          str_RackNo + "|" +
                                          str_Position + "|" +
                                          str_Strain + "|" +
                                          str_DateTime;

                DmtxImageEncoder encoder = new DmtxImageEncoder();
                DmtxImageEncoderOptions options = new DmtxImageEncoderOptions();
                options.ModuleSize = 8;
                options.MarginSize = 4;
                options.BackColor = Color.White;
                options.ForeColor = Color.Green;
                Bitmap encodedBitmap = encoder.EncodeImage(str_Encode_Text);
              
                //encodedBitmap.Save(fileName, ImageFormat.Png);

                SaveFileDialog objSaveFileDialog = new SaveFileDialog();
                objSaveFileDialog.Filter = "Image File|*.png";
                objSaveFileDialog.Title = "Save Generated Data Matrix";

                if (objSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    encodedBitmap.Save(objSaveFileDialog.FileName, ImageFormat.Png);
                    pictureBox_Generator.Image = Image.FromFile(objSaveFileDialog.FileName);
                    lbl_DocumentName.Text = objSaveFileDialog.FileName;

                }

            }
            catch (Exception ObjExp)
            {
                MessageBox.Show(ObjExp.Message);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
                myPrintDocument1.DocumentName = lbl_DocumentName.Text;
                printDialog.Document = myPrintDocument1;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
         
                    myPrintDocument1.Print();
                }
            }
            catch (Exception ObjExp)
            {
                MessageBox.Show(ObjExp.Message);
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

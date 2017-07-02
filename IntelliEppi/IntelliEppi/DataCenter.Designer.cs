namespace IntelliEppi
{
    partial class frmDataCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataCenter));
            this.lvDM = new System.Windows.Forms.ListView();
            this.columnHeader_DM_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_Experiment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_Researcher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_TubeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_RackNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_Strain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDM
            // 
            this.lvDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_DM_ID,
            this.columnHeader_DM_Experiment,
            this.columnHeader_DM_Researcher,
            this.columnHeader_DM_TubeNumber,
            this.columnHeader_DM_RackNumber,
            this.columnHeader_DM_Position,
            this.columnHeader_DM_Strain,
            this.columnHeader_DM_DateTime});
            this.lvDM.FullRowSelect = true;
            this.lvDM.GridLines = true;
            this.lvDM.Location = new System.Drawing.Point(7, 12);
            this.lvDM.Name = "lvDM";
            this.lvDM.Size = new System.Drawing.Size(752, 345);
            this.lvDM.TabIndex = 0;
            this.lvDM.UseCompatibleStateImageBehavior = false;
            this.lvDM.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_DM_ID
            // 
            this.columnHeader_DM_ID.Text = "ID";
            // 
            // columnHeader_DM_Experiment
            // 
            this.columnHeader_DM_Experiment.Text = "Experiment";
            this.columnHeader_DM_Experiment.Width = 100;
            // 
            // columnHeader_DM_Researcher
            // 
            this.columnHeader_DM_Researcher.Text = "Researcher";
            this.columnHeader_DM_Researcher.Width = 100;
            // 
            // columnHeader_DM_TubeNumber
            // 
            this.columnHeader_DM_TubeNumber.Text = "Tube Number";
            this.columnHeader_DM_TubeNumber.Width = 100;
            // 
            // columnHeader_DM_RackNumber
            // 
            this.columnHeader_DM_RackNumber.Text = "Rack Number";
            this.columnHeader_DM_RackNumber.Width = 100;
            // 
            // columnHeader_DM_Position
            // 
            this.columnHeader_DM_Position.Text = "Position";
            this.columnHeader_DM_Position.Width = 100;
            // 
            // columnHeader_DM_Strain
            // 
            this.columnHeader_DM_Strain.Text = "Strain";
            this.columnHeader_DM_Strain.Width = 100;
            // 
            // columnHeader_DM_DateTime
            // 
            this.columnHeader_DM_DateTime.Text = "DateTime";
            this.columnHeader_DM_DateTime.Width = 100;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(88, 363);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(671, 20);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::IntelliEppi.Properties.Resources.Actions_edit_delete_icon;
            this.btn_delete.Location = new System.Drawing.Point(603, 389);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 45);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Image = global::IntelliEppi.Properties.Resources.Zoom_icon;
            this.btn_Search.Location = new System.Drawing.Point(684, 389);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 45);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.Image = global::IntelliEppi.Properties.Resources.Misc_Database_3_icon;
            this.btnConnectDB.Location = new System.Drawing.Point(7, 363);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(75, 71);
            this.btnConnectDB.TabIndex = 1;
            this.btnConnectDB.UseVisualStyleBackColor = true;
            this.btnConnectDB.Click += new System.EventHandler(this.btnConnectDB_Click);
            // 
            // frmDataCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 446);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btnConnectDB);
            this.Controls.Add(this.lvDM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDataCenter";
            this.Text = "DataCenter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDM;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_TubeNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_RackNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_Position;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_Strain;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_DateTime;
        private System.Windows.Forms.Button btnConnectDB;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_Experiment;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_Researcher;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_delete;
    }
}
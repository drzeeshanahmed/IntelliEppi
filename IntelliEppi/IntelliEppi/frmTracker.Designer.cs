namespace IntelliEppi
{
    partial class frmTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTracker));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_DataMatrix = new System.Windows.Forms.Label();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.pictureBox_Tracker = new System.Windows.Forms.PictureBox();
            this.lvDM = new System.Windows.Forms.ListView();
            this.columnHeader_DM_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_Experiment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_Researcher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_TubeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_RackNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_Strain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DM_DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_InsertIntoDB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Researcher = new System.Windows.Forms.TextBox();
            this.txt_Experiment = new System.Windows.Forms.TextBox();
            this.dtp_Generator = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Strain = new System.Windows.Forms.TextBox();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.txt_RackNo = new System.Windows.Forms.TextBox();
            this.txt_TubeNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tracker)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lbl_DataMatrix
            // 
            this.lbl_DataMatrix.AutoSize = true;
            this.lbl_DataMatrix.Location = new System.Drawing.Point(4, 337);
            this.lbl_DataMatrix.Name = "lbl_DataMatrix";
            this.lbl_DataMatrix.Size = new System.Drawing.Size(16, 13);
            this.lbl_DataMatrix.TabIndex = 3;
            this.lbl_DataMatrix.Text = "...";
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Image = global::IntelliEppi.Properties.Resources.Intellippi_Logo_Small;
            this.btn_LoadImage.Location = new System.Drawing.Point(7, 360);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(100, 99);
            this.btn_LoadImage.TabIndex = 1;
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // pictureBox_Tracker
            // 
            this.pictureBox_Tracker.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_Tracker.Location = new System.Drawing.Point(7, 12);
            this.pictureBox_Tracker.Name = "pictureBox_Tracker";
            this.pictureBox_Tracker.Size = new System.Drawing.Size(324, 322);
            this.pictureBox_Tracker.TabIndex = 0;
            this.pictureBox_Tracker.TabStop = false;
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
            this.lvDM.Location = new System.Drawing.Point(337, 12);
            this.lvDM.Name = "lvDM";
            this.lvDM.Size = new System.Drawing.Size(689, 322);
            this.lvDM.TabIndex = 4;
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
            // btn_InsertIntoDB
            // 
            this.btn_InsertIntoDB.Image = global::IntelliEppi.Properties.Resources.Misc_New_Database_icon;
            this.btn_InsertIntoDB.Location = new System.Drawing.Point(415, 442);
            this.btn_InsertIntoDB.Name = "btn_InsertIntoDB";
            this.btn_InsertIntoDB.Size = new System.Drawing.Size(97, 98);
            this.btn_InsertIntoDB.TabIndex = 18;
            this.btn_InsertIntoDB.UseVisualStyleBackColor = true;
            this.btn_InsertIntoDB.Click += new System.EventHandler(this.btn_InsertIntoDB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Researcher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Experiment";
            // 
            // txt_Researcher
            // 
            this.txt_Researcher.Location = new System.Drawing.Point(207, 386);
            this.txt_Researcher.Name = "txt_Researcher";
            this.txt_Researcher.Size = new System.Drawing.Size(202, 20);
            this.txt_Researcher.TabIndex = 33;
            this.txt_Researcher.Text = "NA";
            // 
            // txt_Experiment
            // 
            this.txt_Experiment.Location = new System.Drawing.Point(207, 360);
            this.txt_Experiment.Name = "txt_Experiment";
            this.txt_Experiment.Size = new System.Drawing.Size(202, 20);
            this.txt_Experiment.TabIndex = 32;
            this.txt_Experiment.Text = "NA";
            // 
            // dtp_Generator
            // 
            this.dtp_Generator.CustomFormat = "";
            this.dtp_Generator.Location = new System.Drawing.Point(207, 521);
            this.dtp_Generator.Name = "dtp_Generator";
            this.dtp_Generator.Size = new System.Drawing.Size(202, 20);
            this.dtp_Generator.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "DateTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Strain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Smart Rack No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Smart Tube No.";
            // 
            // txt_Strain
            // 
            this.txt_Strain.Location = new System.Drawing.Point(207, 494);
            this.txt_Strain.Name = "txt_Strain";
            this.txt_Strain.Size = new System.Drawing.Size(202, 20);
            this.txt_Strain.TabIndex = 25;
            // 
            // txt_Position
            // 
            this.txt_Position.Location = new System.Drawing.Point(207, 468);
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.Size = new System.Drawing.Size(202, 20);
            this.txt_Position.TabIndex = 24;
            // 
            // txt_RackNo
            // 
            this.txt_RackNo.Location = new System.Drawing.Point(207, 442);
            this.txt_RackNo.Name = "txt_RackNo";
            this.txt_RackNo.Size = new System.Drawing.Size(202, 20);
            this.txt_RackNo.TabIndex = 23;
            // 
            // txt_TubeNo
            // 
            this.txt_TubeNo.Location = new System.Drawing.Point(207, 416);
            this.txt_TubeNo.Name = "txt_TubeNo";
            this.txt_TubeNo.Size = new System.Drawing.Size(202, 20);
            this.txt_TubeNo.TabIndex = 22;
            // 
            // frmTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 586);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Researcher);
            this.Controls.Add(this.txt_Experiment);
            this.Controls.Add(this.dtp_Generator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Strain);
            this.Controls.Add(this.txt_Position);
            this.Controls.Add(this.txt_RackNo);
            this.Controls.Add(this.txt_TubeNo);
            this.Controls.Add(this.btn_InsertIntoDB);
            this.Controls.Add(this.lvDM);
            this.Controls.Add(this.lbl_DataMatrix);
            this.Controls.Add(this.btn_LoadImage);
            this.Controls.Add(this.pictureBox_Tracker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntelliEppi - Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Tracker;
        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbl_DataMatrix;
        private System.Windows.Forms.ListView lvDM;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_Experiment;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_Researcher;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_TubeNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_RackNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_Position;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_Strain;
        private System.Windows.Forms.ColumnHeader columnHeader_DM_DateTime;
        private System.Windows.Forms.Button btn_InsertIntoDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Researcher;
        private System.Windows.Forms.TextBox txt_Experiment;
        private System.Windows.Forms.DateTimePicker dtp_Generator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Strain;
        private System.Windows.Forms.TextBox txt_Position;
        private System.Windows.Forms.TextBox txt_RackNo;
        private System.Windows.Forms.TextBox txt_TubeNo;
    }
}
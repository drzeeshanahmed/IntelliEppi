namespace IntelliEppi
{
    partial class frmGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerator));
            this.txt_TubeNo = new System.Windows.Forms.TextBox();
            this.txt_RackNo = new System.Windows.Forms.TextBox();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.txt_Strain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.lbl_DocumentName = new System.Windows.Forms.Label();
            this.dtp_Generator = new System.Windows.Forms.DateTimePicker();
            this.btn_InsertIntoDB = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pictureBox_Generator = new System.Windows.Forms.PictureBox();
            this.btn_Encode = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Researcher = new System.Windows.Forms.TextBox();
            this.txt_Experiment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Generator)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TubeNo
            // 
            this.txt_TubeNo.Location = new System.Drawing.Point(92, 68);
            this.txt_TubeNo.Name = "txt_TubeNo";
            this.txt_TubeNo.Size = new System.Drawing.Size(202, 20);
            this.txt_TubeNo.TabIndex = 0;
            this.txt_TubeNo.Text = "ST120";
            // 
            // txt_RackNo
            // 
            this.txt_RackNo.Location = new System.Drawing.Point(92, 94);
            this.txt_RackNo.Name = "txt_RackNo";
            this.txt_RackNo.Size = new System.Drawing.Size(202, 20);
            this.txt_RackNo.TabIndex = 1;
            this.txt_RackNo.Text = "SR56";
            // 
            // txt_Position
            // 
            this.txt_Position.Location = new System.Drawing.Point(92, 120);
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.Size = new System.Drawing.Size(202, 20);
            this.txt_Position.TabIndex = 2;
            this.txt_Position.Text = "D7";
            // 
            // txt_Strain
            // 
            this.txt_Strain.Location = new System.Drawing.Point(92, 146);
            this.txt_Strain.Name = "txt_Strain";
            this.txt_Strain.Size = new System.Drawing.Size(202, 20);
            this.txt_Strain.TabIndex = 3;
            this.txt_Strain.Text = "E. coli JM109 pET21a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Smart Tube No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Smart Rack No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Strain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DateTime";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // lbl_DocumentName
            // 
            this.lbl_DocumentName.AutoSize = true;
            this.lbl_DocumentName.Location = new System.Drawing.Point(2, 322);
            this.lbl_DocumentName.Name = "lbl_DocumentName";
            this.lbl_DocumentName.Size = new System.Drawing.Size(16, 13);
            this.lbl_DocumentName.TabIndex = 15;
            this.lbl_DocumentName.Text = "...";
            // 
            // dtp_Generator
            // 
            this.dtp_Generator.CustomFormat = "";
            this.dtp_Generator.Location = new System.Drawing.Point(92, 173);
            this.dtp_Generator.Name = "dtp_Generator";
            this.dtp_Generator.Size = new System.Drawing.Size(202, 20);
            this.dtp_Generator.TabIndex = 16;
            // 
            // btn_InsertIntoDB
            // 
            this.btn_InsertIntoDB.Image = global::IntelliEppi.Properties.Resources.Misc_New_Database_icon;
            this.btn_InsertIntoDB.Location = new System.Drawing.Point(476, 250);
            this.btn_InsertIntoDB.Name = "btn_InsertIntoDB";
            this.btn_InsertIntoDB.Size = new System.Drawing.Size(97, 79);
            this.btn_InsertIntoDB.TabIndex = 17;
            this.btn_InsertIntoDB.UseVisualStyleBackColor = true;
            this.btn_InsertIntoDB.Click += new System.EventHandler(this.btn_InsertIntoDB_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Image = global::IntelliEppi.Properties.Resources.bubble_jet_printer_icon;
            this.btn_Print.Location = new System.Drawing.Point(100, 210);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(97, 95);
            this.btn_Print.TabIndex = 14;
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // pictureBox_Generator
            // 
            this.pictureBox_Generator.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_Generator.Location = new System.Drawing.Point(300, 7);
            this.pictureBox_Generator.Name = "pictureBox_Generator";
            this.pictureBox_Generator.Size = new System.Drawing.Size(273, 237);
            this.pictureBox_Generator.TabIndex = 13;
            this.pictureBox_Generator.TabStop = false;
            // 
            // btn_Encode
            // 
            this.btn_Encode.Image = global::IntelliEppi.Properties.Resources.Intellippi_Logo_Small;
            this.btn_Encode.Location = new System.Drawing.Point(197, 210);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(97, 95);
            this.btn_Encode.TabIndex = 12;
            this.btn_Encode.UseVisualStyleBackColor = true;
            this.btn_Encode.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Researcher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Experiment";
            // 
            // txt_Researcher
            // 
            this.txt_Researcher.Location = new System.Drawing.Point(92, 38);
            this.txt_Researcher.Name = "txt_Researcher";
            this.txt_Researcher.Size = new System.Drawing.Size(202, 20);
            this.txt_Researcher.TabIndex = 19;
            this.txt_Researcher.Text = "Arthur";
            // 
            // txt_Experiment
            // 
            this.txt_Experiment.Location = new System.Drawing.Point(92, 12);
            this.txt_Experiment.Name = "txt_Experiment";
            this.txt_Experiment.Size = new System.Drawing.Size(202, 20);
            this.txt_Experiment.TabIndex = 18;
            this.txt_Experiment.Text = "ST120 SR56D7 E. coli JM109 pET21a";
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 340);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Researcher);
            this.Controls.Add(this.txt_Experiment);
            this.Controls.Add(this.btn_InsertIntoDB);
            this.Controls.Add(this.dtp_Generator);
            this.Controls.Add(this.lbl_DocumentName);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.pictureBox_Generator);
            this.Controls.Add(this.btn_Encode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Strain);
            this.Controls.Add(this.txt_Position);
            this.Controls.Add(this.txt_RackNo);
            this.Controls.Add(this.txt_TubeNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerator";
            this.Text = "IntelliEppi - Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Generator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TubeNo;
        private System.Windows.Forms.TextBox txt_RackNo;
        private System.Windows.Forms.TextBox txt_Position;
        private System.Windows.Forms.TextBox txt_Strain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Encode;
        private System.Windows.Forms.PictureBox pictureBox_Generator;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Label lbl_DocumentName;
        private System.Windows.Forms.DateTimePicker dtp_Generator;
        private System.Windows.Forms.Button btn_InsertIntoDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Researcher;
        private System.Windows.Forms.TextBox txt_Experiment;
    }
}
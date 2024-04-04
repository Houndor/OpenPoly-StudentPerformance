namespace StudentsPerformance
{
    partial class ReportForm
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
            this.components = new System.ComponentModel.Container();
            this.bMainMenu = new System.Windows.Forms.Button();
            this.bReportExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tOverallLevel = new System.Windows.Forms.TextBox();
            this.tLowestMark = new System.Windows.Forms.TextBox();
            this.tHighestMark = new System.Windows.Forms.TextBox();
            this.tAverage = new System.Windows.Forms.TextBox();
            this.tMarks = new System.Windows.Forms.TextBox();
            this.tLastName = new System.Windows.Forms.TextBox();
            this.tFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentsDataSet = new StudentsPerformance.studentsDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new StudentsPerformance.studentsDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new StudentsPerformance.studentsDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bMainMenu
            // 
            this.bMainMenu.Location = new System.Drawing.Point(305, 320);
            this.bMainMenu.Name = "bMainMenu";
            this.bMainMenu.Size = new System.Drawing.Size(75, 23);
            this.bMainMenu.TabIndex = 3;
            this.bMainMenu.Text = "Main Menu";
            this.bMainMenu.UseVisualStyleBackColor = true;
            this.bMainMenu.Click += new System.EventHandler(this.bMainMenu_Click);
            // 
            // bReportExit
            // 
            this.bReportExit.Location = new System.Drawing.Point(571, 320);
            this.bReportExit.Name = "bReportExit";
            this.bReportExit.Size = new System.Drawing.Size(75, 23);
            this.bReportExit.TabIndex = 4;
            this.bReportExit.Text = "Exit";
            this.bReportExit.UseVisualStyleBackColor = true;
            this.bReportExit.Click += new System.EventHandler(this.bReportExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSearch);
            this.groupBox1.Controls.Add(this.tSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by ID";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(29, 93);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(172, 23);
            this.bSearch.TabIndex = 2;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tSearch
            // 
            this.tSearch.Location = new System.Drawing.Point(113, 38);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(100, 20);
            this.tSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tOverallLevel);
            this.groupBox2.Controls.Add(this.tLowestMark);
            this.groupBox2.Controls.Add(this.tHighestMark);
            this.groupBox2.Controls.Add(this.tAverage);
            this.groupBox2.Controls.Add(this.tMarks);
            this.groupBox2.Controls.Add(this.tLastName);
            this.groupBox2.Controls.Add(this.tFirstName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(324, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 250);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details Found";
            // 
            // tOverallLevel
            // 
            this.tOverallLevel.Location = new System.Drawing.Point(148, 208);
            this.tOverallLevel.Name = "tOverallLevel";
            this.tOverallLevel.ReadOnly = true;
            this.tOverallLevel.Size = new System.Drawing.Size(164, 20);
            this.tOverallLevel.TabIndex = 13;
            // 
            // tLowestMark
            // 
            this.tLowestMark.Location = new System.Drawing.Point(148, 177);
            this.tLowestMark.Name = "tLowestMark";
            this.tLowestMark.ReadOnly = true;
            this.tLowestMark.Size = new System.Drawing.Size(164, 20);
            this.tLowestMark.TabIndex = 12;
            // 
            // tHighestMark
            // 
            this.tHighestMark.Location = new System.Drawing.Point(148, 146);
            this.tHighestMark.Name = "tHighestMark";
            this.tHighestMark.ReadOnly = true;
            this.tHighestMark.Size = new System.Drawing.Size(164, 20);
            this.tHighestMark.TabIndex = 11;
            // 
            // tAverage
            // 
            this.tAverage.Location = new System.Drawing.Point(148, 115);
            this.tAverage.Name = "tAverage";
            this.tAverage.ReadOnly = true;
            this.tAverage.Size = new System.Drawing.Size(164, 20);
            this.tAverage.TabIndex = 10;
            // 
            // tMarks
            // 
            this.tMarks.Location = new System.Drawing.Point(447, 53);
            this.tMarks.Multiline = true;
            this.tMarks.Name = "tMarks";
            this.tMarks.ReadOnly = true;
            this.tMarks.Size = new System.Drawing.Size(164, 175);
            this.tMarks.TabIndex = 9;
            // 
            // tLastName
            // 
            this.tLastName.Location = new System.Drawing.Point(148, 84);
            this.tLastName.Name = "tLastName";
            this.tLastName.ReadOnly = true;
            this.tLastName.Size = new System.Drawing.Size(164, 20);
            this.tLastName.TabIndex = 8;
            // 
            // tFirstName
            // 
            this.tFirstName.Location = new System.Drawing.Point(148, 53);
            this.tFirstName.Name = "tFirstName";
            this.tFirstName.ReadOnly = true;
            this.tFirstName.Size = new System.Drawing.Size(164, 20);
            this.tFirstName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Overall Level:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lowest Mark:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Highest Mark:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Average:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentsPerformance.studentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bReportExit);
            this.Controls.Add(this.bMainMenu);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMainMenu;
        private System.Windows.Forms.Button bReportExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tOverallLevel;
        private System.Windows.Forms.TextBox tLowestMark;
        private System.Windows.Forms.TextBox tHighestMark;
        private System.Windows.Forms.TextBox tAverage;
        private System.Windows.Forms.TextBox tMarks;
        private System.Windows.Forms.TextBox tLastName;
        private System.Windows.Forms.TextBox tFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private studentsDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private studentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
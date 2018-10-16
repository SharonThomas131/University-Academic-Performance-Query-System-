namespace Thomas_Assign3
{
    partial class formNIUPerformanceSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbZid = new System.Windows.Forms.TextBox();
            this.btnGradeReportStu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbThreshold = new System.Windows.Forms.GroupBox();
            this.rbTGreater = new System.Windows.Forms.RadioButton();
            this.rbTless = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbThreshGrade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbThreshCour = new System.Windows.Forms.TextBox();
            this.btnThreshold = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFMajor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFailCour = new System.Windows.Forms.TextBox();
            this.btnStFailed = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGradeReportCour = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.gbFailReport = new System.Windows.Forms.GroupBox();
            this.rbFGreater = new System.Windows.Forms.RadioButton();
            this.rbFLess = new System.Windows.Forms.RadioButton();
            this.nudPercent = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFailResults = new System.Windows.Forms.Button();
            this.btnPassReport = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.gbPassReport = new System.Windows.Forms.GroupBox();
            this.rbPGreater = new System.Windows.Forms.RadioButton();
            this.rbPLess = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbPassGrade = new System.Windows.Forms.ComboBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gbThreshold.SuspendLayout();
            this.gbFailReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).BeginInit();
            this.gbPassReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade Report for One Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z-ID";
            // 
            // tbZid
            // 
            this.tbZid.Location = new System.Drawing.Point(47, 51);
            this.tbZid.Name = "tbZid";
            this.tbZid.Size = new System.Drawing.Size(100, 20);
            this.tbZid.TabIndex = 2;
            // 
            // btnGradeReportStu
            // 
            this.btnGradeReportStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeReportStu.Location = new System.Drawing.Point(383, 48);
            this.btnGradeReportStu.Name = "btnGradeReportStu";
            this.btnGradeReportStu.Size = new System.Drawing.Size(92, 23);
            this.btnGradeReportStu.TabIndex = 3;
            this.btnGradeReportStu.Text = "Show Results";
            this.btnGradeReportStu.UseVisualStyleBackColor = true;
            this.btnGradeReportStu.Click += new System.EventHandler(this.Grade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grade Threshold for One Course ";
            // 
            // gbThreshold
            // 
            this.gbThreshold.Controls.Add(this.rbTGreater);
            this.gbThreshold.Controls.Add(this.rbTless);
            this.gbThreshold.Location = new System.Drawing.Point(16, 112);
            this.gbThreshold.Name = "gbThreshold";
            this.gbThreshold.Size = new System.Drawing.Size(189, 79);
            this.gbThreshold.TabIndex = 5;
            this.gbThreshold.TabStop = false;
            // 
            // rbTGreater
            // 
            this.rbTGreater.AutoSize = true;
            this.rbTGreater.Location = new System.Drawing.Point(3, 41);
            this.rbTGreater.Name = "rbTGreater";
            this.rbTGreater.Size = new System.Drawing.Size(146, 17);
            this.rbTGreater.TabIndex = 1;
            this.rbTGreater.TabStop = true;
            this.rbTGreater.Text = "Greater Than or Equal To";
            this.rbTGreater.UseVisualStyleBackColor = true;
            // 
            // rbTless
            // 
            this.rbTless.AutoSize = true;
            this.rbTless.Location = new System.Drawing.Point(3, 16);
            this.rbTless.Name = "rbTless";
            this.rbTless.Size = new System.Drawing.Size(133, 17);
            this.rbTless.TabIndex = 0;
            this.rbTless.TabStop = true;
            this.rbTless.Text = "Less Than or Equal To";
            this.rbTless.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grade";
            // 
            // cmbThreshGrade
            // 
            this.cmbThreshGrade.FormattingEnabled = true;
            this.cmbThreshGrade.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C++",
            "C",
            "C-",
            "D",
            "F"});
            this.cmbThreshGrade.Location = new System.Drawing.Point(216, 169);
            this.cmbThreshGrade.Name = "cmbThreshGrade";
            this.cmbThreshGrade.Size = new System.Drawing.Size(46, 21);
            this.cmbThreshGrade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Course";
            // 
            // tbThreshCour
            // 
            this.tbThreshCour.Location = new System.Drawing.Point(271, 171);
            this.tbThreshCour.Name = "tbThreshCour";
            this.tbThreshCour.Size = new System.Drawing.Size(100, 20);
            this.tbThreshCour.TabIndex = 9;
            // 
            // btnThreshold
            // 
            this.btnThreshold.Location = new System.Drawing.Point(383, 168);
            this.btnThreshold.Name = "btnThreshold";
            this.btnThreshold.Size = new System.Drawing.Size(92, 23);
            this.btnThreshold.TabIndex = 10;
            this.btnThreshold.Text = "Show Results";
            this.btnThreshold.UseVisualStyleBackColor = true;
            this.btnThreshold.Click += new System.EventHandler(this.btnThreshold_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Major Students Who Failed A Course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Major";
            // 
            // cmbFMajor
            // 
            this.cmbFMajor.FormattingEnabled = true;
            this.cmbFMajor.Items.AddRange(new object[] {
            "Computer Science",
            "Mathematics",
            "Statistics",
            "Theater",
            "Art",
            "Anthropology",
            "Psychology",
            "Marketing",
            "Physics",
            "Finance",
            "Economics",
            "Biological Sciences",
            "Chemistry",
            "Undecided - Any College"});
            this.cmbFMajor.Location = new System.Drawing.Point(16, 278);
            this.cmbFMajor.Name = "cmbFMajor";
            this.cmbFMajor.Size = new System.Drawing.Size(162, 21);
            this.cmbFMajor.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Course";
            // 
            // tbFailCour
            // 
            this.tbFailCour.Location = new System.Drawing.Point(271, 279);
            this.tbFailCour.Name = "tbFailCour";
            this.tbFailCour.Size = new System.Drawing.Size(100, 20);
            this.tbFailCour.TabIndex = 15;
            // 
            // btnStFailed
            // 
            this.btnStFailed.Location = new System.Drawing.Point(383, 277);
            this.btnStFailed.Name = "btnStFailed";
            this.btnStFailed.Size = new System.Drawing.Size(92, 23);
            this.btnStFailed.TabIndex = 16;
            this.btnStFailed.Text = "Show Results";
            this.btnStFailed.UseVisualStyleBackColor = true;
            this.btnStFailed.Click += new System.EventHandler(this.btnStFailed_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Grade Report for One Course";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Course";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 364);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 19;
            // 
            // btnGradeReportCour
            // 
            this.btnGradeReportCour.Location = new System.Drawing.Point(383, 357);
            this.btnGradeReportCour.Name = "btnGradeReportCour";
            this.btnGradeReportCour.Size = new System.Drawing.Size(92, 23);
            this.btnGradeReportCour.TabIndex = 20;
            this.btnGradeReportCour.Text = "Show Results";
            this.btnGradeReportCour.UseVisualStyleBackColor = true;
            this.btnGradeReportCour.Click += new System.EventHandler(this.btnGradeReportCour_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fail Report For All Courses";
            // 
            // gbFailReport
            // 
            this.gbFailReport.Controls.Add(this.rbFGreater);
            this.gbFailReport.Controls.Add(this.rbFLess);
            this.gbFailReport.Location = new System.Drawing.Point(20, 430);
            this.gbFailReport.Name = "gbFailReport";
            this.gbFailReport.Size = new System.Drawing.Size(189, 74);
            this.gbFailReport.TabIndex = 22;
            this.gbFailReport.TabStop = false;
            // 
            // rbFGreater
            // 
            this.rbFGreater.AutoSize = true;
            this.rbFGreater.Location = new System.Drawing.Point(6, 41);
            this.rbFGreater.Name = "rbFGreater";
            this.rbFGreater.Size = new System.Drawing.Size(146, 17);
            this.rbFGreater.TabIndex = 1;
            this.rbFGreater.TabStop = true;
            this.rbFGreater.Text = "Greater Than or Equal To";
            this.rbFGreater.UseVisualStyleBackColor = true;
            // 
            // rbFLess
            // 
            this.rbFLess.AutoSize = true;
            this.rbFLess.Location = new System.Drawing.Point(6, 18);
            this.rbFLess.Name = "rbFLess";
            this.rbFLess.Size = new System.Drawing.Size(133, 17);
            this.rbFLess.TabIndex = 0;
            this.rbFLess.TabStop = true;
            this.rbFLess.Text = "Less Than or Equal To";
            this.rbFLess.UseVisualStyleBackColor = true;
            // 
            // nudPercent
            // 
            this.nudPercent.Location = new System.Drawing.Point(228, 482);
            this.nudPercent.Name = "nudPercent";
            this.nudPercent.Size = new System.Drawing.Size(51, 20);
            this.nudPercent.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Percentage";
            // 
            // btnFailResults
            // 
            this.btnFailResults.Location = new System.Drawing.Point(383, 484);
            this.btnFailResults.Name = "btnFailResults";
            this.btnFailResults.Size = new System.Drawing.Size(92, 23);
            this.btnFailResults.TabIndex = 25;
            this.btnFailResults.Text = "Show Results";
            this.btnFailResults.UseVisualStyleBackColor = true;
            this.btnFailResults.Click += new System.EventHandler(this.btnFailResults_Click);
            // 
            // btnPassReport
            // 
            this.btnPassReport.Location = new System.Drawing.Point(388, 598);
            this.btnPassReport.Name = "btnPassReport";
            this.btnPassReport.Size = new System.Drawing.Size(92, 23);
            this.btnPassReport.TabIndex = 30;
            this.btnPassReport.Text = "Show Results";
            this.btnPassReport.UseVisualStyleBackColor = true;
            this.btnPassReport.Click += new System.EventHandler(this.btnPassReport_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 584);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Grade";
            // 
            // gbPassReport
            // 
            this.gbPassReport.Controls.Add(this.rbPGreater);
            this.gbPassReport.Controls.Add(this.rbPLess);
            this.gbPassReport.Location = new System.Drawing.Point(23, 548);
            this.gbPassReport.Name = "gbPassReport";
            this.gbPassReport.Size = new System.Drawing.Size(189, 74);
            this.gbPassReport.TabIndex = 27;
            this.gbPassReport.TabStop = false;
            // 
            // rbPGreater
            // 
            this.rbPGreater.AutoSize = true;
            this.rbPGreater.Location = new System.Drawing.Point(7, 41);
            this.rbPGreater.Name = "rbPGreater";
            this.rbPGreater.Size = new System.Drawing.Size(146, 17);
            this.rbPGreater.TabIndex = 1;
            this.rbPGreater.TabStop = true;
            this.rbPGreater.Text = "Greater Than or Equal To";
            this.rbPGreater.UseVisualStyleBackColor = true;
            // 
            // rbPLess
            // 
            this.rbPLess.AutoSize = true;
            this.rbPLess.Location = new System.Drawing.Point(6, 18);
            this.rbPLess.Name = "rbPLess";
            this.rbPLess.Size = new System.Drawing.Size(133, 17);
            this.rbPLess.TabIndex = 0;
            this.rbPLess.TabStop = true;
            this.rbPLess.Text = "Less Than or Equal To";
            this.rbPLess.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 528);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Pass Report For All Courses";
            // 
            // cmbPassGrade
            // 
            this.cmbPassGrade.FormattingEnabled = true;
            this.cmbPassGrade.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C++",
            "C",
            "C-",
            "D",
            "F"});
            this.cmbPassGrade.Location = new System.Drawing.Point(233, 598);
            this.cmbPassGrade.Name = "cmbPassGrade";
            this.cmbPassGrade.Size = new System.Drawing.Size(44, 21);
            this.cmbPassGrade.TabIndex = 31;
            // 
            // rtbResults
            // 
            this.rtbResults.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.Location = new System.Drawing.Point(544, 48);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(611, 571);
            this.rtbResults.TabIndex = 32;
            this.rtbResults.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(541, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Query Results";
            // 
            // formNIUPerformanceSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1167, 649);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.cmbPassGrade);
            this.Controls.Add(this.btnPassReport);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbPassReport);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnFailResults);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudPercent);
            this.Controls.Add(this.gbFailReport);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGradeReportCour);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnStFailed);
            this.Controls.Add(this.tbFailCour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbFMajor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThreshold);
            this.Controls.Add(this.tbThreshCour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbThreshGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbThreshold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGradeReportStu);
            this.Controls.Add(this.tbZid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "formNIUPerformanceSystem";
            this.Text = "NIU Academic Performance Query System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbThreshold.ResumeLayout(false);
            this.gbThreshold.PerformLayout();
            this.gbFailReport.ResumeLayout(false);
            this.gbFailReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).EndInit();
            this.gbPassReport.ResumeLayout(false);
            this.gbPassReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZid;
        private System.Windows.Forms.Button btnGradeReportStu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbThreshold;
        private System.Windows.Forms.RadioButton rbTGreater;
        private System.Windows.Forms.RadioButton rbTless;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbThreshGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbThreshCour;
        private System.Windows.Forms.Button btnThreshold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFMajor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFailCour;
        private System.Windows.Forms.Button btnStFailed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGradeReportCour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbFailReport;
        private System.Windows.Forms.RadioButton rbFGreater;
        private System.Windows.Forms.RadioButton rbFLess;
        private System.Windows.Forms.NumericUpDown nudPercent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnFailResults;
        private System.Windows.Forms.Button btnPassReport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbPassReport;
        private System.Windows.Forms.RadioButton rbPGreater;
        private System.Windows.Forms.RadioButton rbPLess;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbPassGrade;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Label label15;
    }
}


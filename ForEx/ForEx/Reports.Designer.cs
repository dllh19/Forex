namespace ForEx
{
    partial class frmReports
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
            this.grpBlackList = new System.Windows.Forms.GroupBox();
            this.btnCorporate = new System.Windows.Forms.Button();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnIndividuals = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAnnexOnePeriod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTransacEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpTransacStart = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAnnexOneDaily = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTransacDaily = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAuditRange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAuditEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpAuditStart = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAuditDaily = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpAuditDaily = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAuditType1 = new System.Windows.Forms.ComboBox();
            this.cmbAuditType2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBlackList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBlackList
            // 
            this.grpBlackList.Controls.Add(this.btnCorporate);
            this.grpBlackList.Controls.Add(this.btnBank);
            this.grpBlackList.Controls.Add(this.btnIndividuals);
            this.grpBlackList.Location = new System.Drawing.Point(12, 12);
            this.grpBlackList.Name = "grpBlackList";
            this.grpBlackList.Size = new System.Drawing.Size(172, 133);
            this.grpBlackList.TabIndex = 0;
            this.grpBlackList.TabStop = false;
            this.grpBlackList.Text = "Black List Reports";
            // 
            // btnCorporate
            // 
            this.btnCorporate.Location = new System.Drawing.Point(6, 86);
            this.btnCorporate.Name = "btnCorporate";
            this.btnCorporate.Size = new System.Drawing.Size(160, 28);
            this.btnCorporate.TabIndex = 2;
            this.btnCorporate.Text = "Corporate";
            this.btnCorporate.UseVisualStyleBackColor = true;
            this.btnCorporate.Click += new System.EventHandler(this.btnCorporate_Click);
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(6, 52);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(160, 28);
            this.btnBank.TabIndex = 1;
            this.btnBank.Text = "Bank";
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnIndividuals
            // 
            this.btnIndividuals.Location = new System.Drawing.Point(6, 19);
            this.btnIndividuals.Name = "btnIndividuals";
            this.btnIndividuals.Size = new System.Drawing.Size(160, 28);
            this.btnIndividuals.TabIndex = 0;
            this.btnIndividuals.Text = "Individuals";
            this.btnIndividuals.UseVisualStyleBackColor = true;
            this.btnIndividuals.Click += new System.EventHandler(this.btnIndividuals_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(190, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Annex One";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(359, 139);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAnnexOnePeriod);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpTransacEnd);
            this.tabPage1.Controls.Add(this.dtpTransacStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(351, 113);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Period";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAnnexOnePeriod
            // 
            this.btnAnnexOnePeriod.Location = new System.Drawing.Point(94, 79);
            this.btnAnnexOnePeriod.Name = "btnAnnexOnePeriod";
            this.btnAnnexOnePeriod.Size = new System.Drawing.Size(160, 28);
            this.btnAnnexOnePeriod.TabIndex = 3;
            this.btnAnnexOnePeriod.Text = "Show Report";
            this.btnAnnexOnePeriod.UseVisualStyleBackColor = true;
            this.btnAnnexOnePeriod.Click += new System.EventHandler(this.btnTransactionReportWeekly_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // dtpTransacEnd
            // 
            this.dtpTransacEnd.Location = new System.Drawing.Point(136, 45);
            this.dtpTransacEnd.Name = "dtpTransacEnd";
            this.dtpTransacEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpTransacEnd.TabIndex = 1;
            // 
            // dtpTransacStart
            // 
            this.dtpTransacStart.Location = new System.Drawing.Point(136, 13);
            this.dtpTransacStart.Name = "dtpTransacStart";
            this.dtpTransacStart.Size = new System.Drawing.Size(200, 20);
            this.dtpTransacStart.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAnnexOneDaily);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dtpTransacDaily);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(351, 113);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Daily";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAnnexOneDaily
            // 
            this.btnAnnexOneDaily.Location = new System.Drawing.Point(88, 59);
            this.btnAnnexOneDaily.Name = "btnAnnexOneDaily";
            this.btnAnnexOneDaily.Size = new System.Drawing.Size(160, 28);
            this.btnAnnexOneDaily.TabIndex = 6;
            this.btnAnnexOneDaily.Text = "Show Report";
            this.btnAnnexOneDaily.UseVisualStyleBackColor = true;
            this.btnAnnexOneDaily.Click += new System.EventHandler(this.btnTransacDaily_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // dtpTransacDaily
            // 
            this.dtpTransacDaily.Location = new System.Drawing.Point(130, 25);
            this.dtpTransacDaily.Name = "dtpTransacDaily";
            this.dtpTransacDaily.Size = new System.Drawing.Size(200, 20);
            this.dtpTransacDaily.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Location = new System.Drawing.Point(190, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 203);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audit";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(6, 19);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(359, 164);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbAuditType1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnAuditRange);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dtpAuditEnd);
            this.tabPage3.Controls.Add(this.dtpAuditStart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(351, 138);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Period";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAuditRange
            // 
            this.btnAuditRange.Location = new System.Drawing.Point(94, 104);
            this.btnAuditRange.Name = "btnAuditRange";
            this.btnAuditRange.Size = new System.Drawing.Size(160, 28);
            this.btnAuditRange.TabIndex = 3;
            this.btnAuditRange.Text = "Show Report";
            this.btnAuditRange.UseVisualStyleBackColor = true;
            this.btnAuditRange.Click += new System.EventHandler(this.btnAuditRange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Start Date";
            // 
            // dtpAuditEnd
            // 
            this.dtpAuditEnd.Location = new System.Drawing.Point(136, 45);
            this.dtpAuditEnd.Name = "dtpAuditEnd";
            this.dtpAuditEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpAuditEnd.TabIndex = 1;
            // 
            // dtpAuditStart
            // 
            this.dtpAuditStart.Location = new System.Drawing.Point(136, 13);
            this.dtpAuditStart.Name = "dtpAuditStart";
            this.dtpAuditStart.Size = new System.Drawing.Size(200, 20);
            this.dtpAuditStart.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbAuditType2);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btnAuditDaily);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.dtpAuditDaily);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(351, 138);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Daily";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAuditDaily
            // 
            this.btnAuditDaily.Location = new System.Drawing.Point(94, 104);
            this.btnAuditDaily.Name = "btnAuditDaily";
            this.btnAuditDaily.Size = new System.Drawing.Size(160, 28);
            this.btnAuditDaily.TabIndex = 6;
            this.btnAuditDaily.Text = "Show Report";
            this.btnAuditDaily.UseVisualStyleBackColor = true;
            this.btnAuditDaily.Click += new System.EventHandler(this.btnAuditDaily_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // dtpAuditDaily
            // 
            this.dtpAuditDaily.Location = new System.Drawing.Point(130, 25);
            this.dtpAuditDaily.Name = "dtpAuditDaily";
            this.dtpAuditDaily.Size = new System.Drawing.Size(200, 20);
            this.dtpAuditDaily.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Audit Type";
            // 
            // cmbAuditType1
            // 
            this.cmbAuditType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuditType1.FormattingEnabled = true;
            this.cmbAuditType1.Location = new System.Drawing.Point(136, 80);
            this.cmbAuditType1.Name = "cmbAuditType1";
            this.cmbAuditType1.Size = new System.Drawing.Size(200, 21);
            this.cmbAuditType1.TabIndex = 5;
            // 
            // cmbAuditType2
            // 
            this.cmbAuditType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuditType2.FormattingEnabled = true;
            this.cmbAuditType2.Location = new System.Drawing.Point(130, 59);
            this.cmbAuditType2.Name = "cmbAuditType2";
            this.cmbAuditType2.Size = new System.Drawing.Size(200, 21);
            this.cmbAuditType2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Audit Type";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBlackList);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.grpBlackList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBlackList;
        private System.Windows.Forms.Button btnCorporate;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button btnIndividuals;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAnnexOnePeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTransacEnd;
        private System.Windows.Forms.DateTimePicker dtpTransacStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAnnexOneDaily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTransacDaily;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbAuditType1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAuditRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpAuditEnd;
        private System.Windows.Forms.DateTimePicker dtpAuditStart;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAuditDaily;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpAuditDaily;
        private System.Windows.Forms.ComboBox cmbAuditType2;
        private System.Windows.Forms.Label label8;
    }
}
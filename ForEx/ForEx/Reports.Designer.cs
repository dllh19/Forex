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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpTransacStart = new System.Windows.Forms.DateTimePicker();
            this.dtpTransacEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransactionReportWeekly = new System.Windows.Forms.Button();
            this.btnTransacDaily = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTransacDaily = new System.Windows.Forms.DateTimePicker();
            this.grpBlackList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.groupBox1.Text = "Transaction";
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
            this.tabPage1.Controls.Add(this.btnTransactionReportWeekly);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTransacDaily);
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
            // dtpTransacStart
            // 
            this.dtpTransacStart.Location = new System.Drawing.Point(136, 13);
            this.dtpTransacStart.Name = "dtpTransacStart";
            this.dtpTransacStart.Size = new System.Drawing.Size(200, 20);
            this.dtpTransacStart.TabIndex = 0;
            // 
            // dtpTransacEnd
            // 
            this.dtpTransacEnd.Location = new System.Drawing.Point(136, 45);
            this.dtpTransacEnd.Name = "dtpTransacEnd";
            this.dtpTransacEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpTransacEnd.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date";
            // 
            // btnTransactionReportWeekly
            // 
            this.btnTransactionReportWeekly.Location = new System.Drawing.Point(94, 79);
            this.btnTransactionReportWeekly.Name = "btnTransactionReportWeekly";
            this.btnTransactionReportWeekly.Size = new System.Drawing.Size(160, 28);
            this.btnTransactionReportWeekly.TabIndex = 3;
            this.btnTransactionReportWeekly.Text = "Show Report";
            this.btnTransactionReportWeekly.UseVisualStyleBackColor = true;
            this.btnTransactionReportWeekly.Click += new System.EventHandler(this.btnTransactionReportWeekly_Click);
            // 
            // btnTransacDaily
            // 
            this.btnTransacDaily.Location = new System.Drawing.Point(88, 59);
            this.btnTransacDaily.Name = "btnTransacDaily";
            this.btnTransacDaily.Size = new System.Drawing.Size(160, 28);
            this.btnTransacDaily.TabIndex = 6;
            this.btnTransacDaily.Text = "Show Report";
            this.btnTransacDaily.UseVisualStyleBackColor = true;
            this.btnTransacDaily.Click += new System.EventHandler(this.btnTransacDaily_Click);
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
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBlackList);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.grpBlackList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Button btnTransactionReportWeekly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTransacEnd;
        private System.Windows.Forms.DateTimePicker dtpTransacStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTransacDaily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTransacDaily;
    }
}
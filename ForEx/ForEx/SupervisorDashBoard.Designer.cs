namespace ForEx
{
    partial class frmSupervisorDashBoard
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
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnRateManagement = new System.Windows.Forms.Button();
            this.btnClientManagement = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnTrnsactionSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(220, 157);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(119, 60);
            this.btnTransaction.TabIndex = 13;
            this.btnTransaction.Text = "Transaction Management";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(35, 157);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(119, 60);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnRateManagement
            // 
            this.btnRateManagement.Location = new System.Drawing.Point(220, 43);
            this.btnRateManagement.Name = "btnRateManagement";
            this.btnRateManagement.Size = new System.Drawing.Size(119, 60);
            this.btnRateManagement.TabIndex = 11;
            this.btnRateManagement.Text = "Rate Management";
            this.btnRateManagement.UseVisualStyleBackColor = true;
            this.btnRateManagement.Click += new System.EventHandler(this.btnRateManagement_Click);
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.Location = new System.Drawing.Point(35, 43);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Size = new System.Drawing.Size(119, 60);
            this.btnClientManagement.TabIndex = 10;
            this.btnClientManagement.Text = "Client Management";
            this.btnClientManagement.UseVisualStyleBackColor = true;
            this.btnClientManagement.Click += new System.EventHandler(this.btnClientManagement_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(535, 478);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnSignout
            // 
            this.btnSignout.Location = new System.Drawing.Point(220, 426);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(119, 60);
            this.btnSignout.TabIndex = 22;
            this.btnSignout.Text = "Sign out";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(35, 251);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(119, 60);
            this.btnPOS.TabIndex = 28;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnTrnsactionSearch
            // 
            this.btnTrnsactionSearch.Location = new System.Drawing.Point(220, 251);
            this.btnTrnsactionSearch.Name = "btnTrnsactionSearch";
            this.btnTrnsactionSearch.Size = new System.Drawing.Size(119, 60);
            this.btnTrnsactionSearch.TabIndex = 30;
            this.btnTrnsactionSearch.Text = "Transaction Search";
            this.btnTrnsactionSearch.UseVisualStyleBackColor = true;
            this.btnTrnsactionSearch.Click += new System.EventHandler(this.btnTrnsactionSearch_Click);
            // 
            // frmSupervisorDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 498);
            this.Controls.Add(this.btnTrnsactionSearch);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnRateManagement);
            this.Controls.Add(this.btnClientManagement);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSupervisorDashBoard";
            this.Text = "SupervisorDashBoard";
            this.Load += new System.EventHandler(this.frmSupervisorDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnRateManagement;
        private System.Windows.Forms.Button btnClientManagement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnTrnsactionSearch;
    }
}
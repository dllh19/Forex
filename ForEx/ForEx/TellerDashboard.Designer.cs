namespace ForEx
{
    partial class TellerDashboard
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
            this.btnCashInCashOut = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCloseCash = new System.Windows.Forms.Button();
            this.btnClientManagement = new System.Windows.Forms.Button();
            this.btnPOSPanel = new System.Windows.Forms.Button();
            this.btnBulkCashIn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCashInCashOut
            // 
            this.btnCashInCashOut.Location = new System.Drawing.Point(240, 160);
            this.btnCashInCashOut.Name = "btnCashInCashOut";
            this.btnCashInCashOut.Size = new System.Drawing.Size(119, 60);
            this.btnCashInCashOut.TabIndex = 27;
            this.btnCashInCashOut.Text = "Cash In / Cash Out";
            this.btnCashInCashOut.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(55, 272);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(119, 60);
            this.btnReports.TabIndex = 26;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnCloseCash
            // 
            this.btnCloseCash.Location = new System.Drawing.Point(240, 272);
            this.btnCloseCash.Name = "btnCloseCash";
            this.btnCloseCash.Size = new System.Drawing.Size(119, 60);
            this.btnCloseCash.TabIndex = 25;
            this.btnCloseCash.Text = "Close Cash";
            this.btnCloseCash.UseVisualStyleBackColor = true;
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.Location = new System.Drawing.Point(55, 160);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Size = new System.Drawing.Size(119, 60);
            this.btnClientManagement.TabIndex = 24;
            this.btnClientManagement.Text = "Client Management";
            this.btnClientManagement.UseVisualStyleBackColor = true;
            // 
            // btnPOSPanel
            // 
            this.btnPOSPanel.Location = new System.Drawing.Point(240, 46);
            this.btnPOSPanel.Name = "btnPOSPanel";
            this.btnPOSPanel.Size = new System.Drawing.Size(119, 60);
            this.btnPOSPanel.TabIndex = 23;
            this.btnPOSPanel.Text = "POS Panel";
            this.btnPOSPanel.UseVisualStyleBackColor = true;
            // 
            // btnBulkCashIn
            // 
            this.btnBulkCashIn.Location = new System.Drawing.Point(55, 46);
            this.btnBulkCashIn.Name = "btnBulkCashIn";
            this.btnBulkCashIn.Size = new System.Drawing.Size(119, 60);
            this.btnBulkCashIn.TabIndex = 22;
            this.btnBulkCashIn.Text = "Bulk Cash In";
            this.btnBulkCashIn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(416, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 478);
            this.dataGridView1.TabIndex = 21;
            // 
            // TellerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 508);
            this.Controls.Add(this.btnCashInCashOut);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCloseCash);
            this.Controls.Add(this.btnClientManagement);
            this.Controls.Add(this.btnPOSPanel);
            this.Controls.Add(this.btnBulkCashIn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TellerDashboard";
            this.Text = "TellerDashboard";
            this.Load += new System.EventHandler(this.TellerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCashInCashOut;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCloseCash;
        private System.Windows.Forms.Button btnClientManagement;
        private System.Windows.Forms.Button btnPOSPanel;
        private System.Windows.Forms.Button btnBulkCashIn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
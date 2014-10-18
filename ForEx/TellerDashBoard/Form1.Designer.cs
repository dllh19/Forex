namespace TellerDashBoard
{
    partial class frmTellerForm
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
            this.btnBulkCashIn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPOSPanel = new System.Windows.Forms.Button();
            this.btnClientManagement = new System.Windows.Forms.Button();
            this.btnCashInCashOut = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCloseTheCash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBulkCashIn
            // 
            this.btnBulkCashIn.Location = new System.Drawing.Point(41, 54);
            this.btnBulkCashIn.Name = "btnBulkCashIn";
            this.btnBulkCashIn.Size = new System.Drawing.Size(119, 60);
            this.btnBulkCashIn.TabIndex = 0;
            this.btnBulkCashIn.Text = "Bulk Cash In";
            this.btnBulkCashIn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 478);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnPOSPanel
            // 
            this.btnPOSPanel.Location = new System.Drawing.Point(226, 54);
            this.btnPOSPanel.Name = "btnPOSPanel";
            this.btnPOSPanel.Size = new System.Drawing.Size(119, 60);
            this.btnPOSPanel.TabIndex = 2;
            this.btnPOSPanel.Text = "POS Panel";
            this.btnPOSPanel.UseVisualStyleBackColor = true;
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.Location = new System.Drawing.Point(41, 158);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Size = new System.Drawing.Size(119, 60);
            this.btnClientManagement.TabIndex = 3;
            this.btnClientManagement.Text = "Client Management";
            this.btnClientManagement.UseVisualStyleBackColor = true;
            // 
            // btnCashInCashOut
            // 
            this.btnCashInCashOut.Location = new System.Drawing.Point(226, 158);
            this.btnCashInCashOut.Name = "btnCashInCashOut";
            this.btnCashInCashOut.Size = new System.Drawing.Size(119, 60);
            this.btnCashInCashOut.TabIndex = 4;
            this.btnCashInCashOut.Text = "Cash In / Cash Out";
            this.btnCashInCashOut.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(41, 272);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(119, 60);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnCloseTheCash
            // 
            this.btnCloseTheCash.Location = new System.Drawing.Point(226, 272);
            this.btnCloseTheCash.Name = "btnCloseTheCash";
            this.btnCloseTheCash.Size = new System.Drawing.Size(119, 60);
            this.btnCloseTheCash.TabIndex = 6;
            this.btnCloseTheCash.Text = "Close The Cash";
            this.btnCloseTheCash.UseVisualStyleBackColor = true;
            // 
            // frmTellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 516);
            this.Controls.Add(this.btnCloseTheCash);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCashInCashOut);
            this.Controls.Add(this.btnClientManagement);
            this.Controls.Add(this.btnPOSPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBulkCashIn);
            this.Name = "frmTellerForm";
            this.Text = "Teller Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBulkCashIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPOSPanel;
        private System.Windows.Forms.Button btnClientManagement;
        private System.Windows.Forms.Button btnCashInCashOut;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCloseTheCash;
    }
}


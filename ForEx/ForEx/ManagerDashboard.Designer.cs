namespace ForEx
{
    partial class ManagerDashboard
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
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnAuditTrail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(233, 291);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(119, 60);
            this.btnTransaction.TabIndex = 18;
            this.btnTransaction.Text = "Transaction Management";
            this.btnTransaction.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(48, 179);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(119, 60);
            this.btnReports.TabIndex = 17;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnRateManagement
            // 
            this.btnRateManagement.Location = new System.Drawing.Point(233, 65);
            this.btnRateManagement.Name = "btnRateManagement";
            this.btnRateManagement.Size = new System.Drawing.Size(119, 60);
            this.btnRateManagement.TabIndex = 16;
            this.btnRateManagement.Text = "Rate Management";
            this.btnRateManagement.UseVisualStyleBackColor = true;
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.Location = new System.Drawing.Point(48, 65);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Size = new System.Drawing.Size(119, 60);
            this.btnClientManagement.TabIndex = 15;
            this.btnClientManagement.Text = "Client Management";
            this.btnClientManagement.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 478);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(48, 291);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(119, 60);
            this.btnUserManagement.TabIndex = 19;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnAuditTrail
            // 
            this.btnAuditTrail.Location = new System.Drawing.Point(233, 179);
            this.btnAuditTrail.Name = "btnAuditTrail";
            this.btnAuditTrail.Size = new System.Drawing.Size(119, 60);
            this.btnAuditTrail.TabIndex = 20;
            this.btnAuditTrail.Text = "Audit Trail";
            this.btnAuditTrail.UseVisualStyleBackColor = true;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 522);
            this.Controls.Add(this.btnAuditTrail);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnRateManagement);
            this.Controls.Add(this.btnClientManagement);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerDashboard";
            this.Text = "ManagerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnRateManagement;
        private System.Windows.Forms.Button btnClientManagement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnAuditTrail;
    }
}
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
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(35, 157);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(119, 60);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnRateManagement
            // 
            this.btnRateManagement.Location = new System.Drawing.Point(220, 43);
            this.btnRateManagement.Name = "btnRateManagement";
            this.btnRateManagement.Size = new System.Drawing.Size(119, 60);
            this.btnRateManagement.TabIndex = 11;
            this.btnRateManagement.Text = "Rate Management";
            this.btnRateManagement.UseVisualStyleBackColor = true;
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.Location = new System.Drawing.Point(35, 43);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Size = new System.Drawing.Size(119, 60);
            this.btnClientManagement.TabIndex = 10;
            this.btnClientManagement.Text = "Client Management";
            this.btnClientManagement.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 478);
            this.dataGridView1.TabIndex = 8;
            // 
            // frmSupervisorDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 498);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnRateManagement);
            this.Controls.Add(this.btnClientManagement);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSupervisorDashBoard";
            this.Text = "SupervisorDashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnRateManagement;
        private System.Windows.Forms.Button btnClientManagement;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
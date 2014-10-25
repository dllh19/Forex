namespace ForEx
{
    partial class Closing
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateL = new System.Windows.Forms.Label();
            this.lblCommisionPaid = new System.Windows.Forms.Label();
            this.lblCommisionsReceived = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblDate);
            this.GroupBox1.Controls.Add(this.lblDateL);
            this.GroupBox1.Location = new System.Drawing.Point(26, 47);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(881, 49);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(408, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Current Date";
            // 
            // lblDateL
            // 
            this.lblDateL.AutoSize = true;
            this.lblDateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateL.Location = new System.Drawing.Point(313, 20);
            this.lblDateL.Name = "lblDateL";
            this.lblDateL.Size = new System.Drawing.Size(38, 13);
            this.lblDateL.TabIndex = 0;
            this.lblDateL.Text = "Date:";
            // 
            // lblCommisionPaid
            // 
            this.lblCommisionPaid.AutoSize = true;
            this.lblCommisionPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommisionPaid.Location = new System.Drawing.Point(498, 427);
            this.lblCommisionPaid.Name = "lblCommisionPaid";
            this.lblCommisionPaid.Size = new System.Drawing.Size(114, 13);
            this.lblCommisionPaid.TabIndex = 13;
            this.lblCommisionPaid.Text = "Commision Paid : 0";
            // 
            // lblCommisionsReceived
            // 
            this.lblCommisionsReceived.AutoSize = true;
            this.lblCommisionsReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommisionsReceived.Location = new System.Drawing.Point(301, 427);
            this.lblCommisionsReceived.Name = "lblCommisionsReceived";
            this.lblCommisionsReceived.Size = new System.Drawing.Size(143, 13);
            this.lblCommisionsReceived.TabIndex = 8;
            this.lblCommisionsReceived.Text = "Commision Received : 0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(437, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 49);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(342, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 49);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(26, 150);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(881, 257);
            this.DataGridView1.TabIndex = 10;
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactions.Location = new System.Drawing.Point(390, 111);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(148, 25);
            this.lblTransactions.TabIndex = 9;
            this.lblTransactions.Text = "Transactions";
            // 
            // Closing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 526);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lblCommisionPaid);
            this.Controls.Add(this.lblCommisionsReceived);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.lblTransactions);
            this.Name = "Closing";
            this.Text = "Closing";
            this.Load += new System.EventHandler(this.Closing_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblDateL;
        internal System.Windows.Forms.Label lblCommisionPaid;
        internal System.Windows.Forms.Label lblCommisionsReceived;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label lblTransactions;
    }
}
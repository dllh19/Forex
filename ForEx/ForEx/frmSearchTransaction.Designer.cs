namespace ForEx
{
    partial class frmSearchTransaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radReceiptID = new System.Windows.Forms.RadioButton();
            this.radTransacID = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.txtReceiptID = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTrnsaction = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvClientInfo = new System.Windows.Forms.DataGridView();
            this.btnShowReceipt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrnsaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radReceiptID);
            this.groupBox1.Controls.Add(this.radTransacID);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // radReceiptID
            // 
            this.radReceiptID.AutoSize = true;
            this.radReceiptID.Location = new System.Drawing.Point(118, 20);
            this.radReceiptID.Name = "radReceiptID";
            this.radReceiptID.Size = new System.Drawing.Size(76, 17);
            this.radReceiptID.TabIndex = 1;
            this.radReceiptID.TabStop = true;
            this.radReceiptID.Text = "Receipt ID";
            this.radReceiptID.UseVisualStyleBackColor = true;
            this.radReceiptID.CheckedChanged += new System.EventHandler(this.radReceiptID_CheckedChanged);
            // 
            // radTransacID
            // 
            this.radTransacID.AutoSize = true;
            this.radTransacID.Location = new System.Drawing.Point(17, 20);
            this.radTransacID.Name = "radTransacID";
            this.radTransacID.Size = new System.Drawing.Size(95, 17);
            this.radTransacID.TabIndex = 0;
            this.radTransacID.TabStop = true;
            this.radTransacID.Text = "Transaction ID";
            this.radTransacID.UseVisualStyleBackColor = true;
            this.radTransacID.CheckedChanged += new System.EventHandler(this.radTransacID_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Receipt ID:";
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Location = new System.Drawing.Point(131, 69);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.ReadOnly = true;
            this.txtTransactionID.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionID.TabIndex = 3;
            // 
            // txtReceiptID
            // 
            this.txtReceiptID.Location = new System.Drawing.Point(131, 96);
            this.txtReceiptID.Name = "txtReceiptID";
            this.txtReceiptID.ReadOnly = true;
            this.txtReceiptID.Size = new System.Drawing.Size(100, 20);
            this.txtReceiptID.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1132, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTrnsaction
            // 
            this.dgvTrnsaction.AllowUserToAddRows = false;
            this.dgvTrnsaction.AllowUserToDeleteRows = false;
            this.dgvTrnsaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrnsaction.Location = new System.Drawing.Point(330, 33);
            this.dgvTrnsaction.Name = "dgvTrnsaction";
            this.dgvTrnsaction.ReadOnly = true;
            this.dgvTrnsaction.Size = new System.Drawing.Size(790, 220);
            this.dgvTrnsaction.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client Information";
            // 
            // dgvClientInfo
            // 
            this.dgvClientInfo.AllowUserToAddRows = false;
            this.dgvClientInfo.AllowUserToDeleteRows = false;
            this.dgvClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientInfo.Location = new System.Drawing.Point(330, 282);
            this.dgvClientInfo.Name = "dgvClientInfo";
            this.dgvClientInfo.ReadOnly = true;
            this.dgvClientInfo.Size = new System.Drawing.Size(790, 90);
            this.dgvClientInfo.TabIndex = 9;
            // 
            // btnShowReceipt
            // 
            this.btnShowReceipt.Location = new System.Drawing.Point(1010, 379);
            this.btnShowReceipt.Name = "btnShowReceipt";
            this.btnShowReceipt.Size = new System.Drawing.Size(110, 38);
            this.btnShowReceipt.TabIndex = 10;
            this.btnShowReceipt.Text = "Show Receipt";
            this.btnShowReceipt.UseVisualStyleBackColor = true;
            this.btnShowReceipt.Click += new System.EventHandler(this.btnShowReceipt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Transaction";
            // 
            // frmSearchTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 455);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShowReceipt);
            this.Controls.Add(this.dgvClientInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTrnsaction);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtReceiptID);
            this.Controls.Add(this.txtTransactionID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSearchTransaction";
            this.Text = "frmSearchTransaction";
            this.Load += new System.EventHandler(this.frmSearchTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrnsaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radReceiptID;
        private System.Windows.Forms.RadioButton radTransacID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.TextBox txtReceiptID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTrnsaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvClientInfo;
        private System.Windows.Forms.Button btnShowReceipt;
        private System.Windows.Forms.Label label4;
    }
}
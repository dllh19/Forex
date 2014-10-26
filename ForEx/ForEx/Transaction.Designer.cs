namespace ForEx
{
    partial class Transaction
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
            this.btnDiscard = new System.Windows.Forms.Button();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.ComboBox5 = new System.Windows.Forms.ComboBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.lblCashCheque = new System.Windows.Forms.Label();
            this.lblAmount2 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.textRate = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.comboCurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.grpMovement = new System.Windows.Forms.GroupBox();
            this.btnCalAdd = new System.Windows.Forms.Button();
            this.textRateReadOnly = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.GroupBox5.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.grpMovement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(465, 552);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(89, 48);
            this.btnDiscard.TabIndex = 29;
            this.btnDiscard.Text = "Discard and Exit";
            this.btnDiscard.UseVisualStyleBackColor = true;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(184, 338);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.Size = new System.Drawing.Size(543, 184);
            this.dgvTransaction.TabIndex = 27;
            // 
            // ComboBox5
            // 
            this.ComboBox5.FormattingEnabled = true;
            this.ComboBox5.Location = new System.Drawing.Point(414, 25);
            this.ComboBox5.Name = "ComboBox5";
            this.ComboBox5.Size = new System.Drawing.Size(122, 21);
            this.ComboBox5.TabIndex = 20;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(716, 26);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(122, 20);
            this.TextBox6.TabIndex = 23;
            // 
            // lblCashCheque
            // 
            this.lblCashCheque.AutoSize = true;
            this.lblCashCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashCheque.Location = new System.Drawing.Point(316, 26);
            this.lblCashCheque.Name = "lblCashCheque";
            this.lblCashCheque.Size = new System.Drawing.Size(92, 13);
            this.lblCashCheque.TabIndex = 21;
            this.lblCashCheque.Text = "Cash / Cheque";
            // 
            // lblAmount2
            // 
            this.lblAmount2.AutoSize = true;
            this.lblAmount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount2.Location = new System.Drawing.Point(661, 26);
            this.lblAmount2.Name = "lblAmount2";
            this.lblAmount2.Size = new System.Drawing.Size(49, 13);
            this.lblAmount2.TabIndex = 22;
            this.lblAmount2.Text = "Amount";
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(73, 26);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(122, 20);
            this.TextBox5.TabIndex = 21;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(18, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(350, 552);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 48);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "Print and Exit";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.ComboBox5);
            this.GroupBox5.Controls.Add(this.TextBox6);
            this.GroupBox5.Controls.Add(this.lblCashCheque);
            this.GroupBox5.Controls.Add(this.lblAmount2);
            this.GroupBox5.Controls.Add(this.TextBox5);
            this.GroupBox5.Controls.Add(this.lblTotal);
            this.GroupBox5.Location = new System.Drawing.Point(31, 255);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(863, 53);
            this.GroupBox5.TabIndex = 26;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(664, 125);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 42);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(553, 98);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(152, 20);
            this.textTotal.TabIndex = 16;
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRs.Location = new System.Drawing.Point(466, 101);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(36, 13);
            this.lblRs.TabIndex = 15;
            this.lblRs.Text = "Total";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(245, 101);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(122, 20);
            this.txtAmount.TabIndex = 14;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(132, 101);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Amount";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.comboClient);
            this.Panel2.Controls.Add(this.lblClient);
            this.Panel2.Location = new System.Drawing.Point(452, 21);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(477, 46);
            this.Panel2.TabIndex = 24;
            // 
            // comboClient
            // 
            this.comboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(83, 14);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(359, 21);
            this.comboClient.TabIndex = 5;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(38, 17);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Client";
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(31, 21);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(424, 46);
            this.Panel1.TabIndex = 23;
            // 
            // textRate
            // 
            this.textRate.Location = new System.Drawing.Point(553, 60);
            this.textRate.Name = "textRate";
            this.textRate.Size = new System.Drawing.Size(152, 20);
            this.textRate.TabIndex = 12;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label9.Location = new System.Drawing.Point(466, 63);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(34, 13);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "Rate";
            // 
            // lblRate
            // 
            this.lblRate.AutoEllipsis = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(132, 63);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(94, 27);
            this.lblRate.TabIndex = 10;
            this.lblRate.Text = "Recommended Rate";
            // 
            // comboCurrency
            // 
            this.comboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurrency.FormattingEnabled = true;
            this.comboCurrency.Location = new System.Drawing.Point(553, 28);
            this.comboCurrency.Name = "comboCurrency";
            this.comboCurrency.Size = new System.Drawing.Size(152, 21);
            this.comboCurrency.TabIndex = 7;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(466, 28);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(57, 13);
            this.lblCurrency.TabIndex = 8;
            this.lblCurrency.Text = "Currency";
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(245, 28);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(122, 21);
            this.comboType.TabIndex = 6;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(132, 28);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // grpMovement
            // 
            this.grpMovement.Controls.Add(this.btnCalAdd);
            this.grpMovement.Controls.Add(this.textRateReadOnly);
            this.grpMovement.Controls.Add(this.btnCalculate);
            this.grpMovement.Controls.Add(this.textTotal);
            this.grpMovement.Controls.Add(this.lblRs);
            this.grpMovement.Controls.Add(this.txtAmount);
            this.grpMovement.Controls.Add(this.lblAmount);
            this.grpMovement.Controls.Add(this.textRate);
            this.grpMovement.Controls.Add(this.Label9);
            this.grpMovement.Controls.Add(this.lblRate);
            this.grpMovement.Controls.Add(this.comboCurrency);
            this.grpMovement.Controls.Add(this.lblCurrency);
            this.grpMovement.Controls.Add(this.comboType);
            this.grpMovement.Controls.Add(this.lblType);
            this.grpMovement.Location = new System.Drawing.Point(31, 75);
            this.grpMovement.Name = "grpMovement";
            this.grpMovement.Size = new System.Drawing.Size(898, 173);
            this.grpMovement.TabIndex = 25;
            this.grpMovement.TabStop = false;
            // 
            // btnCalAdd
            // 
            this.btnCalAdd.Location = new System.Drawing.Point(792, 125);
            this.btnCalAdd.Name = "btnCalAdd";
            this.btnCalAdd.Size = new System.Drawing.Size(89, 42);
            this.btnCalAdd.TabIndex = 21;
            this.btnCalAdd.Text = "Calculate and Add";
            this.btnCalAdd.UseVisualStyleBackColor = true;
            this.btnCalAdd.Click += new System.EventHandler(this.btnCalAdd_Click);
            // 
            // textRateReadOnly
            // 
            this.textRateReadOnly.Location = new System.Drawing.Point(245, 60);
            this.textRateReadOnly.Name = "textRateReadOnly";
            this.textRateReadOnly.ReadOnly = true;
            this.textRateReadOnly.Size = new System.Drawing.Size(122, 20);
            this.textRateReadOnly.TabIndex = 20;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 633);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.grpMovement);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.grpMovement.ResumeLayout(false);
            this.grpMovement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnDiscard;
        internal System.Windows.Forms.DataGridView dgvTransaction;
        internal System.Windows.Forms.ComboBox ComboBox5;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.Label lblCashCheque;
        internal System.Windows.Forms.Label lblAmount2;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.TextBox textTotal;
        internal System.Windows.Forms.Label lblRs;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.Label lblAmount;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label lblClient;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox textRate;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label lblRate;
        internal System.Windows.Forms.ComboBox comboCurrency;
        internal System.Windows.Forms.Label lblCurrency;
        internal System.Windows.Forms.ComboBox comboType;
        internal System.Windows.Forms.Label lblType;
        internal System.Windows.Forms.GroupBox grpMovement;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.TextBox textRateReadOnly;
        internal System.Windows.Forms.Button btnCalAdd;
    }
}
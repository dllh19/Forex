namespace ForEx
{
    partial class CashIn
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
            this.btnCashIn = new System.Windows.Forms.Button();
            this.gridCashIn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCashIn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCashIn
            // 
            this.btnCashIn.Location = new System.Drawing.Point(547, 292);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(131, 47);
            this.btnCashIn.TabIndex = 9;
            this.btnCashIn.Text = "Cash In";
            this.btnCashIn.UseVisualStyleBackColor = true;
            this.btnCashIn.Click += new System.EventHandler(this.btnCashIn_Click);
            // 
            // gridCashIn
            // 
            this.gridCashIn.AllowUserToAddRows = false;
            this.gridCashIn.AllowUserToDeleteRows = false;
            this.gridCashIn.AllowUserToResizeRows = false;
            this.gridCashIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCashIn.Location = new System.Drawing.Point(12, 12);
            this.gridCashIn.Name = "gridCashIn";
            this.gridCashIn.ReadOnly = true;
            this.gridCashIn.Size = new System.Drawing.Size(517, 603);
            this.gridCashIn.TabIndex = 8;
            // 
            // CashIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 632);
            this.Controls.Add(this.btnCashIn);
            this.Controls.Add(this.gridCashIn);
            this.Name = "CashIn";
            this.Text = "CashIn";
            this.Load += new System.EventHandler(this.CashIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCashIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCashIn;
        private System.Windows.Forms.DataGridView gridCashIn;
    }
}
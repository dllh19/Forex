namespace ForEx
{
    partial class CashOut
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
            this.btnCashOut = new System.Windows.Forms.Button();
            this.gridCashOut = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCashOut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCashOut
            // 
            this.btnCashOut.Location = new System.Drawing.Point(556, 245);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(131, 47);
            this.btnCashOut.TabIndex = 3;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.UseVisualStyleBackColor = true;
            // 
            // gridCashOut
            // 
            this.gridCashOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCashOut.Location = new System.Drawing.Point(5, 8);
            this.gridCashOut.Name = "gridCashOut";
            this.gridCashOut.Size = new System.Drawing.Size(517, 603);
            this.gridCashOut.TabIndex = 2;
            // 
            // CashOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 630);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.gridCashOut);
            this.Name = "CashOut";
            this.Text = "CashOut";
            ((System.ComponentModel.ISupportInitialize)(this.gridCashOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.DataGridView gridCashOut;
    }
}
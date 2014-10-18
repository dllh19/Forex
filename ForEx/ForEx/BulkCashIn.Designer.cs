namespace ForEx
{
    partial class BulkCashIn
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
            this.gridCashIn = new System.Windows.Forms.DataGridView();
            this.btnCashIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCashIn)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCashIn
            // 
            this.gridCashIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCashIn.Location = new System.Drawing.Point(12, 12);
            this.gridCashIn.Name = "gridCashIn";
            this.gridCashIn.Size = new System.Drawing.Size(517, 603);
            this.gridCashIn.TabIndex = 0;
            // 
            // btnCashIn
            // 
            this.btnCashIn.Location = new System.Drawing.Point(554, 21);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(131, 47);
            this.btnCashIn.TabIndex = 1;
            this.btnCashIn.Text = "Cash In";
            this.btnCashIn.UseVisualStyleBackColor = true;
            // 
            // BulkCashIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 627);
            this.Controls.Add(this.btnCashIn);
            this.Controls.Add(this.gridCashIn);
            this.Name = "BulkCashIn";
            this.Text = "BulkCashIn";
            ((System.ComponentModel.ISupportInitialize)(this.gridCashIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCashIn;
        private System.Windows.Forms.Button btnCashIn;
    }
}
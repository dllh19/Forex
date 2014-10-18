namespace ForEx
{
    partial class ViewClient
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
            this.grdClient = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.chkRefineSearch = new System.Windows.Forms.CheckBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.lblNextVoucher = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClient
            // 
            this.grdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClient.Location = new System.Drawing.Point(12, 157);
            this.grdClient.Name = "grdClient";
            this.grdClient.Size = new System.Drawing.Size(690, 240);
            this.grdClient.TabIndex = 17;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(570, 128);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(119, 23);
            this.btnAddNew.TabIndex = 16;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // chkRefineSearch
            // 
            this.chkRefineSearch.AutoSize = true;
            this.chkRefineSearch.Location = new System.Drawing.Point(431, 134);
            this.chkRefineSearch.Name = "chkRefineSearch";
            this.chkRefineSearch.Size = new System.Drawing.Size(94, 17);
            this.chkRefineSearch.TabIndex = 15;
            this.chkRefineSearch.Text = "Refine Search";
            this.chkRefineSearch.UseVisualStyleBackColor = true;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(320, 97);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(92, 13);
            this.lblClientName.TabIndex = 14;
            this.lblClientName.Text = "Enter Client Name";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(431, 90);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(258, 20);
            this.txtClientName.TabIndex = 13;
            // 
            // TextBox2
            // 
            this.TextBox2.ForeColor = System.Drawing.Color.Red;
            this.TextBox2.Location = new System.Drawing.Point(570, 51);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(119, 20);
            this.TextBox2.TabIndex = 12;
            // 
            // TextBox1
            // 
            this.TextBox1.ForeColor = System.Drawing.Color.Red;
            this.TextBox1.Location = new System.Drawing.Point(570, 16);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(119, 20);
            this.TextBox1.TabIndex = 11;
            // 
            // lblNextVoucher
            // 
            this.lblNextVoucher.AutoSize = true;
            this.lblNextVoucher.ForeColor = System.Drawing.Color.Red;
            this.lblNextVoucher.Location = new System.Drawing.Point(465, 54);
            this.lblNextVoucher.Name = "lblNextVoucher";
            this.lblNextVoucher.Size = new System.Drawing.Size(72, 13);
            this.lblNextVoucher.TabIndex = 10;
            this.lblNextVoucher.Text = "Next Voucher";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Location = new System.Drawing.Point(507, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // ViewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 423);
            this.Controls.Add(this.grdClient);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.chkRefineSearch);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.lblNextVoucher);
            this.Controls.Add(this.lblDate);
            this.Name = "ViewClient";
            this.Text = "ViewClient";
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView grdClient;
        internal System.Windows.Forms.Button btnAddNew;
        internal System.Windows.Forms.CheckBox chkRefineSearch;
        internal System.Windows.Forms.Label lblClientName;
        internal System.Windows.Forms.TextBox txtClientName;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label lblNextVoucher;
        internal System.Windows.Forms.Label lblDate;

    }
}
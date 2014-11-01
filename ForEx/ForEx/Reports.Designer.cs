namespace ForEx
{
    partial class frmReports
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
            this.grpBlackList = new System.Windows.Forms.GroupBox();
            this.btnIndividuals = new System.Windows.Forms.Button();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnCorporate = new System.Windows.Forms.Button();
            this.grpBlackList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBlackList
            // 
            this.grpBlackList.Controls.Add(this.btnCorporate);
            this.grpBlackList.Controls.Add(this.btnBank);
            this.grpBlackList.Controls.Add(this.btnIndividuals);
            this.grpBlackList.Location = new System.Drawing.Point(12, 12);
            this.grpBlackList.Name = "grpBlackList";
            this.grpBlackList.Size = new System.Drawing.Size(172, 133);
            this.grpBlackList.TabIndex = 0;
            this.grpBlackList.TabStop = false;
            this.grpBlackList.Text = "Black List Reports";
            // 
            // btnIndividuals
            // 
            this.btnIndividuals.Location = new System.Drawing.Point(6, 19);
            this.btnIndividuals.Name = "btnIndividuals";
            this.btnIndividuals.Size = new System.Drawing.Size(160, 28);
            this.btnIndividuals.TabIndex = 0;
            this.btnIndividuals.Text = "Individuals";
            this.btnIndividuals.UseVisualStyleBackColor = true;
            this.btnIndividuals.Click += new System.EventHandler(this.btnIndividuals_Click);
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(6, 52);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(160, 28);
            this.btnBank.TabIndex = 1;
            this.btnBank.Text = "Bank";
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnCorporate
            // 
            this.btnCorporate.Location = new System.Drawing.Point(6, 86);
            this.btnCorporate.Name = "btnCorporate";
            this.btnCorporate.Size = new System.Drawing.Size(160, 28);
            this.btnCorporate.TabIndex = 2;
            this.btnCorporate.Text = "Corporate";
            this.btnCorporate.UseVisualStyleBackColor = true;
            this.btnCorporate.Click += new System.EventHandler(this.btnCorporate_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 443);
            this.Controls.Add(this.grpBlackList);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.grpBlackList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBlackList;
        private System.Windows.Forms.Button btnCorporate;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button btnIndividuals;
    }
}
namespace ForEx
{
    partial class RateManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.gridUpdateRate = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRate = new System.Windows.Forms.DateTimePicker();
            this.gridSearchRate = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUpdateRate)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchRate)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdateRate);
            this.tabPage1.Controls.Add(this.gridUpdateRate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1089, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update Rate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.Location = new System.Drawing.Point(975, 362);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(108, 40);
            this.btnUpdateRate.TabIndex = 1;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.UseVisualStyleBackColor = true;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // gridUpdateRate
            // 
            this.gridUpdateRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUpdateRate.Location = new System.Drawing.Point(6, 6);
            this.gridUpdateRate.Name = "gridUpdateRate";
            this.gridUpdateRate.Size = new System.Drawing.Size(1077, 350);
            this.gridUpdateRate.TabIndex = 0;
            this.gridUpdateRate.DataSourceChanged += new System.EventHandler(this.gridUpdateRate_DataSourceChanged);
            this.gridUpdateRate.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUpdateRate_RowLeave);
            this.gridUpdateRate.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gridUpdateRate_RowValidating);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dtpRate);
            this.tabPage2.Controls.Add(this.gridSearchRate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Rate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Rate By Date";
            // 
            // dtpRate
            // 
            this.dtpRate.Location = new System.Drawing.Point(883, 26);
            this.dtpRate.Name = "dtpRate";
            this.dtpRate.Size = new System.Drawing.Size(200, 20);
            this.dtpRate.TabIndex = 2;
            this.dtpRate.ValueChanged += new System.EventHandler(this.dtpRate_ValueChanged);
            this.dtpRate.Validated += new System.EventHandler(this.dtpRate_Validated);
            // 
            // gridSearchRate
            // 
            this.gridSearchRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchRate.Location = new System.Drawing.Point(3, 52);
            this.gridSearchRate.Name = "gridSearchRate";
            this.gridSearchRate.Size = new System.Drawing.Size(1080, 350);
            this.gridSearchRate.TabIndex = 1;
            // 
            // RateManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "RateManagement";
            this.Text = "RateManagement";
            this.Load += new System.EventHandler(this.RateManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUpdateRate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.DataGridView gridUpdateRate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRate;
        private System.Windows.Forms.DataGridView gridSearchRate;
    }
}
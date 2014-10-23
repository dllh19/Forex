namespace ForEx
{
    partial class UserManagement
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
            this.textPhone = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAddUser = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSurname = new System.Windows.Forms.Panel();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConfirmpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelCountry = new System.Windows.Forms.Panel();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tabEditUSer = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchTeller = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabResetPassword = new System.Windows.Forms.TabPage();
            this.txtConfirmnewpass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.txtTellername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelSurname.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAddress.SuspendLayout();
            this.panelCountry.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panelPhone.SuspendLayout();
            this.tabEditUSer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabResetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(178, 12);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(218, 20);
            this.textPhone.TabIndex = 71;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAddUser);
            this.tabControl.Controls.Add(this.tabEditUSer);
            this.tabControl.Controls.Add(this.tabResetPassword);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(783, 531);
            this.tabControl.TabIndex = 3;
            // 
            // tabAddUser
            // 
            this.tabAddUser.BackColor = System.Drawing.Color.Transparent;
            this.tabAddUser.Controls.Add(this.flowLayoutPanel1);
            this.tabAddUser.Controls.Add(this.btnAdd);
            this.tabAddUser.Controls.Add(this.btnAddUser);
            this.tabAddUser.Location = new System.Drawing.Point(4, 22);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUser.Size = new System.Drawing.Size(775, 505);
            this.tabAddUser.TabIndex = 0;
            this.tabAddUser.Text = "Add User";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelName);
            this.flowLayoutPanel1.Controls.Add(this.panelSurname);
            this.flowLayoutPanel1.Controls.Add(this.panelUsername);
            this.flowLayoutPanel1.Controls.Add(this.panelPassword);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panelAddress);
            this.flowLayoutPanel1.Controls.Add(this.panelCountry);
            this.flowLayoutPanel1.Controls.Add(this.panelEmail);
            this.flowLayoutPanel1.Controls.Add(this.panelPhone);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(769, 423);
            this.flowLayoutPanel1.TabIndex = 50;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.txtName);
            this.panelName.Controls.Add(this.label4);
            this.panelName.Location = new System.Drawing.Point(3, 3);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(476, 38);
            this.panelName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 20);
            this.txtName.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Name";
            // 
            // panelSurname
            // 
            this.panelSurname.Controls.Add(this.txtSurname);
            this.panelSurname.Controls.Add(this.label5);
            this.panelSurname.Location = new System.Drawing.Point(3, 47);
            this.panelSurname.Name = "panelSurname";
            this.panelSurname.Size = new System.Drawing.Size(476, 38);
            this.panelSurname.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(178, 12);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(218, 20);
            this.txtSurname.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Surname";
            // 
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.txtUsername);
            this.panelUsername.Controls.Add(this.label16);
            this.panelUsername.Location = new System.Drawing.Point(3, 91);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(476, 38);
            this.panelUsername.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(178, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 20);
            this.txtUsername.TabIndex = 71;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 20);
            this.label16.TabIndex = 70;
            this.label16.Text = "Username";
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Controls.Add(this.label17);
            this.panelPassword.Location = new System.Drawing.Point(3, 135);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(476, 38);
            this.panelPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(178, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 20);
            this.txtPassword.TabIndex = 71;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 20);
            this.label17.TabIndex = 70;
            this.label17.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtConfirmpass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 38);
            this.panel1.TabIndex = 72;
            // 
            // txtConfirmpass
            // 
            this.txtConfirmpass.Location = new System.Drawing.Point(178, 12);
            this.txtConfirmpass.Name = "txtConfirmpass";
            this.txtConfirmpass.Size = new System.Drawing.Size(218, 20);
            this.txtConfirmpass.TabIndex = 71;
            this.txtConfirmpass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Confirm Password";
            // 
            // panelAddress
            // 
            this.panelAddress.Controls.Add(this.textAddress);
            this.panelAddress.Controls.Add(this.label9);
            this.panelAddress.Location = new System.Drawing.Point(3, 223);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(476, 62);
            this.panelAddress.TabIndex = 5;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(178, 15);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(218, 44);
            this.textAddress.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Address";
            // 
            // panelCountry
            // 
            this.panelCountry.Controls.Add(this.comboCountry);
            this.panelCountry.Controls.Add(this.label10);
            this.panelCountry.Location = new System.Drawing.Point(3, 291);
            this.panelCountry.Name = "panelCountry";
            this.panelCountry.Size = new System.Drawing.Size(476, 38);
            this.panelCountry.TabIndex = 6;
            // 
            // comboCountry
            // 
            this.comboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Location = new System.Drawing.Point(178, 9);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(218, 21);
            this.comboCountry.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Country";
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.textEmail);
            this.panelEmail.Controls.Add(this.label12);
            this.panelEmail.Location = new System.Drawing.Point(3, 335);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(476, 38);
            this.panelEmail.TabIndex = 8;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(178, 12);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(218, 20);
            this.textEmail.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 70;
            this.label12.Text = "Email";
            // 
            // panelPhone
            // 
            this.panelPhone.Controls.Add(this.textPhone);
            this.panelPhone.Controls.Add(this.label11);
            this.panelPhone.Location = new System.Drawing.Point(3, 379);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(476, 38);
            this.panelPhone.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "Phone";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 596);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 38);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(312, 435);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 73;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tabEditUSer
            // 
            this.tabEditUSer.Controls.Add(this.btnSearch);
            this.tabEditUSer.Controls.Add(this.dataGridView1);
            this.tabEditUSer.Controls.Add(this.cmbFilter);
            this.tabEditUSer.Controls.Add(this.label2);
            this.tabEditUSer.Controls.Add(this.txtSearchTeller);
            this.tabEditUSer.Controls.Add(this.label1);
            this.tabEditUSer.Location = new System.Drawing.Point(4, 22);
            this.tabEditUSer.Name = "tabEditUSer";
            this.tabEditUSer.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditUSer.Size = new System.Drawing.Size(775, 505);
            this.tabEditUSer.TabIndex = 1;
            this.tabEditUSer.Text = "Edit User";
            this.tabEditUSer.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(476, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 376);
            this.dataGridView1.TabIndex = 4;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "By Name",
            "By Passport",
            "By ID Number",
            "By Type"});
            this.cmbFilter.Location = new System.Drawing.Point(87, 75);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter";
            // 
            // txtSearchTeller
            // 
            this.txtSearchTeller.Location = new System.Drawing.Point(176, 36);
            this.txtSearchTeller.Name = "txtSearchTeller";
            this.txtSearchTeller.Size = new System.Drawing.Size(272, 20);
            this.txtSearchTeller.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Teller Name";
            // 
            // tabResetPassword
            // 
            this.tabResetPassword.Controls.Add(this.txtConfirmnewpass);
            this.tabResetPassword.Controls.Add(this.txtNewPass);
            this.tabResetPassword.Controls.Add(this.label8);
            this.tabResetPassword.Controls.Add(this.label7);
            this.tabResetPassword.Controls.Add(this.btnUpdatePass);
            this.tabResetPassword.Controls.Add(this.txtTellername);
            this.tabResetPassword.Controls.Add(this.label3);
            this.tabResetPassword.Location = new System.Drawing.Point(4, 22);
            this.tabResetPassword.Name = "tabResetPassword";
            this.tabResetPassword.Size = new System.Drawing.Size(775, 505);
            this.tabResetPassword.TabIndex = 2;
            this.tabResetPassword.Text = "Reset Password";
            this.tabResetPassword.UseVisualStyleBackColor = true;
            // 
            // txtConfirmnewpass
            // 
            this.txtConfirmnewpass.Location = new System.Drawing.Point(227, 201);
            this.txtConfirmnewpass.Name = "txtConfirmnewpass";
            this.txtConfirmnewpass.Size = new System.Drawing.Size(357, 20);
            this.txtConfirmnewpass.TabIndex = 10;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(227, 145);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(357, 20);
            this.txtNewPass.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter new password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Confirm new password";
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Location = new System.Drawing.Point(509, 251);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePass.TabIndex = 6;
            this.btnUpdatePass.Text = "Save";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // txtTellername
            // 
            this.txtTellername.Location = new System.Drawing.Point(227, 61);
            this.txtTellername.Name = "txtTellername";
            this.txtTellername.Size = new System.Drawing.Size(357, 20);
            this.txtTellername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Teller\'s Username";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 563);
            this.Controls.Add(this.tabControl);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAddUser.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelSurname.ResumeLayout(false);
            this.panelSurname.PerformLayout();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAddress.ResumeLayout(false);
            this.panelAddress.PerformLayout();
            this.panelCountry.ResumeLayout(false);
            this.panelCountry.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            this.tabEditUSer.ResumeLayout(false);
            this.tabEditUSer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabResetPassword.ResumeLayout(false);
            this.tabResetPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAddUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConfirmpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelCountry;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TabPage tabEditUSer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchTeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabResetPassword;
        private System.Windows.Forms.TextBox txtConfirmnewpass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.TextBox txtTellername;
        private System.Windows.Forms.Label label3;
    }
}
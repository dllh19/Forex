﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForEx.Classes;

namespace ForEx
{
    public partial class Login : Form
    {
        private SqlConnection con = new SqlConnection(Common.GetConnectionString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlCommand cmd = new SqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUsername.Text) && !(string.IsNullOrEmpty(txtPass.Text))))
            {
                con.Open();
                string query = "SELECT * FROM tbl_users  WHERE Username=@Username AND Password=@Password ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text.ToString();
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPass.Text.ToString();
                var reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(reader);
                    var Name = myTable.Rows[0]["Name"].ToString();
                    var Surname = myTable.Rows[0]["Surname"].ToString();
                    var Username = myTable.Rows[0]["Username"].ToString();
                    var UserId = Convert.ToInt32(myTable.Rows[0]["userid"]);
                    var Role = myTable.Rows[0]["role"].ToString();

                    Common.SetUser(UserId, Name, Surname, Role, Username);

                    con.Close();

                    //Audit
                    Common.Audit(Common.Operation.LoggedIn,Name + " " + Surname + " has logged into the system");

                    if (Role == "teller")
                    {
                        this.Hide();
                        var tellerform = new TellerDashboard();
                        tellerform.Show();
                    }

                    if (Role == "supervisor")
                    {
                        this.Hide();
                        var supervisorform = new frmSupervisorDashBoard();
                        supervisorform.Show();
                    }


                    if (Role == "admin")
                    {

                    }


                    if (Role == "manager")
                    {
                        this.Hide();
                        var managerform = new ManagerDashboard();
                        managerform.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Username or password entered");
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Either the username or password field is empty");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            Receipt tick = new Receipt(34234,DateTime.Now,"aera","ar",324234f,"are");
            tick.print();
        }
    }
}

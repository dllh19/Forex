using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEx
{
    public partial class UserManagement : Form
    {
        private SqlConnection con;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            /*LOG
             *Validation of phone number not good - remove for now until reviewed -David             
             */
            if (CheckName() && CheckPassword(txtPassword.Text, txtConfirmpass.Text) && CheckUsername(txtUsername.Text))
            {
                cmd = new SqlCommand("INSERT INTO tbl_users (Name, Surname, Password,Address, Country, Phone,email,Date_created,Last_login_date,role,Username) VALUES (@Name, @Surname, @Password,@Address, @Country, @Phone,@email,GETDATE(),NULL,'teller',@Username)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                //(@Name, @Surname, @Password,@Address, @Country, @Phone,@email,GETDATE(),NULL,teller)");
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                cmd.Parameters.AddWithValue("@Country", comboCountry.Text.ToString());
                cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                con.Open();
                int row = cmd.ExecuteNonQuery();
                con.Close();

                if (row > 0)
                {
                    MessageBox.Show(txtName.Text + " " + txtSurname.Text + " has been added successfully");
                    txtName.Text = string.Empty;
                    txtSurname.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    comboCountry.SelectedIndex = 0;
                    textPhone.Text = string.Empty;
                    textEmail.Text = string.Empty;
                }

            }

        }

        private bool CheckPhoneNumber()
        {
            if (Common.IsPhone(textPhone.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid phone number entered");
                return false;
            }
        }

        private bool CheckUsername(string username)
        {
            if (!(string.IsNullOrEmpty(username)))
            {
                con.Open();
                string query = "SELECT count(*) FROM tbl_users  WHERE Username=@username ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Username is already in use");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            MessageBox.Show("Username is empty");
            return false;

        }

        private bool CheckName()
        {
            if (!(string.IsNullOrEmpty(txtName.Text) && !(string.IsNullOrEmpty(txtSurname.Text))))
            {
                con.Open();
                string query = "SELECT count(*) FROM tbl_users  WHERE Name=@name AND Surname=@surname ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text.ToString();
                cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = txtSurname.Text.ToString();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Name is already in use");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            MessageBox.Show("Either name or surname field is empty");
            return false;
        }

        private bool CheckPassword(string pass1, string pass2)
        {
            if (pass1.Equals(pass2))
                return true;
            else
            {
                MessageBox.Show("Password don\'t match");
                return false;
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(Common.GetConnectionString());
            da = new SqlDataAdapter();
            cmd = new SqlCommand();

            var Countries = Common.GetCountries().country.ToDictionary(x => x.countryName, y => y.countryName).OrderBy(z => z.Key);            
            comboCountry.DataSource = new BindingSource(Countries, null);
            comboCountry.ValueMember = "Key";
            comboCountry.DisplayMember = "Value";

            comboCountry.SelectedValue = "Mauritius";
        }
    }
}

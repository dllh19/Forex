using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEx
{
    public partial class frmClientManagement : Form
    {
        public frmClientManagement()
        {
            InitializeComponent();
            populate_Type();
            populate_Nationality();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //test
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string typeValue = comboType.SelectedItem.ToString();

            if (typeValue == "Individual" && validateIndividualField() && validateCommonFields())
            {
                MessageBox.Show("good");
            }            
        }

        private void populate_Type()
        {
            comboType.Items.Add("Individual");
            comboType.Items.Add("Bank");
            comboType.Items.Add("Corporate");
            this.comboType.SelectedIndexChanged += new System.EventHandler(ComboType_SelectedIndexChanged);
        }

        private void populate_Nationality()
        {
            comboNationality.Items.Add("Mauritian");
            comboNationality.Items.Add("Foreign");

            this.comboNationality.SelectedIndexChanged += new System.EventHandler(ComboNationality_SelectedIndexChanged);
        }

        private void populate_Country()
        {
            //test2
        }

        private void ComboNationality_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //set Country to Mauritius by default in country
        }

        private void ComboType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string TypeValue = comboType.SelectedItem.ToString();
            hideAllFields();

            if (TypeValue != "Individual")
            {
                
                panelCompanyName.Visible = true;
                panelContact.Visible = true;
                panelDOB2.Visible = true;
                panelBRN.Visible = true;
                panelVAT.Visible = true;
                commonVisibleFields();

            }
            else
            {
                
                panelName.Visible = true;
                panelSurname.Visible = true;
                panelDOB.Visible = true;
                panelIDType.Visible = true;
                panelPassport.Visible = true;
                panelOccupation.Visible = true;
                commonVisibleFields();
            }
        }

        private void hideAllFields()
        {
            panelName.Visible = false;
            panelSurname.Visible = false;
            panelCompanyName.Visible = false;
            panelContact.Visible = false;
            panelDOB.Visible = false;
            panelUpload.Visible = false;
            panelVAT.Visible = false;
            panelBRN.Visible = false;
            panelNationality.Visible = false;
            panelDOB2.Visible = false;
            panelAddress.Visible = false;
            panelCountry.Visible = false;
            panelPhone.Visible = false;
            panelEmail.Visible = false;
            panelIDType.Visible = false;
            panelPassport.Visible = false;
            panelOccupation.Visible = false;

            btnAdd.Visible = false;

        }

        private void commonVisibleFields()
        {
            panelNationality.Visible = true;
            panelCountry.Visible = true;
            panelAddress.Visible = true;
            panelPhone.Visible = true;
            panelEmail.Visible = true;

            btnAdd.Visible = true;
        }

        private bool validateCommonFields()
        {
            if (textAddress.Text == "")
            {
                MessageBox.Show("Address is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textPhone.Text == "")
            {
                MessageBox.Show("Phone is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (comboNationality.SelectedItem == null)
            {
                MessageBox.Show("Please select a Nationality!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Enalbe after populating Country
            //if (comboCountry.SelectedValue == null)
            //{
            //    MessageBox.Show("Please select a country!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return false;
            //}

            if (textEmail.Text == "")
            {
                MessageBox.Show("Email is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textEmail.Text == "")
            {
                MessageBox.Show("Email is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private bool validateIndividualField()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtSurname.Text == "")
            {
                MessageBox.Show("Surname is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textIDType.Text == "")
            {
                MessageBox.Show("ID Type is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textPassport.Text == "")
            {
                MessageBox.Show("Passport/ID No is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textOccupation.Text == "")
            {
                MessageBox.Show("Occupation is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;

        }

    }
}

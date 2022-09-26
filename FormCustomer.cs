using HiTechLibrary.Business;
using HiTechLibrary.DataAccess;
using HiTechLibrary.VALIDATION;
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

namespace FINAL_PROJECT.GUI
{
    public partial class FormCustomer : Form
    {
        SqlDataAdapter da;
        DataSet dsCustomerDB;
        DataTable dtCustomers;
        SqlCommandBuilder sqlBuilder; //build up insert/update/delete
        Customer aCustomer = new Customer();

        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            // create dataset object
            dsCustomerDB = new DataSet("CustomerDS");
            // create a datatable object
            dtCustomers = new DataTable("Customers");
            dsCustomerDB.Tables.Add(dtCustomers); // adding datatable to dataset
            // create a column and add column to datatable
            dtCustomers.Columns.Add("CustomerId", typeof(Int32));
            dtCustomers.Columns.Add("CustomerName", typeof(String));
            dtCustomers.Columns.Add("StreetAddress", typeof(String));
            dtCustomers.Columns.Add("City", typeof(String));
            dtCustomers.Columns.Add("PostalCode", typeof(String));
            dtCustomers.Columns.Add("PhoneNumber", typeof(String));
            dtCustomers.Columns.Add("FaxNumber", typeof(String));
            dtCustomers.Columns.Add("CreditLimit", typeof(Decimal));
            dtCustomers.Columns.Add("Email", typeof(String));
            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerId"] };
            dtCustomers.Columns["CustomerId"].AutoIncrement = true;
            dtCustomers.Columns["CustomerId"].AutoIncrementSeed = 1111;
            dtCustomers.Columns["CustomerId"].AutoIncrementStep = 1; // auto increment by 1

            da = new SqlDataAdapter("select * from Customers", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
            da.Fill(dsCustomerDB.Tables["Customers"]);
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string inputCustomerId = textBoxId.Text.Trim();
            string inputPhoneNumber = textBoxPhoneNumber.Text.Trim();
            if ((Validator.IsValidNumber(inputCustomerId, 4)) && aCustomer.IdExists(int.Parse(inputCustomerId))
               && (Validator.IsValidName(textBoxName.Text.Trim()))
               && (Validator.HasValue(textBoxStreetAddress.Text.Trim()))
               && (Validator.HasValue(textBoxCity.Text.Trim()))
               && (Validator.HasValue(textBoxPostalCode.Text.Trim()))
               && (Validator.IsValidNumber(inputPhoneNumber, 14))
               && (Validator.IsValidNumber(textBoxFaxNumber.Text.Trim(), 13))
               && (Validator.IsValidCredit(textBoxCreditLimit.Text.Trim(), 5)) &&
               (Validator.IsValidEmail(textBoxCustomerEmail.Text.Trim())))
            {
                int searchId = Convert.ToInt32(textBoxId.Text);
                DataRow dr = dtCustomers.Rows.Find(searchId);
                if (dr != null)
                {
                    dr["CustomerName"] = textBoxName.Text.Trim();
                    dr["StreetAddress"] = textBoxStreetAddress.Text.Trim();
                    dr["City"] = textBoxCity.Text.Trim();
                    dr["PostalCode"] = textBoxPostalCode.Text.Trim();
                    dr["PhoneNumber"] = textBoxPhoneNumber.Text.Trim();
                    dr["FaxNumber"] = textBoxFaxNumber.Text.Trim();
                    dr["CreditLimit"] = textBoxCreditLimit.Text.Trim();
                    dr["Email"] = textBoxCustomerEmail.Text.Trim();
                    MessageBox.Show(dr.RowState.ToString(), "RowState in Datatable.");
                }
                else
                {
                    MessageBox.Show("Customer Not Found!", "Invalid Customer Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxId.Clear();
                    textBoxId.Focus();
                    return;

                }
            }
            else
            {
                if (!(Validator.IsValid(inputCustomerId, 4)) || !aCustomer.IdExists(int.Parse(inputCustomerId)))
                {
                    MessageBox.Show("Please, enter valid CustomeriD of 4 digit.", "Invalid CustomerId", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxId.Clear();
                    textBoxId.Focus();
                    return;
                }

                if (!(Validator.IsValidName(textBoxName.Text.Trim())))
                {
                    MessageBox.Show("Name must conatins only letters or space(s) to separate FirstName components.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxName.Clear();
                    textBoxName.Focus();
                    return;
                }



                if (!(Validator.HasValue(textBoxStreetAddress.Text.Trim())))
                {
                    MessageBox.Show("Please, enter valid Street address.", "Invalid Street Address!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxStreetAddress.Clear();
                    textBoxStreetAddress.Focus();
                    return;

                }

                if (!(Validator.HasValue(textBoxCity.Text.Trim())))
                {
                    MessageBox.Show("Please, enter valid City.", "Invalid City!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxCity.Clear();
                    textBoxCity.Focus();
                    return;

                }

                if (!(Validator.HasValue(textBoxPostalCode.Text.Trim())))
                {
                    MessageBox.Show("Please, enter valid Postal Code.", "Invalid Postal Code!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPostalCode.Clear();
                    textBoxPostalCode.Focus();
                    return;

                }

                if (!(Validator.IsValidNumber(inputPhoneNumber, 14)))
                {
                    MessageBox.Show("Please, enter valid PhoneNumber.", "Invalid PhoneNumber!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPhoneNumber.Clear();
                    textBoxPhoneNumber.Focus();
                    return;

                }

                if (!(Validator.IsValidNumber(textBoxFaxNumber.Text.Trim(), 13)))
                {
                    MessageBox.Show("Please, enter valid FaxNumber..", "Invalid FaxNumber", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxFaxNumber.Clear();
                    textBoxFaxNumber.Focus();
                    return;
                }

                if (!(Validator.IsValidNumber(textBoxCreditLimit.Text.Trim(), 5)))
                {
                    MessageBox.Show("Please, enter valid Credit Limit..", "Invalid Credit Limit", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxCreditLimit.Clear();
                    textBoxCreditLimit.Focus();
                    return;
                }

                string inputEmail = textBoxCustomerEmail.Text.Trim();
                if (!(Validator.IsValidEmail(inputEmail)))
                {
                    MessageBox.Show("Please, enter valid email address.", "Invalid Email Address!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxCustomerEmail.Clear();
                    textBoxCustomerEmail.Focus();
                    return;

                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string inputCustomerId = textBoxId.Text.Trim();
            if (!(Validator.IsValid(inputCustomerId, 4)) || !aCustomer.IdExists(int.Parse(inputCustomerId)))
            {
                MessageBox.Show("Please, enter valid CustomeriD of 4 digit.", "Invalid CustomerId", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxId.Clear();
                textBoxId.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete This Customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    // you have to check the course registered by this student
                    int sId = Convert.ToInt32(textBoxId.Text.Trim());
                    DataRow dr = dtCustomers.Rows.Find(sId);
                    if (dr != null)
                    {
                        dr.Delete();
                        MessageBox.Show(dr.RowState.ToString(), "RowState in Datatable.");
                    }
                    else
                    {
                        MessageBox.Show("No Customer Id found!", "Invalid Customer Id");
                    }
                }
            }
        }

        private void buttonListCustomerFromDB_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();
            dataGridViewCustomerFromDB.DataSource = aCustomer.GetCustomerList();
        }

        private void buttonCustomerList_Click(object sender, EventArgs e)
        {
            da.Fill(dsCustomerDB.Tables["Customers"]);
            dataGridViewCustomerFromDS.DataSource = dsCustomerDB.Tables["Customers"];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValid(textBoxSearch.Text.Trim(), 4) || !aCustomer.IdExists(int.Parse(textBoxSearch.Text.Trim())))
            {
                MessageBox.Show("Customer Id must conatins 4 digits or it is not valid.", "Invalid Customer Id", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxSearch.Clear();
                textBoxSearch.Focus();
                return;
            }

            int searchId = Convert.ToInt32(textBoxSearch.Text.Trim());
            DataRow dr = dtCustomers.Rows.Find(searchId);
            if (dr != null)
            {
                textBoxId.Text = dr["CustomerID"].ToString();
                textBoxName.Text = dr["CustomerName"].ToString();
                textBoxStreetAddress.Text = dr["StreetAddress"].ToString();
                textBoxCity.Text = dr["City"].ToString();
                textBoxPhoneNumber.Text = dr["PhoneNumber"].ToString();
                textBoxFaxNumber.Text = dr["FaxNumber"].ToString();
                textBoxPostalCode.Text = dr["PostalCode"].ToString();
                textBoxCreditLimit.Text = dr["CreditLimit"].ToString();
                textBoxCustomerEmail.Text = dr["Email"].ToString();

            }
            else
            {
                MessageBox.Show("Customer Not Found!", "Invalid Customer Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearch.Clear();
                textBoxSearch.Focus();

            }
        }

        private void buttonUpdateDatabase_Click(object sender, EventArgs e)
        {
            da.Update(dsCustomerDB.Tables["Customers"]);
            MessageBox.Show("Database has been updated successfully", "Database Updated");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Quit This Application?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}

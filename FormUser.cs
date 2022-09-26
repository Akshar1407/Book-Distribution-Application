using HiTechLibrary.Business;
using HiTechLibrary.DataAccess;
using HiTechLibrary.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT.GUI
{
    public partial class FormUser : Form
    {
        List<Employee> listE;
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            User us = new User();
            string input = textBoxUserId.Text.Trim();

            if (Validator.IsValidId(input, 4) && !us.IdExists(int.Parse(input)) &&
                Validator.GetId(comboBoxEmployeeId.Text.Trim()) > 0 &&
                textBoxPassword.Text.Trim().Length > 0)
            {
                us.UserID = Convert.ToInt32(textBoxUserId.Text.Trim());
                us.Password = textBoxPassword.Text.Trim();
                us.EmployeeId = Validator.GetId(comboBoxEmployeeId.Text.Trim());
                us.SaveUser(us);
                MessageBox.Show("User Saved", "Saved");

                ClearFields();
            }
            else
            {
                if (!Validator.IsValidId(input, 4) || us.IdExists(int.Parse(input)))
                {
                    MessageBox.Show("Invalid User Id or it already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxUserId.Clear();
                    textBoxUserId.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxEmployeeId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Employee Id Not Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxEmployeeId.Focus();
                    return;
                }
                if (textBoxPassword.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please enter valid password!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPassword.Clear();
                    textBoxPassword.Focus();
                    return;
                }
            }
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            User us = new User();

            string input = textBoxUserId.Text;
            if (Validator.IsValidId(input, 4) && us.IdExists(int.Parse(input)) &&
                Validator.GetId(comboBoxEmployeeId.Text.Trim()) > 0 &&
                textBoxPassword.Text.Trim().Length > 0)
            {

                us.UserID = int.Parse(textBoxUserId.Text.Trim());
                us.Password = textBoxPassword.Text.Trim();
                us.EmployeeId = Validator.GetId((comboBoxEmployeeId.Text.Trim()));
                us.UpdateUserRecord(us);


                textBoxUserId.Text = Convert.ToString(us.UserID);
                textBoxPassword.Text = us.Password.ToString();
                comboBoxEmployeeId.Text = Convert.ToString(us.EmployeeId);

                MessageBox.Show("User updated", "Updated");

                ClearFields();

            }
            else
            {

                if (!Validator.IsValidId(input, 4) || us.IdExists(int.Parse(input)))
                {
                    MessageBox.Show("Invalid User Id or it already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxUserId.Clear();
                    textBoxUserId.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxEmployeeId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Employee Id Not Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxEmployeeId.Focus();
                    return;
                }
                if (textBoxPassword.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please enter valid password!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPassword.Clear();
                    textBoxPassword.Focus();
                    return;
                }


            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                User us = new User();

                string input = textBoxUserId.Text.Trim();
                if (!Validator.IsValidId(input, 4) && !us.IdExists(int.Parse(input)))
                {
                    MessageBox.Show("Invalid User Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxUserId.Clear();
                    textBoxUserId.Focus();
                }
                else
                {
                    us.UserID = int.Parse(textBoxUserId.Text.Trim());
                    UserDB.DeleteUserRecord(us);
                    MessageBox.Show("User Deleted", "Deleted");

                    ClearFields();

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                checkBox1.Text = "Hide";
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                checkBox1.Text = "Show";
            }
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            User us = new User();

            if (comboBoxUserSearchOption.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the search option.", "Missing search option", MessageBoxButtons.OK);
                return;
            }

            String input = textBoxInputUser.Text.Trim();



            if (comboBoxUserSearchOption.SelectedIndex == 1)
            {
                if (!Validator.IsValidId(input, 4))
                {
                    MessageBox.Show("Invalid Employee Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxInputUser.Clear();
                    textBoxInputUser.Focus();
                    return;
                }
                List<User> listU = us.SearchUserRecordWithEmployeeId(int.Parse(input));
                if (listU != null && listU.Count > 0)
                {
                    listViewUser.Items.Clear();
                    ClearFields();

                    foreach (User aUs in listU)
                    {
                        Employee employee = GetEmployee(aUs.EmployeeId);
                        ListViewItem item = new ListViewItem(aUs.UserID.ToString());
                        item.SubItems.Add(aUs.EmployeeId.ToString());
                        item.SubItems.Add(employee.FirstName);
                        item.SubItems.Add(employee.LastName);
                        listViewUser.Items.Add(item);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Employee Not Found", "Error", MessageBoxButtons.OK);
                    textBoxInputUser.Clear();
                    textBoxInputUser.Focus();
                    return;
                }
            }
            else
            {
                listViewUser.Items.Clear();
                ClearFields();
                if (!Validator.IsValidId(input, 4))
                {
                    MessageBox.Show("Invalid User Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxInputUser.Clear();
                    textBoxInputUser.Focus();
                    return;
                }
                us = us.SearchUserRecord(Convert.ToInt32(input));
                if (us != null)
                {


                    foreach (var i in listE)
                    {
                        if (i.EmployeeId == us.EmployeeId)
                        {
                            comboBoxEmployeeId.SelectedItem = i.EmployeeId.ToString() + " -> " + i.FirstName + " " + i.LastName;
                        }
                    }

                    textBoxUserId.Text = Convert.ToString(us.UserID);
                    textBoxPassword.Text = us.Password;
                    comboBoxEmployeeId.Text = Convert.ToString(us.EmployeeId);

                    Employee employee = GetEmployee(us.EmployeeId);
                    ListViewItem item = new ListViewItem(us.UserID.ToString());
                    item.SubItems.Add(us.EmployeeId.ToString());
                    item.SubItems.Add(employee.FirstName);
                    item.SubItems.Add(employee.LastName);
                    listViewUser.Items.Add(item);

                }
                else
                {
                    MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK);
                    textBoxInputUser.Clear();
                    textBoxInputUser.Focus();
                    return;
                }
            }
        }

        private void ClearFields()
        {
            textBoxUserId.Clear();
            textBoxPassword.Clear();
            comboBoxEmployeeId.SelectedIndex = -1;
            textBoxInputUser.Clear();
        }

        private void buttonListAllUser_Click(object sender, EventArgs e)
        {
            User us = new User();
            List<User> listUs = us.GetAllUser();
            listViewUser.Items.Clear();

            foreach (User aUs in listUs)
            {
                Employee employee = GetEmployee(aUs.EmployeeId);
                ListViewItem item = new ListViewItem(aUs.UserID.ToString());
                item.SubItems.Add(aUs.EmployeeId.ToString());
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                listViewUser.Items.Add(item);

            }
        }

        private Employee GetEmployee(int eId)
        {
            foreach (var item in listE)
            {
                if (item.EmployeeId == eId)
                {
                    return item;
                }

            }

            return null;

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            listE = emp.GetEmployeeList();

            if (listE != null && listE.Count > 0)
            {
                foreach (var item in listE)
                {
                    comboBoxEmployeeId.Items.Add(item.JobId + " -> " + item.FirstName + " " + item.LastName);
                }
            }
        }

        private void comboBoxUserSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxUserSearchOption.SelectedIndex;
            switch (comboBoxUserSearchOption.SelectedIndex)
            {
                case 0:
                    labelUserMessage.Text = "Please, Enter User Id";
                    textBoxInputUser.Clear();
                    textBoxInputUser.Focus();
                    break;
                case 1:
                    labelUserMessage.Text = "Please, Enter Employee Id";
                    textBoxInputUser.Clear();
                    textBoxInputUser.Focus();
                    break;
                default:
                    break;
            }
        }

        private void buttonExitUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

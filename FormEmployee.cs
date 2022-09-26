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
    public partial class FormEmployee : Form
    {
        List<JobPosition> listJ;
        List<Status> listS;
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            JobPosition jb = new JobPosition();
            listJ = jb.GetList();

            if (listJ != null && listJ.Count > 0)
            {
                foreach (var item in listJ)
                {
                    comboBoxJobId.Items.Add(item.JobId + " -> " + item.JobTitle);
                }
            }

            Status st = new Status();
            listS = st.GetList();

            if (listS != null && listS.Count > 0)
            {
                foreach (var item in listS)
                {
                    comboBoxStatusId.Items.Add(item.StatusId + " -> " + item.State);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            string input = textBoxEmployeeId.Text.Trim();
            if (Validator.IsValidId(input, 4) && !emp.IdExists(int.Parse(input)) &&
                (Validator.IsValidName(textBoxFirstName.Text.Trim())) &&
                (Validator.IsValidName(textBoxLastName.Text.Trim())) &&
                (Validator.IsValidNumber(textBoxPhoneNumber.Text.Trim(), 14)) &&
                (Validator.IsValidEmail(textBoxEmail.Text.Trim())) &&
                (Validator.GetId(comboBoxJobId.Text.Trim()) > 0) &&
                (Validator.GetId(comboBoxStatusId.Text.Trim()) > 0))
            {
                emp.EmployeeId = int.Parse(textBoxEmployeeId.Text.Trim());
                emp.FirstName = textBoxFirstName.Text.Trim();
                emp.LastName = textBoxLastName.Text.Trim();
                emp.PhoneNumber = textBoxPhoneNumber.Text.Trim();
                emp.Email = textBoxEmail.Text.Trim();
                emp.JobId = Validator.GetId(comboBoxJobId.Text.Trim());
                emp.StatusId = Validator.GetId(comboBoxStatusId.Text.Trim());

                emp.SaveEmployee(emp);
                MessageBox.Show("Employee Saved", "Saved");

                ClearTextBoxes();
            }
            else
            {
                if (!Validator.IsValidId(textBoxEmployeeId.Text.Trim(), 4) || emp.IdExists(int.Parse(input)))
                {
                    MessageBox.Show("Invalid Employee Id or it already exist, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxEmployeeId.Clear();
                    textBoxEmployeeId.Focus();
                    return;
                }
                if (!Validator.IsValidName(textBoxFirstName.Text.Trim()))
                {
                    MessageBox.Show("Invalid First tName , please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxFirstName.Clear();
                    textBoxFirstName.Focus();
                    return;
                }
                if (!Validator.IsValidName(textBoxLastName.Text.Trim()))
                {
                    MessageBox.Show("Invalid Last Name , please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxLastName.Clear();
                    textBoxLastName.Focus();
                    return;
                }
                if (!(Validator.IsValidNumber(textBoxPhoneNumber.Text.Trim(), 14)))
                {
                    MessageBox.Show("Invalid Phone Number, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPhoneNumber.Clear();
                    textBoxPhoneNumber.Focus();
                    return;
                }
                if (!Validator.IsValidEmail(textBoxEmail.Text.Trim()))
                {
                    MessageBox.Show("Invalid Email, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxEmail.Clear();
                    textBoxEmail.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxJobId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Job ID not selected, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxJobId.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxStatusId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Status ID not selected, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxJobId.Focus();
                    return;
                }


            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            string input = textBoxEmployeeId.Text.Trim();
            if (Validator.IsValidId(input, 4) && emp.IdExists(int.Parse(input)) &&
               (Validator.IsValidName(textBoxFirstName.Text.Trim())) &&
               (Validator.IsValidName(textBoxLastName.Text.Trim())) &&
               (Validator.IsValidNumber(textBoxPhoneNumber.Text.Trim(), 14)) &&
               (Validator.IsValidEmail(textBoxEmail.Text.Trim())) &&
               (Validator.GetId(comboBoxJobId.Text.Trim()) > 0) &&
               (Validator.GetId(comboBoxStatusId.Text.Trim()) > 0))
            {
                emp.EmployeeId = int.Parse(textBoxEmployeeId.Text.Trim());
                emp.FirstName = textBoxFirstName.Text.Trim();
                emp.LastName = textBoxLastName.Text.Trim();
                emp.PhoneNumber = textBoxPhoneNumber.Text.Trim();
                emp.Email = textBoxEmail.Text.Trim();
                emp.JobId = Validator.GetId(comboBoxJobId.Text.Trim());
                emp.StatusId = Validator.GetId(comboBoxStatusId.Text.Trim());
                emp.UpdateRecord(emp);
                MessageBox.Show("Employee updated", "Updated");

                ClearTextBoxes();
            }
            else
            {
                if (!Validator.IsValidId(textBoxEmployeeId.Text.Trim(), 4) || !emp.IdExists(int.Parse(input)))
                {
                    MessageBox.Show("Invalid Employee Id or it does not exist, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxEmployeeId.Clear();
                    textBoxEmployeeId.Focus();
                    return;
                }
                if (!Validator.IsValidName(textBoxFirstName.Text.Trim()))
                {
                    MessageBox.Show("Invalid First tName , please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxFirstName.Clear();
                    textBoxFirstName.Focus();
                    return;
                }
                if (!Validator.IsValidName(textBoxLastName.Text.Trim()))
                {
                    MessageBox.Show("Invalid Last Name , please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxFirstName.Clear();
                    textBoxFirstName.Focus();
                    return;
                }
                if (!Validator.IsValidNumber(textBoxPhoneNumber.Text.Trim(), 14))
                {
                    MessageBox.Show("Invalid Phone Number, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPhoneNumber.Clear();
                    textBoxPhoneNumber.Focus();
                    return;
                }
                if (!Validator.IsValidEmail(textBoxEmail.Text.Trim()))
                {
                    MessageBox.Show("Invalid Email, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxEmail.Clear();
                    textBoxEmail.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxJobId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Job ID not selected, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxJobId.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxStatusId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Status ID not selected, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxJobId.Focus();
                    return;
                }


            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            string input = textBoxEmployeeId.Text.Trim();
            if (!Validator.IsValidId(input, 4) && !emp.IdExists(int.Parse(input)))
            {
                MessageBox.Show("Invalid Employee Id or it does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }
            else
            {
                emp.EmployeeId = int.Parse(textBoxEmployeeId.Text.Trim());
                EmployeeDB.DeleteRecord(emp);
                MessageBox.Show("Employee Deleted", "Deleted");

                ClearTextBoxes();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            if (comboBoxSearchOption.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the search option.", "Missing search option", MessageBoxButtons.OK);
                return;
            }
            string input = textBoxInput.Text.Trim();

            if (comboBoxSearchOption.SelectedIndex == 1)
            {
                if (!Validator.IsValidName(input))
                {
                    MessageBox.Show("Invalid First tName , please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }
                List<Employee> listEmpFirst = emp.Search_Employee(input);
                if (listEmpFirst != null && listEmpFirst.Count > 0)
                {
                    listView.Items.Clear();
                    ClearTextBoxes();

                    foreach (Employee anEmp in listEmpFirst)
                    {
                        ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                        item.SubItems.Add(anEmp.FirstName);
                        item.SubItems.Add(anEmp.LastName);
                        item.SubItems.Add(anEmp.PhoneNumber);
                        item.SubItems.Add(anEmp.Email);
                        item.SubItems.Add(GetJobTitle(anEmp.JobId.ToString()));
                        item.SubItems.Add(GetStatusTitle(anEmp.StatusId.ToString()));
                        listView.Items.Add(item);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Employee Not Found", "Error", MessageBoxButtons.OK);
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }

            }
            else
            {
                if (!Validator.IsValidId(input, 4) || !emp.IdExists(int.Parse(input)))
                {
                    MessageBox.Show("Invalid Employee Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }
                listView.Items.Clear();
                ClearTextBoxes();

                emp = emp.SearchEmployee(Convert.ToInt32(input));
                if (emp != null)
                {

                    textBoxEmployeeId.Text = Convert.ToString(emp.EmployeeId);
                    textBoxFirstName.Text = emp.FirstName;
                    textBoxLastName.Text = emp.LastName;
                    textBoxPhoneNumber.Text = emp.PhoneNumber;
                    textBoxEmail.Text = emp.Email;
                    foreach (var i in listJ)
                    {
                        if (i.JobId == emp.JobId)
                        {
                            comboBoxJobId.SelectedItem = emp.JobId.ToString() + " -> " + i.JobTitle;
                        }
                    }
                    foreach (var j in listS)
                    {
                        if (j.StatusId == emp.StatusId)
                        {
                            comboBoxStatusId.SelectedItem = emp.StatusId.ToString() + " -> " + j.State;
                        }
                    }



                    ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                    item.SubItems.Add(emp.FirstName);
                    item.SubItems.Add(emp.LastName);
                    item.SubItems.Add(emp.PhoneNumber);
                    item.SubItems.Add(emp.Email);
                    item.SubItems.Add(GetJobTitle(emp.JobId.ToString()));
                    item.SubItems.Add(GetStatusTitle(emp.StatusId.ToString()));
                    listView.Items.Add(item);



                }
                else
                {
                    MessageBox.Show("Employee Not Found", "Error", MessageBoxButtons.OK);
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }
            }
        }

        private void ClearTextBoxes()
        {
            textBoxEmployeeId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            comboBoxJobId.SelectedIndex = -1;
            comboBoxStatusId.SelectedIndex = -1;
        }


        private string GetJobTitle(String id)
        {
            foreach (var j in listJ)
            {
                if (int.Parse(id) == j.JobId)
                {
                    return j.JobTitle;
                }
            }
            return "";
        }

        private string GetStatusTitle(String id)
        {
            foreach (var j in listS)
            {
                if (int.Parse(id) == j.StatusId)
                {
                    return j.State;
                }
            }
            return "";
        }

        private void buttonListAllEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp = emp.GetEmployeeList();
            listView.Items.Clear();

            foreach (Employee anEmp in listEmp)
            {

                ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                item.SubItems.Add(anEmp.FirstName);
                item.SubItems.Add(anEmp.LastName);
                item.SubItems.Add(anEmp.PhoneNumber);
                item.SubItems.Add(anEmp.Email);
                item.SubItems.Add(GetJobTitle(anEmp.JobId.ToString()));
                item.SubItems.Add(GetStatusTitle(anEmp.StatusId.ToString()));
                listView.Items.Add(item);


            }
        }

        private void comboBoxSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxSearchOption.SelectedIndex;
            switch (comboBoxSearchOption.SelectedIndex)
            {
                case 0:
                    labelUserMessage.Text = "Please, Enter Employee Id";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 1:
                    labelUserMessage.Text = "Please, Enter First Name";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                default:
                    break;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

using HiTechLibrary.Business;
using System;
using HiTechLibrary.VALIDATION;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT.GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void formUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.ShowDialog();
        }

        private void formEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.ShowDialog();
        }

        private void module3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventoryManagement moduleInventoryManagement = new FormInventoryManagement();
            moduleInventoryManagement.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void module4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerOrders formCustomerOrders = new FormCustomerOrders();
            formCustomerOrders.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User us = new User();
            string id = textBoxUserId.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            if (HiTechLibrary.VALIDATION.Validator.IsValidId(id, 4) && us.IdExists(int.Parse(id))
                && password.Length > 0)
            {
                us.UserID = int.Parse(id);
                us.Password = password;
                int jId = us.LoginUser(Convert.ToInt32(id), password);              

                if (jId == 1111)
                {
                    FormMainMenu mainMenu = new FormMainMenu();
                    mainMenu.ShowDialog();
                }
                else if (jId == 1112)
                {
                    FormCustomer formCustomer = new FormCustomer();
                    formCustomer.ShowDialog();
                }
                else if (jId == 1113)
                {
                    FormInventoryManagement moduleInventoryManagement = new FormInventoryManagement();
                    moduleInventoryManagement.ShowDialog();
                }
                else if (jId == 1114)
                {
                    FormCustomerOrders formCustomerOrders = new FormCustomerOrders();
                    formCustomerOrders.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong User id or password", "Error");
                }                
            }
            else
            {
                if (!HiTechLibrary.VALIDATION.Validator.IsValidId(id, 4) || 
                    !us.IdExists(int.Parse(id)))
                {
                    MessageBox.Show("Invalid User Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxUserId.Clear();
                    textBoxUserId.Focus();
                    return;
                }

                if (password.Length == 0)
                {
                    MessageBox.Show("Please enter valid password!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPassword.Clear();
                    textBoxPassword.Focus();
                    return;
                }
            }

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

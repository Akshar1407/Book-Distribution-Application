using FINAL_PROJECT.MODEL;
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
    public partial class FormCustomerOrders : Form
    {
        Final_Project_Multi_TierEntities db = new Final_Project_Multi_TierEntities();
        List<Employee> listE;
        List<Status> listS;
        List<Customer> listC;

        public FormCustomerOrders()
        {
            InitializeComponent();
        }

        public bool IsDuplicateId(int id)
        {
            Order ord = db.Orders.Find(id);
            if (ord != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ClearTextBoxes()
        {
            textBoxOrderId.Clear();
            textBoxOrderType.Clear();
            textBoxPayment.Clear();
            textBoxInput.Clear();
            dateTimePickerOrderDate.Value = DateTime.Now;
            dateTimePickerRequiredDate.Value = DateTime.Now;
            dateTimePickerShippingDate.Value = DateTime.Now;
            comboBoxStatusId.SelectedIndex = -1;
            comboBoxCustomerId.SelectedIndex = -1;
            comboBoxEmployeeId.SelectedIndex = -1;
            comboBoxSearchOption.SelectedIndex = -1;
        }
        private void FormCustomerOrders_Load(object sender, EventArgs e)
        {

            listE = (from emp in db.Employees
                     select emp).ToList<Employee>();

            foreach (var item in listE)
            {
                comboBoxEmployeeId.Items.Add(item.EmployeeId + " -> " +
                                           item.FirstName + " " +
                                           item.LastName);
            }

            listS = (from prj in db.Status
                     select prj).ToList<Status>();

            foreach (var item in listS)
            {
                comboBoxStatusId.Items.Add(item.StatusId + " -> " +
                                          item.State);
            }

            listC = (from prj in db.Customers
                     select prj).ToList<Customer>();

            foreach (var item in listC)
            {
                comboBoxCustomerId.Items.Add(item.CustomerId + " -> " +
                                          item.CustomerName);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            string input = textBoxOrderId.Text.Trim();
            string inputOrder = textBoxOrderType.Text.Trim();
            if (Validator.IsValidNumber(input, 4) &&
                !IsDuplicateId(Convert.ToInt32(input)) &&
                Validator.IsValidName(inputOrder) &&
                Validator.IsValidDouble(textBoxPayment.Text.Trim()))
            {
                ord.OrderId = Convert.ToInt32(textBoxOrderId.Text.Trim());
                ord.OrderDate = Convert.ToDateTime(dateTimePickerOrderDate.Text.Trim());
                ord.OrderType = inputOrder;
                ord.RequiredDate = Convert.ToDateTime(dateTimePickerRequiredDate.Text.Trim());
                ord.ShippingDate = Convert.ToDateTime(dateTimePickerShippingDate.Text.Trim());
                ord.StatusId = Validator.GetId(comboBoxStatusId.Text.Trim());
                ord.CustomerId = Validator.GetId(comboBoxCustomerId.Text.Trim());
                ord.EmployeeId = Validator.GetId(comboBoxEmployeeId.Text.Trim());
                ord.Payment = Convert.ToDecimal(textBoxPayment.Text.Trim());
                db.Orders.Add(ord);
                db.SaveChanges();
                ClearTextBoxes();
                MessageBox.Show("Order info has been saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Validator.IsValidNumber(input, 4) || IsDuplicateId(Convert.ToInt32(input)))
                {
                    MessageBox.Show("Invalid Order Id or it already exist, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxOrderId.Clear();
                    textBoxOrderId.Focus();
                    return;
                }
                if (!Validator.IsValidName(inputOrder))
                {
                    MessageBox.Show("Invalid Order Type, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxOrderType.Clear();
                    textBoxOrderType.Focus();
                    return;
                }
                if (!Validator.IsValidDouble(textBoxPayment.Text.Trim()))
                {
                    MessageBox.Show("Invalid payment amount, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPayment.Clear();
                    textBoxPayment.Focus();
                    return;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string input = textBoxOrderId.Text.Trim();
            string inputOrder = textBoxOrderType.Text.Trim();
            if (Validator.IsValidNumber(input, 4) &&
                IsDuplicateId(Convert.ToInt32(input)) &&
                Validator.IsValidName(inputOrder) &&
                Validator.IsValidDouble(textBoxPayment.Text.Trim()))
            {
                var orderId = Convert.ToInt32(input);
                var ord = db.Orders.SingleOrDefault(o => o.OrderId == orderId);
                if (ord != null)
                {
                    ord.OrderDate = Convert.ToDateTime(dateTimePickerOrderDate.Text.Trim());
                    ord.OrderType = inputOrder;
                    ord.RequiredDate = Convert.ToDateTime(dateTimePickerRequiredDate.Text.Trim());
                    ord.ShippingDate = Convert.ToDateTime(dateTimePickerShippingDate.Text.Trim());
                    ord.StatusId = Validator.GetId(comboBoxStatusId.Text.Trim());
                    ord.CustomerId = Validator.GetId(comboBoxCustomerId.Text.Trim());
                    ord.EmployeeId = Validator.GetId(comboBoxEmployeeId.Text.Trim());
                    ord.Payment = Convert.ToDecimal(textBoxPayment.Text.Trim());
                    db.SaveChanges();
                    ClearTextBoxes();
                    MessageBox.Show("Order info has been Updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (!Validator.IsValidNumber(input, 4) || !IsDuplicateId(Convert.ToInt32(input)))
                {
                    MessageBox.Show("Invalid Order Id or it doesn't exist, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxOrderId.Clear();
                    textBoxOrderId.Focus();
                    return;
                }
                if (!Validator.IsValidName(inputOrder))
                {
                    MessageBox.Show("Invalid Order Type, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxOrderType.Clear();
                    textBoxOrderType.Focus();
                    return;
                }
                if (!Validator.IsValidDouble(textBoxPayment.Text.Trim()))
                {
                    MessageBox.Show("Invalid payment amount, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPayment.Clear();
                    textBoxPayment.Focus();
                    return;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string input = textBoxOrderId.Text.Trim();
            string inputOrder = textBoxOrderType.Text.Trim();
            if (Validator.IsValidNumber(input, 4) &&
                IsDuplicateId(Convert.ToInt32(input)))
            {
                var orderId = Convert.ToInt32(input);
                var ord = db.Orders.SingleOrDefault(o => o.OrderId == orderId);
                if (ord != null)
                {
                    db.Orders.Remove(ord);
                    db.SaveChanges();
                    MessageBox.Show("Order info has been Deleted successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearTextBoxes();
            }
            else
            {
                if (!Validator.IsValidNumber(input, 4) || !IsDuplicateId(Convert.ToInt32(input)))
                {
                    MessageBox.Show("Invalid Order Id or it doesn't exist, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxOrderId.Clear();
                    textBoxOrderId.Focus();
                    return;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Order ord = new Order();

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
                    MessageBox.Show("Invalid Order Type, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }

                List<Order> list = (from o in db.Orders
                                    where o.OrderType == input
                                    select o).ToList<Order>();

                if (list != null && list.Count > 0)
                {
                    listView.Items.Clear();
                    ClearTextBoxes();

                    foreach (Order abk in list)
                    {
                        ListViewItem item = new ListViewItem(abk.OrderId.ToString());
                        item.SubItems.Add(abk.OrderDate.ToString());
                        item.SubItems.Add(abk.OrderType);
                        item.SubItems.Add(abk.RequiredDate.ToString());
                        item.SubItems.Add(abk.ShippingDate.ToString());
                        item.SubItems.Add(abk.StatusId.ToString());
                        item.SubItems.Add(abk.CustomerId.ToString());
                        item.SubItems.Add(abk.EmployeeId.ToString());
                        item.SubItems.Add(abk.Payment.ToString());
                        listView.Items.Add(item);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Order Not Found", "Error", MessageBoxButtons.OK);
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }

            }
            else
            {

                if (!Validator.IsValidNumber(input, 4) || !IsDuplicateId((Convert.ToInt32(input))))
                {
                    MessageBox.Show("Invalid Order ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }
                listView.Items.Clear();
                ord = db.Orders.Find(Convert.ToInt32(input));
                if (ord != null)
                {
                    textBoxOrderId.Text = (ord.OrderId.ToString());
                    dateTimePickerOrderDate.Text = (ord.OrderDate.ToString());
                    textBoxOrderType.Text = (ord.OrderType);
                    dateTimePickerRequiredDate.Text = (ord.RequiredDate.ToString());
                    dateTimePickerShippingDate.Text = (ord.ShippingDate.ToString());
                    comboBoxStatusId.Text = (ord.StatusId.ToString());
                    comboBoxCustomerId.Text = (ord.CustomerId.ToString());
                    comboBoxEmployeeId.Text = (ord.EmployeeId.ToString());
                    textBoxPayment.Text = (ord.Payment.ToString());


                    foreach (var i in listE)
                    {
                        comboBoxEmployeeId.SelectedItem = i.EmployeeId + " -> " +
                                                   i.FirstName + " " +
                                                   i.LastName;
                    }

                    foreach (var i in listS)
                    {
                        comboBoxStatusId.SelectedItem = i.StatusId + " -> " +
                                                  i.State;
                    }


                    foreach (var i in listC)
                    {
                        comboBoxCustomerId.SelectedItem = i.CustomerId + " -> " +
                                                  i.CustomerName;
                    }

                    listView.Items.Clear();

                    ListViewItem item = new ListViewItem(ord.OrderId.ToString());
                    item.SubItems.Add(ord.OrderDate.ToString());
                    item.SubItems.Add(ord.OrderType);
                    item.SubItems.Add(ord.RequiredDate.ToString());
                    item.SubItems.Add(ord.ShippingDate.ToString());
                    item.SubItems.Add(ord.StatusId.ToString());
                    item.SubItems.Add(ord.CustomerId.ToString());
                    item.SubItems.Add(ord.EmployeeId.ToString());
                    item.SubItems.Add(ord.Payment.ToString());
                    listView.Items.Add(item);

                }
                else
                {
                    MessageBox.Show("Book Not Found", "Error", MessageBoxButtons.OK);
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }
            }
        }

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();

            var listO = from ord in db.Orders
                        select ord;
            foreach (var itemO in listO)
            {
                ListViewItem item = new ListViewItem(itemO.OrderId.ToString());
                item.SubItems.Add(itemO.OrderDate.ToString());
                item.SubItems.Add(itemO.OrderType);
                item.SubItems.Add(itemO.RequiredDate.ToString());
                item.SubItems.Add(itemO.ShippingDate.ToString());
                item.SubItems.Add(itemO.StatusId.ToString());
                item.SubItems.Add(itemO.CustomerId.ToString());
                item.SubItems.Add(itemO.EmployeeId.ToString());
                item.SubItems.Add(itemO.Payment.ToString());
                //listView.Items.Add(item);
                listView.Items.Add(item);


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

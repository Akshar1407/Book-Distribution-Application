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
    public partial class FormInventoryManagement : Form
    {
        List<Categories> listC;
        List<Publishers> listP;

        public FormInventoryManagement()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Books bk = new Books();

            string input = textBoxISBN.Text.Trim();
            if (Validator.IsValidNumber(input, 4) && !bk.IdExists(input) &&
                (Validator.IsValidName(textBoxTItle.Text.Trim())) &&
                (Validator.IsValidDouble(textBoxUnitPrice.Text.Trim())) &&
                (Validator.IsValidNumber(textBoxYearPublished.Text.Trim(), 4)) &&
                (Validator.IsValidNumber(textBoxQOH.Text.Trim(), 3)) &&
                (Validator.GetId(comboBoxCategoryId.Text.Trim()) > 0) &&
                (Validator.GetId(comboBoxPublisherId.Text.Trim()) > 0))
            {
                bk.ISBN = textBoxISBN.Text.Trim();
                bk.Title = textBoxTItle.Text.Trim();
                bk.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text.Trim());
                bk.YearPublished = Convert.ToInt32(textBoxYearPublished.Text.Trim());
                bk.QOH = Convert.ToInt32(textBoxQOH.Text.Trim());
                bk.CategoryId = Validator.GetId(comboBoxCategoryId.Text.Trim());
                bk.PublisherId = Validator.GetId(comboBoxPublisherId.Text.Trim());

                bk.SaveBooks(bk);
                MessageBox.Show("Book Saved", "Saved");

                ClearTextBoxes();
            }
            else
            {
                if (!Validator.IsValidNumber(textBoxISBN.Text.Trim(), 4) || bk.IdExists((input)))
                {
                    MessageBox.Show("Invalid ISBN or it already exist, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxISBN.Clear();
                    textBoxISBN.Focus();
                    return;
                }
                if (!Validator.IsValidName(textBoxTItle.Text.Trim()))
                {
                    MessageBox.Show("Invalid Title, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxTItle.Clear();
                    textBoxTItle.Focus();
                    return;
                }
                if (!Validator.IsValidDouble(textBoxUnitPrice.Text.Trim()))
                {
                    MessageBox.Show("Invalid Unit Price, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxUnitPrice.Clear();
                    textBoxUnitPrice.Focus();
                    return;
                }
                if (!(Validator.IsValidNumber(textBoxYearPublished.Text.Trim(), 4)))
                {
                    MessageBox.Show("Invalid Year , please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxYearPublished.Clear();
                    textBoxYearPublished.Focus();
                    return;
                }
                if (!Validator.IsValidNumber(textBoxQOH.Text.Trim(), 3))
                {
                    MessageBox.Show("Invalid QOH, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxQOH.Clear();
                    textBoxQOH.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxCategoryId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Category ID not selected, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxCategoryId.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxPublisherId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Publisher ID not selected, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxPublisherId.Focus();
                    return;
                }
            }
        }

        private void FormInventoryManagement_Load(object sender, EventArgs e)
        {
            Categories cs = new Categories();
            listC = cs.GetList();

            if (listC != null && listC.Count > 0)
            {
                foreach (var item in listC)
                {
                    comboBoxCategoryId.Items.Add(item.CategoryId + " -> " + item.CategoryName);
                }
            }

            Publishers ps = new Publishers();
            listP = ps.GetList();

            if (listP != null && listP.Count > 0)
            {
                foreach (var item in listP)
                {
                    comboBoxPublisherId.Items.Add(item.PublisherId + " -> " + item.PublisherName);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Books bk = new Books();

            string input = textBoxISBN.Text.Trim();
            if (Validator.IsValidNumber(input, 4) && bk.IdExists(input) &&
                (Validator.IsValidName(textBoxTItle.Text.Trim())) &&
                (Validator.IsValidDouble(textBoxUnitPrice.Text.Trim())) &&
                (Validator.IsValidNumber(textBoxYearPublished.Text.Trim(), 4)) &&
                (Validator.IsValidNumber(textBoxQOH.Text.Trim(), 3)) &&
                (Validator.GetId(comboBoxCategoryId.Text.Trim()) > 0) &&
                (Validator.GetId(comboBoxPublisherId.Text.Trim()) > 0))
            {
                bk.ISBN = textBoxISBN.Text.Trim();
                bk.Title = textBoxTItle.Text.Trim();
                bk.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text.Trim());
                bk.YearPublished = Convert.ToInt32(textBoxYearPublished.Text.Trim());
                bk.QOH = Convert.ToInt32(textBoxQOH.Text.Trim());
                bk.CategoryId = Validator.GetId(comboBoxCategoryId.Text.Trim());
                bk.PublisherId = Validator.GetId(comboBoxPublisherId.Text.Trim());
                bk.UpdateBooks(bk);
                MessageBox.Show("Invenatory updated", "Updated");

                ClearTextBoxes();
            }
            else
            {
                if (!Validator.IsValidNumber(textBoxISBN.Text.Trim(), 4) || !bk.IdExists((input)))
                {
                    MessageBox.Show("Invalid ISBN or it already exist, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxISBN.Clear();
                    textBoxISBN.Focus();
                    return;
                }
                if (!Validator.IsValidName(textBoxTItle.Text.Trim()))
                {
                    MessageBox.Show("Invalid Title, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxTItle.Clear();
                    textBoxTItle.Focus();
                    return;
                }
                if (!Validator.IsValidDouble(textBoxUnitPrice.Text.Trim()))
                {
                    MessageBox.Show("Invalid Unit Price, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxUnitPrice.Clear();
                    textBoxUnitPrice.Focus();
                    return;
                }
                if (!(Validator.IsValidNumber(textBoxYearPublished.Text.Trim(), 4)))
                {
                    MessageBox.Show("Invalid Year , please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxYearPublished.Clear();
                    textBoxYearPublished.Focus();
                    return;
                }
                if (!Validator.IsValidNumber(textBoxQOH.Text.Trim(), 3))
                {
                    MessageBox.Show("Invalid QOH, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxQOH.Clear();
                    textBoxQOH.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxCategoryId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Category ID not selected, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxCategoryId.Focus();
                    return;
                }
                if (Validator.GetId(comboBoxPublisherId.Text.Trim()) == 0)
                {
                    MessageBox.Show("Publisher ID not selected, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    comboBoxPublisherId.Focus();
                    return;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Books bk = new Books();

            string input = textBoxISBN.Text.Trim();
            if (!Validator.IsValidNumber(input, 4) && !bk.IdExists((input)))
            {
                MessageBox.Show("Invalid ISBN or it does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxISBN.Clear();
                textBoxISBN.Focus();
                return;
            }
            else
            {
                bk.ISBN = (textBoxISBN.Text.Trim());
                BooksDB.DeleteRecord(bk);
                MessageBox.Show("Inventory Deleted", "Deleted");

                ClearTextBoxes();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Books bk = new Books();

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
                    MessageBox.Show("Invalid Title, please check it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }
                List<Books> list = bk.Search_Books(input);
                if (list != null && list.Count > 0)
                {
                    listView.Items.Clear();
                    ClearTextBoxes();

                    foreach (Books abk in list)
                    {
                        ListViewItem item = new ListViewItem(abk.ISBN.ToString());
                        item.SubItems.Add(abk.Title);
                        item.SubItems.Add(abk.UnitPrice.ToString());
                        item.SubItems.Add(abk.YearPublished.ToString());
                        item.SubItems.Add(abk.QOH.ToString());
                        item.SubItems.Add(GetCategoryTitle(abk.CategoryId.ToString()));
                        item.SubItems.Add(GetPublisherTitle(abk.PublisherId.ToString()));
                        listView.Items.Add(item);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Book Not Found", "Error", MessageBoxButtons.OK);
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }

            }
            else
            {
                if (!Validator.IsValidNumber(input, 4) || !bk.IdExists((input)))
                {
                    MessageBox.Show("Invalid ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    return;
                }
                listView.Items.Clear();
                ClearTextBoxes();

                bk = bk.SearchBooks((input));
                if (bk != null)
                {

                    textBoxISBN.Text = (bk.ISBN);
                    textBoxTItle.Text = bk.Title;
                    textBoxUnitPrice.Text = (bk.UnitPrice).ToString();
                    textBoxYearPublished.Text = (bk.YearPublished).ToString();
                    textBoxQOH.Text = bk.QOH.ToString();
                    foreach (var i in listC)
                    {
                        if (i.CategoryId == bk.CategoryId)
                        {
                            comboBoxCategoryId.SelectedItem = bk.CategoryId.ToString() + " -> " + i.CategoryName;
                        }
                    }
                    foreach (var j in listP)
                    {
                        if (j.PublisherId == bk.PublisherId)
                        {
                            comboBoxPublisherId.SelectedItem = bk.PublisherId.ToString() + " -> " + j.PublisherName;
                        }
                    }

                    ListViewItem item = new ListViewItem(bk.ISBN.ToString());
                    item.SubItems.Add(bk.Title);
                    item.SubItems.Add(bk.UnitPrice.ToString());
                    item.SubItems.Add(bk.YearPublished.ToString());
                    item.SubItems.Add(bk.QOH.ToString());
                    item.SubItems.Add(GetCategoryTitle(bk.CategoryId.ToString()));
                    item.SubItems.Add(GetPublisherTitle(bk.PublisherId.ToString()));
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

        private string GetCategoryTitle(String id)
        {
            foreach (var c in listC)
            {
                if (int.Parse(id) == c.CategoryId)
                {
                    return c.CategoryName;
                }
            }
            return "";
        }

        private string GetPublisherTitle(String id)
        {
            foreach (var p in listP)
            {
                if (int.Parse(id) == p.PublisherId)
                {
                    return p.PublisherName;
                }
            }
            return "";
        }

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            Books bk = new Books();
            List<Books> list = bk.GetBookList();
            listView.Items.Clear();

            foreach (Books book in list)
            {

                ListViewItem item = new ListViewItem(book.ISBN.ToString());
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.UnitPrice.ToString());
                item.SubItems.Add(book.YearPublished.ToString());
                item.SubItems.Add(book.QOH.ToString());
                item.SubItems.Add(GetCategoryTitle(book.CategoryId.ToString()));
                item.SubItems.Add(GetPublisherTitle(book.PublisherId.ToString()));
                listView.Items.Add(item);


            }
        }

        private void ClearTextBoxes()
        {
            textBoxISBN.Clear();
            textBoxTItle.Clear();
            textBoxUnitPrice.Clear();
            textBoxYearPublished.Clear();
            textBoxQOH.Clear();
            comboBoxCategoryId.SelectedIndex = -1;
            comboBoxPublisherId.SelectedIndex = -1;
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

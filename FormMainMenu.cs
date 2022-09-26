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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonFormEmployee_Click(object sender, EventArgs e)
        {
            FormEmployee employee = new FormEmployee();
            employee.ShowDialog();
        }

        private void buttonFormUser_Click(object sender, EventArgs e)
        {
            FormUser user = new FormUser();
            user.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

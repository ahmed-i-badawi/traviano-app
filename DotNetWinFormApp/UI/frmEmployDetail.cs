using TravianoApp.Manager;
using TravianoApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravianoApp.UI
{
    public partial class frmEmployDetail : Form
    {

        FrmAccount frm;

        public frmEmployDetail(FrmAccount frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        AccountManager _AccountManager = new AccountManager();
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(userNameTextBox.Text))
                {
                    MessageBox.Show("Please enter user name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    userNameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    MessageBox.Show("Please enter password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    passwordTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(serverTextBox.Text))
                {
                    MessageBox.Show("Please enter server.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    serverTextBox.Focus();
                    return;
                }
                Account Account = new Account();
                Account.Id = Convert.ToInt32(idLable.Text);
                Account.UserName = userNameTextBox.Text;
                Account.Password = passwordTextBox.Text;
                Account.Server = serverTextBox.Text;
                if (_AccountManager.Update(Account))
                {
                    MessageBox.Show("Account has been modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();
                }
                else
                {
                    MessageBox.Show("Account modify failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEmployDetail_Load(object sender, EventArgs e)
        {

        }
    }
}

using TravianoApp.Manager;
using TravianoApp.Models;
using TravianoApp.UI;

namespace TravianoApp
{
    public partial class FrmAccount : Form
    {
        public FrmAccount()
        {
            InitializeComponent();
        }

        AccountManager _AccountManager = new AccountManager();

        ApplicationDbContext _dbContext = new ApplicationDbContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void LoadData()
        {
            AccountManager AccountManager = new AccountManager();
            var Accounts = AccountManager.GetAll();
            accountDataGridView.Rows.Clear();
            foreach (var Account in Accounts)
            {
                accountDataGridView.Rows.Add(Account.Id, Account.UserName, Account.Password, Account.Server);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Please enter email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Account.UserName = userNameTextBox.Text;
                Account.Password = passwordTextBox.Text;
                Account.Server = serverTextBox.Text;
                if (_AccountManager.Add(Account))
                {
                    MessageBox.Show("Account has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Account saved failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            userNameTextBox.Text = String.Empty;
            passwordTextBox.Clear();
            serverTextBox.Clear();
            LoadData();
        }

        private void accountDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = accountDataGridView.SelectedRows[0];
                frmEmployDetail frm = new frmEmployDetail(this);
                //this.Hide();
                frm.Show();
                frm.idLable.Text = dr.Cells[0].Value.ToString();
                frm.userNameTextBox.Text = dr.Cells[1].Value.ToString();
                frm.passwordTextBox.Text = dr.Cells[2].Value.ToString();
                frm.serverTextBox.Text = dr.Cells[3].Value.ToString();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = accountDataGridView.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Qeuestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _AccountManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Account has been removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ssLoadData();
                        accountDataGridView.Rows.Remove(dr);
                    }
                    else
                    {
                        MessageBox.Show("Account removed failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
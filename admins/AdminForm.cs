using App.admins;
using App.components.database;
using System.Data;

namespace App
{
    public partial class AdminForm : Form
    {
        Database db = new Database();

        public AdminForm()
        {
            InitializeComponent();

            DataTable table = db.Table("users");

            dataPanel.DataSource = table;
        }

        private void regisButton_Click(object sender, EventArgs e)
        {
            RegistForm reg = new RegistForm();

            reg.Show();

            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            RemoveUserForm removeUser = new RemoveUserForm();

            removeUser.Show();

            this.Hide();
        }

        private void getRoleButton_Click(object sender, EventArgs e)
        {
            GivRoleForm givNewRole = new GivRoleForm();

            givNewRole.Show();

            this.Hide();
        }

        private void newPassButton_Click(object sender, EventArgs e)
        {
            NewPassForm newPass = new NewPassForm();

            newPass.Show();

            this.Hide();
        }
    }
}

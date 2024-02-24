using App.components.database;
using System.Windows.Forms;

namespace App.admins
{
    public partial class GivRoleForm : Form
    {
        private List<string> _roles;

        private Database db = new Database();

        public GivRoleForm()
        {
            InitializeComponent();

            _roles = db.Roles();

            roleList.Items.Clear();

            foreach (string role in _roles)
            {
                roleList.Items.Add(role);
            }
        }

        private void registButton_Click(object sender, EventArgs e)
        {
            bool new_role = true;

            string login = logBox.Text;
            string role = roleList.Text;

            if(!db.IsLoginIn(login))
            {
                errorLabel.Text = "Вы не указали логин или такого логина не существует";

                new_role = false;
            }

            if (!_roles.Contains(role))
            {
                errorLabel.Text = "Вы не указали роль";

                new_role = false;
            }

            if(new_role) 
            {
                db.UpdateRole(login, role);

                AdminForm admin = new AdminForm();

                admin.Show();

                this.Hide();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();

            admin.Show();

            this.Hide();
        }
    }
}

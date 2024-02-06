using App.components;

namespace App.admins
{
    public partial class RemoveUserForm : Form
    {
        Database db = new Database();

        public RemoveUserForm()
        {
            InitializeComponent();
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            string target = loginBox.Text;

            if (!db.IsLoginIn(target))
            {
                errorLabel.Text = "Пользователь с таким логином не существует\nили/и уже был удален";
            }
            else
            {
                db.DropUser(target);

                AdminForm adminForm = new AdminForm();

                adminForm.Show();

                this.Hide();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();

            adminForm.Show();

            this.Hide();
        }
    }
}

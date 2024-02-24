using App.components.database;

namespace App.admins
{
    public partial class NewPassForm : Form
    {
        Database db = new Database();
        public NewPassForm()
        {
            InitializeComponent();
        }

        private void newPassButton_Click(object sender, EventArgs e)
        {

            string login = logBox.Text;
            string password = passwordBox.Text;

            if (!db.IsLoginIn(login))
            {
                errorLabel.Text = "Неверный логин или такого логина нету";
            }
            else if(password == "")
            {
                errorLabel.Text = "Пароль не задан";
            }
            else
            {
                db.NewPassword(login, password);

                MessageBox.Show($"Пароль был успешно сменен для пользователя {login}");

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

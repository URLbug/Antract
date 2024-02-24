using App.components.database;
using App.components.jsons;

namespace App
{
    public partial class LoginForm : Form
    {
        private Database db = new Database();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passBox.Text;

            if (db.IsLogin(login, password))
            {
                Form main = !db.IsAdmin(login) ? new MainForm() : new AdminForm();
                int id = db.GetidUser(login);

                UserSession data = new UserSession()
                {
                    Id = id,
                    Username = login,
                };

                Sessions session = new Sessions();

                session.JsonWrite(@"./user.json", data);

                main.Show();

                this.Hide();
            }
            else
            {
                errorText.Text = "Неверный логин или пароль";
            }
        }
    }
}

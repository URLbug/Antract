using App.components;
using System.Data;
using System.Windows.Forms;

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
                Form main;

                if(!db.IsAdmin(login))
                    main = new MainForm();
                else
                    main = new AdminForm();

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

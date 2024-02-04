using App.components;
using System.Windows.Forms;

namespace App.admins
{
    public partial class RegistForm : Form
    {
        private List<string> _roles;

        private Database db = new Database();

        private string[] errorList = {
            "Вы не указали логин или такой логин уже есть",
            "Вы не указали роль",
            "Вы не указали пароль",
            "Вы не указали имя",
            "Вы не указали фамилию",
        };

        public RegistForm()
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
            bool is_reg = true; 

            string[] data = {
                logBox.Text,
                roleList.Text,
                passwordBox.Text,
                first_nameBox.Text,
                last_nameBox.Text,
            };

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == "" && db.IsLoginIn(data[0]))
                {
                    MessageBox.Show(errorList[i]);

                    is_reg = false;

                    break;
                }
            }

            if (is_reg)
            {
                db.RegistUser(data[0], data[1], data[2], data[4], data[3]);

                MessageBox.Show("Пользователь успешно зарегестрирован");

                AdminForm admin = new AdminForm();

                admin.Show();

                this.Hide();
            }

        }
    }
}

using App.components.database;
using App.components.jsons;

namespace App.users.func_form
{
    public partial class ReportForm : Form
    {
        Database db = new Database();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void publickButton_Click(object sender, EventArgs e)
        {
            string text = descriptionRep.Text;

            Sessions sessions = new Sessions();

            UserSession json = sessions.JsonRead<UserSession>(@"./user.json");

            db.Add("reports", $"({json.Id}, '{text}')");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();

            main.Show();

            this.Close();
        }
    }
}

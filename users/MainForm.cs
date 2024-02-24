using App.components.database;
using App.users.func_form;

namespace App
{
    public partial class MainForm : Form
    {
        private Database db = new Database();

        private Dictionary<string, string> _param = new Dictionary<string, string>()
        {
            ["Заказы"] = "orders",
            ["Контрагенты"] = "conterparty",
            ["Отчет"] = "reports",
            ["Накладная"] = "invoices",
        };

        private Dictionary<string, Form> _tableForm = new Dictionary<string, Form>()
        {
            ["orders"] = new Form(),
            ["conterparty"] = new Form(),
            ["reports"] = new ReportForm(),
            ["invoices"] = new Form(),
        };

        private string[] _tools = {
            "Создать",
        };

        public MainForm()
        {
            InitializeComponent();

            paramsBox.Items.Clear();
            interactionBox.Items.Clear();

            paramsBox.Items.AddRange(_param.Keys.ToArray());
            interactionBox.Items.AddRange(_tools);
        }

        private void paramsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPanel.DataSource = db.Table(_param[paramsBox.Text]);
        }

        private void interactionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = _param[paramsBox.Text];
            
            string option = interactionBox.Text;


            Form result = option switch
            {
                "Создать" => _tableForm[table],
            };

            result.Show();

            this.Hide();
        }
    }
}

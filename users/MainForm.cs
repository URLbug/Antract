using App.components;

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

        public MainForm()
        {
            InitializeComponent();

            paramsBox.Items.Clear();

            paramsBox.Items.AddRange(_param.Keys.ToArray());
        }

        private void paramsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPanel.DataSource = db.Table(_param[paramsBox.Text]);


        }
    }
}

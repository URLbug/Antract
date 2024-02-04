using App.admins;
using System.Windows.Forms;

namespace App
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void regisButton_Click(object sender, EventArgs e)
        {
            Form reg = new RegistForm();

            reg.Show();

            this.Hide();
        }
    }
}

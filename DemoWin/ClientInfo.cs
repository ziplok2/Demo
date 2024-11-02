using DemoLib;
using System.Windows.Forms;

namespace Demo
{
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
        }

        public void SetClient(Client client)
        {
            CompanyNameTextBox.Text = client.Name;
        }

        private void ClientInfo_Load(object sender, System.EventArgs e)
        {

        }

        private void Save_Click(object sender, System.EventArgs e)
        {

        }
    }
}

using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class MainView : MetroForm
    {
        public MainView()
        {
            InitializeComponent();

            this.StyleManager = msmMain;
        }

        private void openOperativeView(object sender, EventArgs e)
        {

        }

        private void openCampaignAdmin(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            var campaignAdmin = new CampaignAdmin();
            this.Cursor = Cursors.Default;
            this.StyleManager.Clone(campaignAdmin);
            campaignAdmin.ShowDialog(this);

        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}

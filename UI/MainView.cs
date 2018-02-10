using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace UI
{
    public partial class MainView : MaterialForm
    {
        public MainView()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void operativeViewButton_Click(object sender, EventArgs e)
        {

        }

        private void campaignAdminButton_Click(object sender, EventArgs e)
        {

            var campaignAdmin = new CampaignAdmin();
            campaignAdmin.ShowDialog(this);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

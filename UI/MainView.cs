using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using UI.RssSource_source_forms;

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

        private void openBannerAdmin(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            var bannerAdmin = new BannerAdmin();
            this.Cursor = Cursors.Default;
            this.StyleManager.Clone(bannerAdmin);
            bannerAdmin.ShowDialog(this);

        }

        private void openRssSourceAdmin_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            var rssSourceAdmin = new RssSourceAdmin();
            this.Cursor = Cursors.Default;
            this.StyleManager.Clone(rssSourceAdmin);
            rssSourceAdmin.ShowDialog(this);

        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setLightTheme(object sender, EventArgs e)
        {
            this.msmMain.Theme = MetroThemeStyle.Light;
        }

        public void setDarkTheme(object sender, EventArgs e)
        {
            this.msmMain.Theme = MetroThemeStyle.Dark;
        }

        private void openOperativeButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var digitalSignageScreen = new DigitalSignageScreen();
            this.Cursor = Cursors.Default;
            this.StyleManager.Clone(digitalSignageScreen);
            digitalSignageScreen.Show(this);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../../assets/DigitalSignage.chm");
        }
    }
}

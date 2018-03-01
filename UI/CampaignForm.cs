using DTO;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CampaignForm : MetroForm

    {

        private CampaignDTO iCampaignModel;

        public CampaignForm(CampaignDTO pCampaign)
        {
            InitializeComponent();
            
            this.initTimePicker.ShowUpDown = true;
            this.endTimePicker.ShowUpDown = true;

            this.campaignImagesList.AutoGenerateColumns = false;

            if (pCampaign != null)
            {
                this.iCampaignModel = pCampaign;
                loadImages();
            }
            
        }

        private void loadImages()
        {
            this.campaignImagesList.DataSource = this.iCampaignModel.Images;
        }

        private void CampaignForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using BLL;
using Microsoft.Practices.Unity;
using System.Windows.Forms;
using System.Drawing;
using MetroFramework.Forms;

namespace UI
{
    public partial class CampaignAdmin : MetroForm
    {

        //resuelve la dependencia para el servicio de campañas
        private ICampaignService iCampaignService = IoCContainerLocator.Container.Resolve<ICampaignService>();

        public CampaignAdmin()
        {
            InitializeComponent();
            
            //Carga de la tabla de campañas
            this.campaignsGridView.AutoGenerateColumns = false;
            LoadCampaigns();
        }

        void LoadCampaigns()
        {
            this.campaignsGridView.DataSource =  this.iCampaignService.GetAll();
        }

        private void campaignsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

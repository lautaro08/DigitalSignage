using System;
using BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Practices.Unity;
using DTO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    public partial class CampaignAdmin : MaterialForm
    {

        //resuelve la dependencia para el servicio de campañas
        private ICampaignService iCampaignService = IoCContainerLocator.Container.Resolve<ICampaignService>();

        public CampaignAdmin()
        {
            InitializeComponent();

            //Esquema de colores para MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            this.campaignsGridView.DefaultCellStyle.Font = new Font("Verdana", 12);
            this.campaignsGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            this.campaignsGridView.DefaultCellStyle.SelectionBackColor = Color.Gold;
            this.campaignsGridView.RowHeadersVisible = false;
            this.campaignsGridView.ColumnHeadersVisible = false;

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

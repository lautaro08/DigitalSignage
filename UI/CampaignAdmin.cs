using System;
using BLL;
using Microsoft.Practices.Unity;
using System.Windows.Forms;
using System.Drawing;
using MetroFramework.Forms;
using DTO;
using MetroFramework;

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

        private void modifyCampaignButton_Click(object sender, EventArgs e)
        {

            var camapignForm = new CampaignForm(
                DeepCopyHelper.DeepCopy<CampaignDTO>((CampaignDTO)this.campaignsGridView.SelectedRows[0].DataBoundItem)
            );
            this.StyleManager.Clone(camapignForm);

            if (camapignForm.ShowDialog(this) == DialogResult.OK)
            {

                //modificar la campaña
                try
                {

                    iCampaignService.Update(camapignForm.iCampaignModel);
                    MetroMessageBox.Show(this, "se han modificado todos los datos", "Exito al modificar la campaña", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al modificar la campaña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }

        private void addCampaignButton_Click(object sender, EventArgs e)
        {

            var camapignForm = new CampaignForm(null);
            this.StyleManager.Clone(camapignForm);

            if (camapignForm.ShowDialog(this) == DialogResult.OK)
            {

                //guardar la campaña
                try
                {

                    iCampaignService.Create(camapignForm.iCampaignModel);
                    MetroMessageBox.Show(this, "a partir de ahora la campaña creada estara disponible en el sistema", "Exito al crear la campaña", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al crear la campaña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }

        }
    }
}

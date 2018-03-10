using BLL;
using DTO;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Practices.Unity;
using System.Windows.Forms;

namespace UI.Banner_source_forms
{

    /// <summary>
    /// pantalla para la carga de una fuente RSS
    /// </summary>
    public partial class RssSourceForm : MetroForm
    {

        //variable de instancia que contiene la campaña que se carga en el formulario
        public RssSourceDTO iRssSourceModel;

        public RssSourceForm(RssSourceDTO pRssSource)
        {
            InitializeComponent();

            if (pRssSource != null)
            {

                iRssSourceModel = pRssSource;
                loadRssSourceInView();

            }
            else
            {

                iRssSourceModel = new RssSourceDTO();
                iRssSourceModel.RssItems = new List<RssItemDTO>();

            }
        }


        /*
         
            -----> BUTTONS CLICK <-----

        */

        private void exitButton_Click(object sender, EventArgs e)
        {

            if (MetroMessageBox.Show(this, "si sale perdera todos los cambios realizados", "Esta seguro de salir del formulario?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Close();

            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                try
                {
                    updateRssSourceFromView();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error con los datos de la fuente rss, por favor intente cargarla nuevamente", "Error al guardar la fuente rss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        /*
         
            -----> VALIDATIONS <-----

        */

        private void urlTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(urlTextBox.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(urlTextBox, "Debe ingresar una url");
                return;

            }
            Uri mUrl;

            if (!Uri.TryCreate(urlTextBox.Text.Trim(), UriKind.Absolute, out mUrl))
            {

                e.Cancel = true;
                errorProvider1.SetError(urlTextBox, "La URL ingresada no es válida.");
                return;

            }

            errorProvider1.SetError(urlTextBox, null);
        }

        private void descriptionTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(descriptionTextBox, "Debe ingresar una descripcion");
                return;

            }

            errorProvider1.SetError(descriptionTextBox, null);

        }

        private void feedsGridView_Validating(object sender, CancelEventArgs e)
        {

            if (iRssSourceModel.RssItems.Count == 0)
            {

                e.Cancel = true;
                errorProvider1.SetError(verifySourceButton, "Se debe verificar que se pueden obtener los feeds de la url especificada.");
                return;

            }

            errorProvider1.SetError(verifySourceButton, null);
        }

        /*
         
            -----> AUX FUNCTIONS <-----

        */

        private void loadRssSourceInView()
        {

            urlTextBox.Text = iRssSourceModel.Url;
            descriptionTextBox.Text = iRssSourceModel.Description;
            feedsGridView.DataSource = iRssSourceModel.RssItems;

        }

        private void updateRssSourceFromView()
        {

            iRssSourceModel.Url = urlTextBox.Text;
            iRssSourceModel.Description = descriptionTextBox.Text;

        }

        private void bwRssReader_DoWork(object sender, DoWorkEventArgs e)
        {

            IRssReader mRssReader = IoCContainerLocator.Container.Resolve<IRssReader>();
            e.Result = mRssReader.Read((Uri)e.Argument);

        }

        private void bwRssReader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Error != null)
            {

                MetroMessageBox.Show(this, "detalles del error: " + e.Error.Message, "Error al obtener feeds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!e.Cancelled)
            {

                var mItems = (List<RssItemDTO>)e.Result;
                feedsGridView.DataSource = mItems;
                iRssSourceModel.RssItems = mItems;
            }

            verifySourceButton.Enabled = true;
            feedsLoadingLabel.Visible = false;
            feedsLoadingSpinner.Visible = false;
            this.Cursor = Cursors.Default;

        }

        private void verifySourceButton_Click(object sender, EventArgs e)
        {

            Uri mUrl;

            if (!Uri.TryCreate(urlTextBox.Text.Trim(), UriKind.Absolute, out mUrl))
            {
                MetroMessageBox.Show(this, "por favor verifique que se encuentre bien ingresada", "Error de la url", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            verifySourceButton.Enabled = false;
            feedsLoadingLabel.Visible = true;
            feedsLoadingSpinner.Visible = true;
            
            bwRssReader.RunWorkerAsync(mUrl);
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            feedsGridView.DataSource = null;
            iRssSourceModel.RssItems = new List<RssItemDTO>();
        }
    }
}

using DTO;
using MetroFramework;
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
using UI.RssSource_source_forms;

namespace UI
{

    /// <summary>
    /// pantalla para la carga de un banner
    /// </summary>
    public partial class BannerForm : MetroForm
    {

        //variable de instancia que contiene el banner que se carga en el formulario
        public BannerDTO iBannerModel;

        //constantes para los tipos de fuentes
        const string RSS_SOURCE = "Fuente RSS";
        const string TEXT_SOURCE = "Fuente de texto";

        public BannerForm(BannerDTO pBanner)
        {
            InitializeComponent();

            sourceComboBox.Items.Add(RSS_SOURCE);
            sourceComboBox.Items.Add(TEXT_SOURCE);

            if (pBanner != null)
            {
                iBannerModel = pBanner;
                loadBannerInView();
            }
            else
            {

                iBannerModel = new BannerDTO();

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

            if (ValidateChildren(ValidationConstraints.Visible))
            {

                try
                {
                    updateBannerFromView();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Detalles del error : " + ex.Message, "Error al guardar el banner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        /*
         
          -----> VALUE CHANGES <-----
              
        */

        private void initTimeHours_SelectedValueChanged(object sender, EventArgs e)
        {
            //primero debe cargar las horas
            initTimeMinutes.Enabled = true;
        }

        private void initTimeMinutes_SelectedValueChanged(object sender, EventArgs e)
        {
            endTimeHours.Enabled = true;
        }

        private void endTimeHours_SelectedValueChanged(object sender, EventArgs e)
        {
            endTimeMinutes.Enabled = true;
        }

        /*
         
          -----> VALIDATIONS <-----
              
        */

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(nameTextBox, "El nombre del banner es obligatorio.");
                return;
            }
            errorProvider1.SetError(nameTextBox, null);

        }

        private void descriptionTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(descriptionTextBox, "La descripcion del banner es obligatoria.");
                return;
            }
            errorProvider1.SetError(descriptionTextBox, null);

        }

        private void initDatePicker_Validating(object sender, CancelEventArgs e)
        {

            if (initDateIsAfterEndDate())
            {
                errorProvider1.SetError(initDatePicker, "La fecha de fin debe ser mayor a la fecha de inicio");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(initDatePicker, null);
        }

        private void endDatePicker_Validating(object sender, CancelEventArgs e)
        {
            if (initDateIsAfterEndDate())
            {
                errorProvider1.SetError(endDatePicker, "La fecha de fin debe ser mayor a la fecha de inicio");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(endDatePicker, null);
        }

        private void initTimeHours_Validating(object sender, CancelEventArgs e)
        {
            if (initTimeHours.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(initTimeHours, "Debe seleccionar la hora de comienzo");
                return;
            }
            errorProvider1.SetError(initTimeHours, null);
        }

        private void initTimeMinutes_Validating(object sender, CancelEventArgs e)
        {
            if (initTimeMinutes.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(initTimeMinutes, "Debe seleccionar los minutos de comienzo");
                return;
            }
            errorProvider1.SetError(initTimeMinutes, null);
        }

        private void endTimeHours_Validating(object sender, CancelEventArgs e)
        {
            if (endTimeHours.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(endTimeHours, "Debe seleccionar la hora de finalizacion");
                return;
            }
            errorProvider1.SetError(endTimeHours, null);
        }

        private void endTimeMinutes_Validating(object sender, CancelEventArgs e)
        {
            if (endTimeMinutes.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(endTimeMinutes, "Debe seleccionar los minutos de finalizacion");
                return;
            }
            if (initTimeIsAfterEndTime())
            {
                e.Cancel = true;
                errorProvider1.SetError(endTimeMinutes, "La hora de finalizacion debe ser despues de la hora de inicio");
                return;
            }
            errorProvider1.SetError(initTimeMinutes, null);
        }

        /*
         
          -----> AUX FUNCTIONS <-----
              
        */

        /// <summary>
        /// checkea si la hora de inicio se encuentra despues de la de fin, en cuyo caso devuelve verdadero
        /// </summary>
        /// <returns></returns>
        private bool initTimeIsAfterEndTime()
        {
            int hours = int.Parse(initTimeHours.SelectedItem.ToString());
            int minutes = int.Parse(initTimeMinutes.SelectedItem.ToString());
            var initTimespan = new TimeSpan(hours, minutes, 0);

            hours = int.Parse(endTimeHours.SelectedItem.ToString());
            minutes = int.Parse(endTimeMinutes.SelectedItem.ToString());
            var endTimespan = new TimeSpan(hours, minutes, 0);

            return initTimespan.CompareTo(endTimespan) > 0;
        }

        /// <summary>
        /// checkea si la hora de inicio se encuentra despues de la de fin, en cuyo caso devuelve verdadero
        /// </summary>
        /// <returns></returns>
        private bool initDateIsAfterEndDate()
        {
            return initDatePicker.Value.CompareTo(endDatePicker.Value) > 0;
        }

        private void loadBannerInView()
        {
            nameTextBox.Text = iBannerModel.Name;
            descriptionTextBox.Text = iBannerModel.Description;
            initDatePicker.Value = iBannerModel.InitDate;
            endDatePicker.Value = iBannerModel.EndDate;
            initTimeHours.SelectedIndex = iBannerModel.InitTime.Hours;
            initTimeMinutes.SelectedIndex = iBannerModel.InitTime.Minutes;
            endTimeHours.SelectedIndex = iBannerModel.EndTime.Hours;
            endTimeMinutes.SelectedIndex = iBannerModel.EndTime.Minutes;

            if (iBannerModel.Source is TextSourceDTO)
            {

                sourceComboBox.SelectedItem = TEXT_SOURCE;
                var textSource = (TextSourceDTO)iBannerModel.Source;
                textSourceTextBox.Text = textSource.Text;

            }

            if (iBannerModel.Source is RssSourceDTO)
            {

                sourceComboBox.SelectedItem = RSS_SOURCE;
                sourceComboBox_SelectedValueChanged(sourceComboBox, EventArgs.Empty);

                var rssSource = (RssSourceDTO)iBannerModel.Source;
                rssSourceLabel.Text = string.Format(
                    "Id: {1}{0}Descripcion: {2}{0}Url: {3}{0}", 
                    Environment.NewLine, 
                    rssSource.Id, 
                    rssSource.Description, 
                    rssSource.Url
                );

            }


        }

        private void updateBannerFromView()
        {
            iBannerModel.Name = nameTextBox.Text;
            iBannerModel.Description = descriptionTextBox.Text;
            iBannerModel.InitDate = initDatePicker.Value;
            iBannerModel.EndDate = endDatePicker.Value;

            int hours = int.Parse(initTimeHours.SelectedItem.ToString());
            int minutes = int.Parse(initTimeMinutes.SelectedItem.ToString());
            iBannerModel.InitTime = new TimeSpan(hours, minutes, 0);

            hours = int.Parse(endTimeHours.SelectedItem.ToString());
            minutes = int.Parse(endTimeMinutes.SelectedItem.ToString());
            iBannerModel.EndTime = new TimeSpan(hours, minutes, 0);

            if (sourceComboBox.SelectedItem.ToString() == TEXT_SOURCE)
            {

                var textSource = new TextSourceDTO();
                textSource.Text = textSourceTextBox.Text;
                iBannerModel.Source = textSource;

            }

            if (sourceComboBox.SelectedItem.ToString() == RSS_SOURCE && (iBannerModel.Source == null || iBannerModel.Source is TextSourceDTO))
            {

                throw new Exception("Debe seleccionar una fuente RSS");

            }

        }

        private void sourceComboBox_Validating(object sender, CancelEventArgs e)
        {

            if (sourceComboBox.SelectedIndex == -1)
            {

                e.Cancel = true;
                errorProvider1.SetError(sourceComboBox, "Debe seleccionar una fuente para el banner");
                return;

            }

            errorProvider1.SetError(sourceComboBox, null);

        }

        private void sourceComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            switch (sourceComboBox.SelectedItem.ToString())
            {

                case RSS_SOURCE:
                    textSourceLabel.Visible = false;
                    textSourceTextBox.Visible = false;
                    rssSourceLabel.Visible = true;
                    selectRssSourceButton.Visible = true;
                    break;

                case TEXT_SOURCE:
                    textSourceLabel.Visible = true;
                    textSourceTextBox.Visible = true;
                    selectRssSourceButton.Visible = false;
                    rssSourceLabel.Visible = false;
                    break;

                default:
                    break;

            }

        }

        private void textSourceTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textSourceTextBox.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(textSourceTextBox, "Debe ingresar un texto para la fuente");
                return;


            }

            errorProvider1.SetError(textSourceTextBox, null);

        }

        private void selectRssSourceButton_Click(object sender, EventArgs e)
        {

            var selectionMode = true;
            var rssSourceAdmin = new RssSourceAdmin(selectionMode);
            this.StyleManager.Clone(rssSourceAdmin);

            if (rssSourceAdmin.ShowDialog(this) == DialogResult.OK)
            {

                rssSourceLabel.Visible = true;
                var rssSource = rssSourceAdmin.iSelectedRssSource;
                rssSourceLabel.Text = string.Format(
                    "Id: {1}{0}Descripcion: {2}{0}Url: {3}{0}",
                    Environment.NewLine,
                    rssSource.Id,
                    rssSource.Description,
                    rssSource.Url
                );
                iBannerModel.Source = rssSource;

            }
        }

        private void selectRssSourceButton_Validating(object sender, CancelEventArgs e)
        {

            if (sourceComboBox.SelectedItem.ToString() == RSS_SOURCE && iBannerModel.Source == null)
            {

                e.Cancel = true;
                errorProvider1.SetError(selectRssSourceButton, "Debe seleccionar una fuente RSS");
                return;

            }

            errorProvider1.SetError(selectRssSourceButton, null);

        }
    }
}

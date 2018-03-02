using BLL;
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

namespace UI
{
    public partial class CampaignForm : MetroForm

    {

        public CampaignDTO iCampaignModel;

        public CampaignForm(CampaignDTO pCampaign)
        {
            InitializeComponent();

            imagesGridView.AutoGenerateColumns = false;

            if (pCampaign != null)
            {
                iCampaignModel = pCampaign;
                loadCampaignInView();
            }
            else
            {

                iCampaignModel = new CampaignDTO();
                iCampaignModel.Images = new List<ImageDTO>();

            }
            
        }

        private void loadCampaignInView()
        {
            nameTextBox.Text = iCampaignModel.Name;
            descriptionTextBox.Text = iCampaignModel.Description;
            initDatePicker.Value = iCampaignModel.InitDate;
            endDatePicker.Value = iCampaignModel.EndDate;
            initTimeHours.SelectedIndex = iCampaignModel.InitTime.Hours;
            initTimeMinutes.SelectedIndex = iCampaignModel.InitTime.Minutes;
            endTimeHours.SelectedIndex = iCampaignModel.EndTime.Hours;
            endTimeMinutes.SelectedIndex = iCampaignModel.EndTime.Minutes;
            refreshImagesGridView();
           
        }

        private void updateCampaignFromView()
        {
            iCampaignModel.Name = nameTextBox.Text;
            iCampaignModel.Description = descriptionTextBox.Text;
            iCampaignModel.InitDate = initDatePicker.Value;
            iCampaignModel.EndDate = endDatePicker.Value;

            int hours = int.Parse(initTimeHours.SelectedItem.ToString());
            int minutes = int.Parse(initTimeMinutes.SelectedItem.ToString());
            iCampaignModel.InitTime = new TimeSpan(hours, minutes, 0);

            hours = int.Parse(endTimeHours.SelectedItem.ToString());
            minutes = int.Parse(endTimeMinutes.SelectedItem.ToString());
            iCampaignModel.EndTime = new TimeSpan(hours, minutes, 0);

        }

        private void refreshImagesGridView()
        {

            iCampaignModel.Images = iCampaignModel.Images.OrderBy(i => i.Order).ToList();
            imagesGridView.DataSource = iCampaignModel.Images;
            imagesGridView.Update();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            if (MetroMessageBox.Show(this, "si sale perdera todos los cambios realizados", "Esta seguro de salir del formulario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Close();

            }

            
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            var imageForm = new ImageForm(null, getImageListLength());
            StyleManager.Clone(imageForm);

            if (imageForm.ShowDialog(this) == DialogResult.OK)
            {

                var newImage = imageForm.iImageModel;
                var lastIndex = 1 + getImageListLength();

                //checkear que no ocupe el orden que ya tenia otra imagen
                if (newImage.Order != lastIndex)
                {

                    var solapedImage = iCampaignModel.Images.Where(image => image.Order == newImage.Order).First();
                    solapedImage.Order = lastIndex;

                }

                iCampaignModel.Images.Add(imageForm.iImageModel);
                refreshImagesGridView();

            }
            
        }

        private int getImageListLength()
        {

            return iCampaignModel.Images != null ? iCampaignModel.Images.Count : 0;

        }

        private void modifyImageButton_Click(object sender, EventArgs e)
        {
            if (imagesGridView.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Para modificar primero debe seleccionar una imagen de la lista", "No hay ninguna imagen seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var imageForm = new ImageForm(
                DeepCopyHelper.DeepCopy<ImageDTO>((ImageDTO)imagesGridView.SelectedRows[0].DataBoundItem),
                getImageListLength()
            );
            StyleManager.Clone(imageForm);

            if (imageForm.ShowDialog(this) == DialogResult.OK)
            {

                var updatedImage = imageForm.iImageModel;
                var oldImage = iCampaignModel.Images.Where(i => i.Id == updatedImage.Id).First();

                //checkear que no ocupe el orden que ya tenia otra imagen
                if (updatedImage.Order != oldImage.Order)
                {

                    var solapedImage = iCampaignModel.Images.Where(image => image.Order == updatedImage.Order).First();
                    solapedImage.Order = oldImage.Order;

                }

                iCampaignModel.Images[iCampaignModel.Images.IndexOf(oldImage)] = updatedImage;
                refreshImagesGridView();

            }

        }

        private void deleteImageButton_Click(object sender, EventArgs e)
        {
            if (imagesGridView.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Para eliminar primero debe seleccionar una imagen de la lista", "No hay ninguna imagen seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedImage = (ImageDTO)imagesGridView.SelectedRows[0].DataBoundItem;
            var index = iCampaignModel.Images.IndexOf(selectedImage);
            iCampaignModel.Images.RemoveAt(index);
            refreshImagesGridView();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                try
                {
                    updateCampaignFromView();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error con los datos de la campaña, por favor intente cargarla nuevamente", "Error al guardar la campaña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
          
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(nameTextBox, "El nombre de la campaña es obligatorio.");
                return;
            }
            errorProvider1.SetError(nameTextBox, null);

        }

        private void descriptionTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(descriptionTextBox, "La descripcion de la campaña es obligatoria.");
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

        private void imagesGridView_Validating(object sender, CancelEventArgs e)
        {
            if (iCampaignModel.Images.Count == 0)
            {
                errorProvider1.SetError(imagesGridView, "La campaña debe contener al menos una imagen");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(imagesGridView, null);
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
            if(initTimeIsAfterEndTime())
            {
                e.Cancel = true;
                errorProvider1.SetError(endTimeMinutes, "La hora de finalizacion debe ser despues de la hora de inicio");
                return;
            }
            errorProvider1.SetError(initTimeMinutes, null);
        }

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

        private bool initDateIsAfterEndDate()
        {
            return initDatePicker.Value.CompareTo(endDatePicker.Value) > 0;
        }

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
    }
}

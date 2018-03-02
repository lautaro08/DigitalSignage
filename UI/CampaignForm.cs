using BLL;
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

            imagesGridView.AutoGenerateColumns = false;

            if (pCampaign != null)
            {
                iCampaignModel = pCampaign;
                loadCampaignInView();
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

        private void refreshImagesGridView()
        {

            iCampaignModel.Images = iCampaignModel.Images.OrderBy(i => i.Order).ToList();
            imagesGridView.DataSource = iCampaignModel.Images;
            imagesGridView.Update();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void imagesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private int getImageListLength()
        {

            return iCampaignModel.Images != null ? iCampaignModel.Images.Count : 0;

        }
    }
}

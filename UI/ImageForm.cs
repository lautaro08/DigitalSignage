using DTO;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ImageForm : MetroForm
    {

        public ImageDTO iImageModel;
        
        public ImageForm(ImageDTO pImage, int pImageListLength)
        {
            InitializeComponent();

            for (int i = 1; i <= pImageListLength; i++)
            {
                orderComboBox.Items.Add(i);
            }

            if (pImage != null)
            {

                iImageModel = pImage;
                loadImageInView();

            }
            else
            {
                iImageModel = new ImageDTO();
                orderComboBox.Items.Add(pImageListLength + 1);

            }

        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picureBox.Image = new Bitmap(open.FileName);
                // image file path  
                selectedImagePath.Text = open.FileName;
            }
        }

        private void loadImageInView()
        {

            picureBox.Image = byteArrayToImage(iImageModel.Bytes);
            orderComboBox.SelectedIndex = orderComboBox.FindStringExact(iImageModel.Order.ToString());
            durationTextBox.Text = iImageModel.Duration.ToString();
            descriptionTextBox.Text = iImageModel.Description;

        }

        private void updateImageFromView()
        {

            iImageModel.Bytes = imageToByteArray(picureBox.Image);
            iImageModel.Order = Int32.Parse(orderComboBox.SelectedItem.ToString());
            iImageModel.Duration = Int32.Parse(durationTextBox.Text);
            iImageModel.Description = descriptionTextBox.Text;

        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                try
                {
                    updateImageFromView();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error con los datos de la imagen, por favor intente cargarla nuevamente", "Error al guardar la imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }

        }

        private void descriptionTextBox_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(descriptionTextBox, "La descripcion de la imagen es obligatoria.");
                return;
            }
            errorProvider1.SetError(descriptionTextBox, null);

        }

        private void picureBox_Validating(object sender, CancelEventArgs e)
        {

            if (picureBox == null || picureBox.Image == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(picureBox, "Debe seleccionar una imagen.");
                return;
            }
            errorProvider1.SetError(picureBox, null);

        }

        private void orderComboBox_Validating(object sender, CancelEventArgs e)
        {

            if (orderComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(orderComboBox, "Debe seleccionar un orden de aparicion para la imagen.");
                return;
            }
            errorProvider1.SetError(orderComboBox, null);

        }

        private void durationTextBox_Validating(object sender, CancelEventArgs e)
        {

            int intObj;
            if (!Int32.TryParse(durationTextBox.Text, out intObj))
            {
                e.Cancel = true;
                errorProvider1.SetError(durationTextBox, "Debe ingresar un numero entero");
                return;
            }
            errorProvider1.SetError(durationTextBox, null);

        }
    }
}

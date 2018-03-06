using BLL;
using DTO;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    /// <summary>
    /// pantalla para gestion de banners
    /// </summary>
    public partial class BannerAdmin : MetroForm
    {

        //resuelve la dependencia para el servicio de campañas
        private IBannerService iBannerService = IoCContainerLocator.Container.Resolve<IBannerService>();

        //constates para definir los tipos de filtrados
        private const string SEARCH_ALL = "todos los banners";
        private const string SEARCH_TODAY = "banners activos hoy";
        private const string SEARCH_BY_DATE = "banners activos en la fecha:";
        private const string SEARCH_BY_ID = "banner con el id:";
        private const string SEARCH_BY_NAME = "banners con el nombre:";

        public BannerAdmin()
        {
            InitializeComponent();

            //Carga de la tabla de campañas
            bannersGridView.AutoGenerateColumns = false;

            //carga de opciones de busqueda
            filterComboBox.Items.Add(SEARCH_ALL);
            filterComboBox.Items.Add(SEARCH_TODAY);
            filterComboBox.Items.Add(SEARCH_BY_DATE);
            filterComboBox.Items.Add(SEARCH_BY_ID);
            filterComboBox.Items.Add(SEARCH_BY_NAME);

            //filtro por defectp
            filterComboBox.SelectedItem = SEARCH_TODAY;

        }

        /*
         
          -----> BUTTONS CLICK <-----
              
        */

        private void modifyBannerButton_Click(object sender, EventArgs e)
        {

            if (bannersGridView.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Para eliminar primero debe seleccionar un banner de la lista", "No hay ningun banner seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //se hace depp copy para evitar que el formulario de banner modifique el objeto antes de guardarlo
            var bannerForm = new BannerForm(
                DeepCopyHelper.DeepCopy<BannerDTO>((BannerDTO)bannersGridView.SelectedRows[0].DataBoundItem)
            );
            StyleManager.Clone(bannerForm);

            if (bannerForm.ShowDialog(this) == DialogResult.OK)
            {

                //modificar el banner
                try
                {

                    iBannerService.Update(bannerForm.iBannerModel);
                    MetroMessageBox.Show(this, "se han modificado todos los datos", "Exito al modificar el banner", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    reloadSearch();
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al modificar el banner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void addBannerButton_Click(object sender, EventArgs e)
        {

            var bannerForm = new BannerForm(null);
            StyleManager.Clone(bannerForm);

            if (bannerForm.ShowDialog(this) == DialogResult.OK)
            {

                //guardar el banner
                try
                {

                    iBannerService.Create(bannerForm.iBannerModel);
                    MetroMessageBox.Show(this, "a partir de ahora el banner creado estara disponible en el sistema", "Exito al crear el banner", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    reloadSearch();
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al crear el banner", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void deleteBannerButton_Click(object sender, EventArgs e)
        {
            if (bannersGridView.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Para eliminar primero debe seleccionar un banner de la lista", "No hay ningun banner seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MetroMessageBox.Show(this, "Si elimina este banner no podra recuperarla en el futuro", "¿Esta seguro de eliminar el banner seleccionado?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //eliminar el banner
                try
                {

                    iBannerService.Remove((BannerDTO)bannersGridView.SelectedRows[0].DataBoundItem);
                    MetroMessageBox.Show(this, "a partir de ahora el banner no estara mas en el sistema", "Exito al eliminar el banner", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    reloadSearch();
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al eliminar el banner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //si el campo de busqueda es valido
            if (ValidateChildren(ValidationConstraints.Visible))
            {

                switch (filterComboBox.SelectedItem.ToString())
                {

                    //mostrar el banner con un id
                    case SEARCH_BY_ID:
                        try
                        {
                            var oneElementList = new List<BannerDTO>();
                            var foundElement = iBannerService.Get(Int32.Parse(searchTextBox.Text));

                            //si se encontro el banner
                            if (foundElement.Id != 0)
                            {

                                oneElementList.Add(foundElement);
                                bannersGridView.DataSource = oneElementList;
                                bannersGridView.Refresh();

                            }
                            else
                            {

                                bannersGridView.DataSource = null;
                                bannersGridView.Refresh();
                                MetroMessageBox.Show(this, "No hay ningun banner en el sistema que coincida con la busqueda", "No se encontraron resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener banners", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    //mostrar todos los banner con el nombre ingresado
                    case SEARCH_BY_NAME:
                        try
                        {

                            var campaignsResult = iBannerService.GetBannersByName(searchTextBox.Text);
                            bannersGridView.DataSource = campaignsResult;
                            bannersGridView.Refresh();
                            checkEmptyList();

                        }
                        catch (Exception ex)
                        {

                            bannersGridView.DataSource = null;
                            bannersGridView.Refresh();
                            MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener banners", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        break;

                    default:
                        break;

                }

            }

        }

        /*
         
          -----> VALUE CHANGES <-----
              
        */

        private void filterComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            switch (filterComboBox.SelectedItem.ToString())
            {

                //mostrar todos los banner
                case SEARCH_ALL:
                    searchButton.Visible = false;
                    searchTextBox.Visible = false;
                    searchDatePicker.Visible = false;
                    LoadAllBanners();
                    break;

                //mostrar todos los banner activas hoy
                case SEARCH_TODAY:
                    searchButton.Visible = false;
                    searchTextBox.Visible = false;
                    searchDatePicker.Visible = true;
                    searchDatePicker.Enabled = false;
                    searchDatePicker.Value = DateTime.Now;
                    break;

                //mostrar todos los banner activas en una fecha
                case SEARCH_BY_DATE:
                    searchButton.Visible = false;
                    searchTextBox.Visible = false;
                    searchDatePicker.Visible = true;
                    searchDatePicker.Enabled = true;
                    searchDatePicker.Value = DateTime.Now;
                    break;

                //mostrar el banner con un id
                case SEARCH_BY_ID:
                    searchButton.Visible = true;
                    searchTextBox.Visible = true;
                    searchDatePicker.Visible = false;
                    break;

                //mostrar todos los banner con el nombre ingresado
                case SEARCH_BY_NAME:
                    searchButton.Visible = true;
                    searchTextBox.Visible = true;
                    searchDatePicker.Visible = false;
                    break;

                default:
                    break;

            }

        }

        private void searchDatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadBannersActiveInDate();
        }


        /*
         
          -----> VALIDATIONS <-----
              
        */


        private void searchTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            var selectedFilter = filterComboBox.SelectedItem.ToString();
            int intOut;

            //valida que no sea nulo
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(searchTextBox, "El parametro de busqueda no puede estar vacio");
                return;

            }

            //valida que sea un entero en el caso de buscar por id
            if (selectedFilter == SEARCH_BY_ID && !Int32.TryParse(searchTextBox.Text, out intOut))
            {

                e.Cancel = true;
                errorProvider1.SetError(searchTextBox, "Debe ingresar un numero entero");
                return;

            }

            errorProvider1.SetError(searchTextBox, null);

        }


        /*
         
          -----> AUX FUNCTIONS <-----
              
        */

        /// <summary>
        /// carga todos los banners en pantalla
        /// </summary>
        void LoadAllBanners()
        {

            try
            {
                bannersGridView.DataSource = iBannerService.GetAll();
                bannersGridView.Refresh();
                checkEmptyList();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener banners", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// carga los banners activos en la fecha que se encuentra seleccionada
        /// </summary>
        void LoadBannersActiveInDate()
        {

            try
            {
                bannersGridView.DataSource = iBannerService.GetBannersActiveInDate(searchDatePicker.Value);
                bannersGridView.Refresh();
                checkEmptyList();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener banners", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Verifica que el resultado de una busqueda haya quedado vacio, en cuyo caso muestra un mensaje informandolo
        /// </summary>
        void checkEmptyList()
        {

            //si no hay ninguna campaña que coincida
            if (bannersGridView.Rows.Count == 0 && this.Created == true)
            {

                MetroMessageBox.Show(this, "No hay ningun banner en el sistema que coincida con la busqueda", "No se encontraron resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        /// <summary>
        /// Recarga la busqueda que se encontraba realizada para actualizar las entidades
        /// </summary>
        void reloadSearch()
        {

            bannersGridView.DataSource = null;
            bannersGridView.Refresh();
            switch (filterComboBox.SelectedItem.ToString())
            {

                //mostrar todos los banners
                case SEARCH_ALL:
                    LoadAllBanners();
                    break;

                //mostrar todos los banners activos hoy
                case SEARCH_TODAY:
                    LoadBannersActiveInDate();
                    break;

                //mostrar todos los banners activos en una fecha
                case SEARCH_BY_DATE:
                    LoadBannersActiveInDate();
                    break;

                //mostrar el banner con un id
                case SEARCH_BY_ID:
                    //recarga la busqueda
                    searchButton_Click(searchButton, EventArgs.Empty);
                    break;

                //mostrar todos los banners con el nombre ingresado
                case SEARCH_BY_NAME:
                    //recarga la busqueda
                    searchButton_Click(searchButton, EventArgs.Empty);
                    break;

                default:
                    break;

            }

        }

    }
}

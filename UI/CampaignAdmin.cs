using System;
using BLL;
using Microsoft.Practices.Unity;
using System.Windows.Forms;
using MetroFramework.Forms;
using DTO;
using MetroFramework;
using System.Collections.Generic;

namespace UI
{

    /// <summary>
    /// Pantalla para la gestion de las campañas
    /// </summary>
    public partial class CampaignAdmin : MetroForm
    {

        //resuelve la dependencia para el servicio de campañas
        private ICampaignService iCampaignService = IoCContainerLocator.Container.Resolve<ICampaignService>();

        //constates para definir los tipos de filtrados
        private const string SEARCH_ALL = "todas las campañas";
        private const string SEARCH_TODAY = "campañas activas hoy";
        private const string SEARCH_BY_DATE = "campañas activas en la fecha:";
        private const string SEARCH_BY_ID = "campaña con el id:";
        private const string SEARCH_BY_NAME = "campañas con el nombre:";

        public CampaignAdmin()
        {
            InitializeComponent();

            //Carga de la tabla de campañas
            campaignsGridView.AutoGenerateColumns = false;

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

        private void modifyCampaignButton_Click(object sender, EventArgs e)
        {

            if (campaignsGridView.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Para eliminar primero debe seleccionar una campaña de la lista", "No hay ninguna campaña seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //se hace depp copy para evitar que el formulario de campaña modifique el objeto antes de guardarlo
            var camapignForm = new CampaignForm(
                DeepCopyHelper.DeepCopy<CampaignDTO>((CampaignDTO)campaignsGridView.SelectedRows[0].DataBoundItem)
            );
            StyleManager.Clone(camapignForm);

            if (camapignForm.ShowDialog(this) == DialogResult.OK)
            {

                //modificar la campaña
                try
                {

                    iCampaignService.Update(camapignForm.iCampaignModel);
                    MetroMessageBox.Show(this, "se han modificado todos los datos", "Exito al modificar la campaña", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    reloadSearch();
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
            StyleManager.Clone(camapignForm);

            if (camapignForm.ShowDialog(this) == DialogResult.OK)
            {

                //guardar la campaña
                try
                {

                    iCampaignService.Create(camapignForm.iCampaignModel);
                    MetroMessageBox.Show(this, "a partir de ahora la campaña creada estara disponible en el sistema", "Exito al crear la campaña", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    reloadSearch();
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al crear la campaña", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void deleteCampaignButton_Click(object sender, EventArgs e)
        {
            if (campaignsGridView.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Para eliminar primero debe seleccionar una campaña de la lista", "No hay ninguna campaña seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MetroMessageBox.Show(this, "Si elimina esta camapaña no podra recuperarla en el futuro", "¿Esta seguro de eliminar la campaña seleccionada?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //eliminar la campaña
                try
                {

                    iCampaignService.Remove((CampaignDTO)campaignsGridView.SelectedRows[0].DataBoundItem);
                    MetroMessageBox.Show(this, "a partir de ahora la campaña no estara mas en el sistema", "Exito al eliminar la campaña", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    reloadSearch();
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al eliminar la campaña", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    //mostrar la campaña con un id
                    case SEARCH_BY_ID:
                        try
                        {
                            var oneElementList = new List<CampaignDTO>();
                            var foundElement = iCampaignService.Get(Int32.Parse(searchTextBox.Text));

                            //si se encontro la campaña
                            if (foundElement.Id != 0)
                            {

                                oneElementList.Add(foundElement);
                                campaignsGridView.DataSource = oneElementList;
                                campaignsGridView.Refresh();

                            }
                            else
                            {

                                campaignsGridView.DataSource = null;
                                campaignsGridView.Refresh();
                                MetroMessageBox.Show(this, "No hay ninguna campaña en el sistema que coincida con la busqueda", "No se encontraron resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener campaña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    //mostrar todas las campañas con el nombre ingresado
                    case SEARCH_BY_NAME:
                        try
                        {

                            var campaignsResult = iCampaignService.GetCampaignsByName(searchTextBox.Text);
                            campaignsGridView.DataSource = campaignsResult;
                            campaignsGridView.Refresh();
                            checkEmptyList();
                           
                        }
                        catch (Exception ex)
                        {

                            campaignsGridView.DataSource = null;
                            campaignsGridView.Refresh();
                            MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener campañas", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                //mostrar todas las campañas
                case SEARCH_ALL:
                    searchButton.Visible = false;
                    searchTextBox.Visible = false;
                    searchDatePicker.Visible = false;
                    LoadAllCampaigns();
                    break;

                //mostrar todas las campañas activas hoy
                case SEARCH_TODAY:
                    searchButton.Visible = false;
                    searchTextBox.Visible = false;
                    searchDatePicker.Visible = true;
                    searchDatePicker.Enabled = false;
                    searchDatePicker.Value = DateTime.Now;
                    break;

                //mostrar todas las campañas activas en una fecha
                case SEARCH_BY_DATE:
                    searchButton.Visible = false;
                    searchTextBox.Visible = false;
                    searchDatePicker.Visible = true;
                    searchDatePicker.Enabled = true;
                    searchDatePicker.Value = DateTime.Now;
                    break;

                //mostrar la campaña con un id
                case SEARCH_BY_ID:
                    searchButton.Visible = true;
                    searchTextBox.Visible = true;
                    searchDatePicker.Visible = false;
                    break;

                //mostrar todas las campañas con el nombre ingresado
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
            LoadCampaignsActiveInDate();
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
        /// carga todas las campañas en pantalla
        /// </summary>
        void LoadAllCampaigns()
        {

            try
            {
                campaignsGridView.DataSource = iCampaignService.GetAll();
                campaignsGridView.Refresh();
                checkEmptyList();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener campañas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        /// <summary>
        /// carga las pantallas activas en la fecha que se encuentra seleccionada
        /// </summary>
        void LoadCampaignsActiveInDate()
        {

            try
            {
                campaignsGridView.DataSource = iCampaignService.GetCampaignsActiveInDate(searchDatePicker.Value);
                campaignsGridView.Refresh();
                checkEmptyList();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener campañas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Verifica que el resultado de una busqueda haya quedado vacio, en cuyo caso muestra un mensaje informandolo
        /// </summary>
        void checkEmptyList()
        {

            //si no hay ninguna campaña que coincida
            if (campaignsGridView.Rows.Count == 0 && this.Created == true)
            {

                MetroMessageBox.Show(this, "No hay ninguna campaña en el sistema que coincida con la busqueda", "No se encontraron resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        /// <summary>
        /// Recarga la busqueda que se encontraba realizada para actualizar las entidades
        /// </summary>
        void reloadSearch()
        {

            campaignsGridView.DataSource = null;
            campaignsGridView.Refresh();
            switch (filterComboBox.SelectedItem.ToString())
            {

                //mostrar todas las campañas
                case SEARCH_ALL:
                    LoadAllCampaigns();
                    break;

                //mostrar todas las campañas activas hoy
                case SEARCH_TODAY:
                    LoadCampaignsActiveInDate();
                    break;

                //mostrar todas las campañas activas en una fecha
                case SEARCH_BY_DATE:
                    LoadCampaignsActiveInDate();
                    break;

                //mostrar la campaña con un id
                case SEARCH_BY_ID:
                    //recarga la busqueda
                    searchButton_Click(searchButton, EventArgs.Empty);
                    break;

                //mostrar todas las campañas con el nombre ingresado
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

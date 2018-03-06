using BLL;
using DTO;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Banner_source_forms;

namespace UI.RssSource_source_forms
{

    /// <summary>
    /// pantalla para gestion de fuentes RSS
    /// </summary>
    public partial class RssSourceAdmin : MetroForm
    {

        //resuelve la dependencia para el servicio de fuentes RSS
        private IRssSourceService iRssSourceService = IoCContainerLocator.Container.Resolve<IRssSourceService>();

        //constates para definir los tipos de filtrados
        private const string SEARCH_ALL = "todas las fuentes RSS";
        private const string SEARCH_BY_ID = "fuente RSS con el id:";

        //variable para almacenar la fuente seleccionada
        public RssSourceDTO iSelectedRssSource;

        public RssSourceAdmin(bool pSelectionMode = false)
        {
            InitializeComponent();

            rssSourcesGridView.AutoGenerateColumns = false;

            //carga de opciones de busqueda
            filterComboBox.Items.Add(SEARCH_ALL);
            filterComboBox.Items.Add(SEARCH_BY_ID);

            //filtro por defectp
            filterComboBox.SelectedItem = SEARCH_ALL;

            if (pSelectionMode)
            {

                deleteRssSourceButton.Visible = false;
                modifyRssSourceButton.Visible = false;
                selectRssSourceButton.Visible = true;

            }
        }

        /*
         
          -----> BUTTONS CLICK <-----
              
        */

        private void modifyRssSourceButton_Click(object sender, EventArgs e)
        {

            if (rssSourcesGridView.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Para eliminar primero debe seleccionar una fuente RSS de la lista", "No hay ninguna fuente RSS seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //se hace depp copy para evitar que el formulario de fuente RSS modifique el objeto antes de guardarlo
            var rssSourceForm = new RssSourceForm(
                DeepCopyHelper.DeepCopy<RssSourceDTO>((RssSourceDTO)rssSourcesGridView.SelectedRows[0].DataBoundItem)
            );
            StyleManager.Clone(rssSourceForm);

            if (rssSourceForm.ShowDialog(this) == DialogResult.OK)
            {

                //modificar la fuente RSS
                try
                {

                    iRssSourceService.Update(rssSourceForm.iRssSourceModel);
                    MetroMessageBox.Show(this, "se han modificado todos los datos", "Exito al modificar la fuente RSS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    reloadSearch();
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al modificar la fuente RSS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void addRssSourceButton_Click(object sender, EventArgs e)
        {

            var rssSourceForm = new RssSourceForm(null);
            StyleManager.Clone(rssSourceForm);

            if (rssSourceForm.ShowDialog(this) == DialogResult.OK)
            {

                //guardar la fuente rss
                try
                {

                    iRssSourceService.Create(rssSourceForm.iRssSourceModel);
                    MetroMessageBox.Show(this, "a partir de ahora la fuente RSS estara disponible en el sistema", "Exito al crear la fuente RSS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    reloadSearch();
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al crear la fuente RSS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void deleteRssSourceButton_Click(object sender, EventArgs e)
        {
            if (rssSourcesGridView.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Para eliminar primero debe seleccionar una fuente RSS de la lista", "No hay ninguna fuente RSS seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MetroMessageBox.Show(this, "Si elimina esta fuente RSS no podra recuperarla en el futuro", "¿Esta seguro de eliminar la fuente RSS seleccionada?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //eliminar la fuente RSS
                try
                {

                    iRssSourceService.Remove((RssSourceDTO)rssSourcesGridView.SelectedRows[0].DataBoundItem);
                    MetroMessageBox.Show(this, "a partir de ahora la fuente RSS no estara mas en el sistema", "Exito al eliminar la fuente RSS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    reloadSearch();
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al eliminar la fuente RSS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //si el campo de busqueda es valido
            if (ValidateChildren(ValidationConstraints.Visible))
            {

                if (filterComboBox.SelectedItem.ToString() == SEARCH_BY_ID)
                {

                    try
                    {
                        var oneElementList = new List<RssSourceDTO>();
                        var foundElement = iRssSourceService.Get(Int32.Parse(searchTextBox.Text));

                        //si se encontro el RssSource
                        if (foundElement.Id != 0)
                        {

                            oneElementList.Add(foundElement);
                            rssSourcesGridView.DataSource = oneElementList;
                            rssSourcesGridView.Refresh();

                        }
                        else
                        {

                            rssSourcesGridView.DataSource = null;
                            rssSourcesGridView.Refresh();
                            MetroMessageBox.Show(this, "No hay ninguna fuente RSS en el sistema que coincida con la busqueda", "No se encontraron resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener la fuente RSS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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

                //mostrar todos los RssSource
                case SEARCH_ALL:
                    searchButton.Visible = false;
                    searchTextBox.Visible = false;
                    LoadAllRssSources();
                    break;

                //mostrar el RssSource con un id
                case SEARCH_BY_ID:
                    searchButton.Visible = true;
                    searchTextBox.Visible = true;
                    break;

                default:
                    break;

            }

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
        /// carga todos los RssSources en pantalla
        /// </summary>
        void LoadAllRssSources()
        {

            try
            {
                rssSourcesGridView.DataSource = iRssSourceService.GetAll();
                rssSourcesGridView.Refresh();
                checkEmptyList();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "detalles del error: " + ex.Message, "Error al obtener las fuentes RSS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Verifica que el resultado de una busqueda haya quedado vacio, en cuyo caso muestra un mensaje informandolo
        /// </summary>
        void checkEmptyList()
        {

            //si no hay ninguna campaña que coincida
            if (rssSourcesGridView.Rows.Count == 0 && this.Created == true)
            {

                MetroMessageBox.Show(this, "No hay ninguna fuente RSS en el sistema que coincida con la busqueda", "No se encontraron resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        /// <summary>
        /// Recarga la busqueda que se encontraba realizada para actualizar las entidades
        /// </summary>
        void reloadSearch()
        {

            rssSourcesGridView.DataSource = null;
            rssSourcesGridView.Refresh();
            switch (filterComboBox.SelectedItem.ToString())
            {

                //mostrar todos los RssSources
                case SEARCH_ALL:
                    LoadAllRssSources();
                    break;

                //mostrar el RssSource con un id
                case SEARCH_BY_ID:
                    //recarga la busqueda
                    searchButton_Click(searchButton, EventArgs.Empty);
                    break;

                default:
                    break;

            }

        }

        private void selectRssSourceButton_Click(object sender, EventArgs e)
        {
            if (rssSourcesGridView.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Primero debe seleccionar una fuente RSS de la lista", "No hay ninguna fuente RSS seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            iSelectedRssSource = (RssSourceDTO)rssSourcesGridView.SelectedRows[0].DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
                
        }
    }
}

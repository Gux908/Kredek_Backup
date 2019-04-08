using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KacperStudennyZadanieDomoweLab1
{
    /// <summary>
    /// Specjalny Form do rozbudowy zasobów na kolejne poziomy
    /// </summary>
    public partial class FormResources : Form
    {
        // Magazyn z Zasobami
        Village.Store store;
        Village.Resources resources;

        public FormResources(Village.Store store, Village.Resources resources)
        {
            this.store = store;
            this.resources = resources;
            InitializeComponent();
            SetValues();
            Show();
        }

        /// <summary>
        /// Ustawia dla Label'i odpowiednie wartości żeby wyświetlało prawdziwe informacje
        /// </summary>
        public void SetValues()
        {
            // Sprawdza czy typ jest Gold wtedy wyświetla mniejszą liczbe
            if (resources.GetType() == new Village.Gold().GetType())
            { 
                labelCurrentProduction.Text = (resources.BuildingLevel * resources.ProducedResourcesPerLevel / 2).ToString();
            }
            else
            {
                labelCurrentProduction.Text = (resources.BuildingLevel * resources.ProducedResourcesPerLevel).ToString();
            }
            labelCurrentBuildingCost.Text = store.NeddedResourceAmount(resources).ToString();
            labelCurrentLevel.Text = resources.BuildingLevel.ToString();
        }

        /// <summary>
        /// Przy spelnieniu warunkow pozwala podniesc wartosc zmiennej resources.BuildingLevel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            // Sprawdza czy jest wystarczająca ilośc zasobów
            if (store.IsEnoughResources(resources))
            {
                store.TakeUsedResources(resources);
                resources.AddBuildingLevel();
            }
            else
            {
                MessageBox.Show("Za mało zasobów");
            }
            // aktualizuje informacje w label'ach
            SetValues();
        }
    }
}

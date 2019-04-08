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
    public partial class FormBarracks : Form
    {
        private Village.Store store;

        /// <summary>
        /// Konstruktor z przekazywanym Store
        /// </summary>
        /// <param name="store"></param>
        public FormBarracks(Village.Store store)
        {
            this.store = store;
            InitializeComponent();
            // wyświetla maksymalną możliwą ilość do zrekrutowania
            labelSoldiersNumber.Text = store.RecruitableSoldiers().ToString();
            Show();
        }

        /// <summary>
        /// Przycisk rekrutuje żołnierzy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecruit_Click(object sender, EventArgs e)
        {
            // deklarowana przez gracza wartość do rekrutacji
            uint recruitSoldiers = uint.Parse(textBoxRecrutingSoldierNumber.Text);
            // sprawdza czy może tylu zrekrutować
            if (store.RecruitableSoldiers() > recruitSoldiers || recruitSoldiers > 0)
            {
                store.RecruitSoldiers(recruitSoldiers);
            }
            // Wyświetla nową wartość możliwych do zrekrutowania jednostek
            labelSoldiersNumber.Text = store.RecruitableSoldiers().ToString();
        }
    }
}

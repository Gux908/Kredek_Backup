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
    public partial class FormMap : Form
    {
        // ilość zniszczonych miejscowości na południu
        private int destoyedBottomVillages = 0;
        // ilość zniszczonych miejscowości na połnocy
        private int destoyedTopVillages = 0;
        // przechowuje zasób żołnierzy
        private Village.Soldiers soldiers;
        // przechowuje zmienne klasy Village.EventWar
        private Village.EventWar war;

        /// <summary>
        /// Konstruktor z przekazanym zasobem żołnierzy
        /// </summary>
        /// <param name="soldiers"></param>
        public FormMap(Village.Soldiers soldiers, Village.EventWar war)
        {
            InitializeComponent();
            this.soldiers = soldiers;
            this.war = war;
            labelMaxSoldiers.Text = "Max żołnierzy do wysłania: " + soldiers.SoldiersAmount.ToString();
            // Ustawia wszystkie prictureboxy na przezroczyste
            pictureBoxBottomVillageOne.BackColor = Color.Transparent;
            pictureBoxBottomVillageTwo.BackColor = Color.Transparent;
            pictureBoxBottomVillageThree.BackColor = Color.Transparent;
            pictureBoxTopVillageOne.BackColor = Color.Transparent;
            pictureBoxTopVillageTwo.BackColor = Color.Transparent;
            pictureBoxTopVillageThree.BackColor = Color.Transparent;
            pictureBoxCapitol.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Metoda wywoływana żeby zwiększyć licznik zniszczonych na południu wiosek 
        /// i by wstawić znacznik na mapie
        /// </summary>
        public void MarkDestroyedBottomVillages()
        {
            switch (destoyedBottomVillages)
            {
                case 0:
                    break;
                case 1:
                    pictureBoxBottomVillageOne.Image = Properties.Resources.marker;
                    break;
                case 2:
                    pictureBoxBottomVillageTwo.Image = Properties.Resources.marker;
                    break;
                case 3:
                    pictureBoxBottomVillageThree.Image = Properties.Resources.marker;
                    MessageBox.Show("Następna Będzie Stolica!");
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// Metoda wywoływana żeby zwiększyć licznik zniszczonych na północy wiosek 
        /// i by wstawić znacznik na mapie
        /// </summary>
        public void MarkDestroyedTopVillages()
        {
            switch (destoyedTopVillages)
            {
                case 0:
                    break;
                case 1:
                    pictureBoxTopVillageOne.Image = Properties.Resources.marker;
                    break;
                case 2:
                    pictureBoxTopVillageTwo.Image = Properties.Resources.marker;
                    break;
                case 3:
                    pictureBoxTopVillageThree.Image = Properties.Resources.marker;
                    MessageBox.Show("Następna Będzie Stolica!");
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// Funkcja wstawia znacznik na mapie na stolice
        /// </summary>
        public void destroyCapitol()
        {
            pictureBoxCapitol.Image = Properties.Resources.marker;
        }

        /// <summary>
        /// Przekierowuje zasób Soldier.SoldiersAmount do zmiennej war.ArmyOnTop.SoldiersAmount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendTop_Click(object sender, EventArgs e)
        {
            uint wantedSoldiers = uint.Parse(textBoxSendSoldiers.Text);
            if (soldiers.SoldiersAmount >= wantedSoldiers)
            {
                war.ArmyOnTop.SoldiersAmount += wantedSoldiers;
                soldiers.SoldiersAmount -= wantedSoldiers;
            }
        }

        /// <summary>
        /// Przekierowuje zasób Soldier.SoldiersAmount do zmiennej war.ArmyOnBottom.SoldiersAmount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendBottom_Click(object sender, EventArgs e)
        {
            uint wantedSoldiers = uint.Parse(textBoxSendSoldiers.Text);
            if (soldiers.SoldiersAmount >= wantedSoldiers)
            {
                war.ArmyOnBottom.SoldiersAmount += wantedSoldiers;
                soldiers.SoldiersAmount -= wantedSoldiers;
            }
        }

        /// <summary>
        /// Wyświetla okno i aktualizuje mapę
        /// </summary>
        /// <param name="war"></param>
        internal void ShowWindow(Village.EventWar war)
        {
            destoyedBottomVillages = war.DestoyedBottomVillages;
            destoyedTopVillages = war.DestoyedTopVillages;
            // wyświetla
            MarkDestroyedTopVillages();
            MarkDestroyedBottomVillages();
            Show();
        }
    }
}


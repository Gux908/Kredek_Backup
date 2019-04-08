using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace KacperStudennyZadanieDomoweLab1
{
    /// <summary>
    /// Głowna klasa wyświetlająca okno gry
    /// </summary>
    public partial class FormMain : Form
    {

        private Village.Store store;
        private Village.Event villageEvent;
        private Village.EventWar villageWar;
        private FormMap formMap;
        private SoundPlayer player;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            store = new Village.Store();
            villageEvent = new Village.Event();
            villageWar = new Village.EventWar();
            formMap = new FormMap(store.SoldierUnits, villageWar);

            //Startuje zegary
            timerGameTime.Start();
            timerFPS.Start();

            //Włącza muzykę
            player = new SoundPlayer("Village.wav");
            player.PlayLooping();
        }

        /// <summary>
        /// Uaktualnia wartość zasobów, jeden tik to jeden dzien w grze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGameTime_Tick(object sender, EventArgs e)
        {
            ++villageEvent.DaysPassed;
            store.ProduceResources();
            if (villageEvent.DaysPassed % 4 == 0)
            {
                villageWar.ActivateBonuses(store);
            }
            if (villageEvent.DaysPassed % 7 == 0)
            {
                villageEvent.HandleSoldier(store);
            }
            if (villageEvent.DaysPassed % 30 == 0)
            {
                if (villageWar.BattleHandler(store))
                {
                    EndGame();
                }
            }

        }

        /// <summary>
        /// Koniec gry, gdy przegrasz
        /// </summary>
        private void EndGame()
        {
            String Message="Przegrałeś, to koniec gry";
            new FormEvent(Message);
            timerFPS.Stop();
            timerGameTime.Stop();
            player.Stop();
        }

        /// <summary>
        /// Odświeża wiadomości w tabelach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFPS_Tick(object sender, EventArgs e)
        {
            labelGoldAmount.Text     = store.Gold.ResourceAmount.ToString();
            labelSteelAmount.Text    = store.Mine.ResourceAmount.ToString();
            labelWoodAmount.Text     = store.Wood.ResourceAmount.ToString();    
            labelWarriorsAmount.Text = store.SoldierUnits.SoldiersAmount.ToString();
            labelPeopleAmount.Text   = store.Citizens.ResourceAmount.ToString();
            labelDayNumber.Text = villageEvent.DaysPassed.ToString();
        }

        /// <summary>
        /// Wyświetla okno rozbudowy surowca Mine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSteelMine_Click(object sender, EventArgs e)
        {
            new FormResources(store, store.Mine);
        }

        /// <summary>
        /// Wyświetla okno rozbudowy surowca Wood
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWoodcutter_Click(object sender, EventArgs e)
        {
            new FormResources(store, store.Wood);
        }

        /// <summary>
        /// Wyświetla okno rozbudowy surowca Gold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCastle_Click(object sender, EventArgs e)
        {
            new FormResources(store, store.Gold);
        }

        /// <summary>
        /// Wyświetla okno rozbudowy surowca Citizens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFarm_Click(object sender, EventArgs e)
        {
            new FormResources(store, store.Citizens);
        }

        /// <summary>
        /// Wyświetla okno rozbudowy surowca żołnierze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBarracks_Click(object sender, EventArgs e)
        {
            new FormBarracks(store);
        }

        /// <summary>
        /// Wyświetla okno mapy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMap_Click(object sender, EventArgs e)
        {
            formMap.ShowWindow(villageWar);
        }
    }
}

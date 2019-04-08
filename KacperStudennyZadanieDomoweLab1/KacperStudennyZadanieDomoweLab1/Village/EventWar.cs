using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyZadanieDomoweLab1.Village
{
    /// <summary>
    /// Specjalna Klasa do zarządzania poczynaniami wojennymi w grze
    /// </summary>
    public class EventWar
    {
        // Wiadomosc w przypadku przegrania
        private String loseMessage;
        // wiadomosc w przypadku wygrania
        private String winMessage;
        // Ilosc zniszczonych wiosek na poludniu
        public int DestoyedBottomVillages { set; get; } 
        // Ilosc zniszczonych wiosek na polnocy
        public int DestoyedTopVillages { set; get; }
        // posiadane wojska na poludniu
        public Soldiers ArmyOnBottom { get; set; } 
        // posiadane wojska na polnocy
        public Soldiers ArmyOnTop { get; set; }
        // dotychczasowa ilosc przeprowadzonych atakow
        private uint attackAmount = 0;

        public EventWar()
        {
            DestoyedBottomVillages = 0;
            DestoyedTopVillages = 0;
            ArmyOnBottom = new Soldiers();
            ArmyOnTop = new Soldiers();
            ArmyOnBottom.SoldiersAmount = 0 ;
            ArmyOnTop.SoldiersAmount =0 ;
            loseMessage =               "Panie, przegraliśmy. Wojska stracone"
                +Environment.NewLine+   "wioska zrabowana, nie pozostawiono"
                + Environment.NewLine + "nikogo przy życiu.";
            winMessage = "Panie, odnieślimy zwycięstwo."
                + Environment.NewLine + "Wioska przetrwała i wciąż dostarcza"
                + Environment.NewLine + "Nam dodatkowych zasobów."
                + Environment.NewLine + "Ludzie się ciesza i wiwatują na naszą cześć";
        }

        /// <summary>
        /// Funkcja wywolana w przypadku ataku przeciwnikow
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        internal bool BattleHandler(Village.Store store)
        {
            // zwieksza ilosc dotychczasowych atakow
            ++attackAmount;
            bool winBottom = false;
            bool winTop = false;
            // Czy odparto atak na poludniu
            winBottom = IsWinnigFight(ArmyOnBottom, new Soldiers(attackAmount*30 + (uint)new Random().Next((int)attackAmount * 30 / 2), 2));
            //czy odparto atak na polnocy
            winTop = IsWinnigFight(ArmyOnTop, new Soldiers(attackAmount*30 + (uint)new Random().Next((int)attackAmount * 30 / 2), 2));

            // Jeśli wszystkie 3 wioski na polnocy lub poludniu sa zniszczone to atakowana jest stolica
            if (DestoyedTopVillages == 3 | DestoyedBottomVillages == 3)
            {
                return AttackCapitol(store, new Soldiers(attackAmount * 30 + (uint)new Random().Next((int)attackAmount * 30 / 2), 2));
                
            }
            // Gdy przegralo poludnie
            if (!winBottom)
            {
                // zmniejsza ilosc funkcjonujących wiosek
                DestoyedBottomVillages++;
            }
            if (!winTop)
            {
                // zmniejsza ilosc funkcjonujących wiosek
                DestoyedTopVillages++;
            }

            if (winBottom && winTop)
            {
                String message = "Gdy kurz już opadł, a ranni przestali płakać"
                    + Environment.NewLine + "dostrzec można było że wygraliśmy..."
                    + Environment.NewLine + "tym razem. Jednak nie obyło się bez strat";
                new FormEvent(message);
                return true;
            }
            if (winBottom || winTop)
            {
                String message = "Gdy kurz już opadł, a ranni przestali płakać"
                    + Environment.NewLine + "dostrzec można było że wygraliśmy..."
                    + Environment.NewLine + "tym razem. Jednak nie obyło się bez strat";
                new FormEvent(message);
                return true;
            }
            else
            {
                String message = "Tego dnia krzykom nie było końca"
                    + Environment.NewLine + "Najeźdźcy plądrowali wszystko co mogli"
                    + Environment.NewLine + "żadne cenności czy kobiety nie umknęły"
                    + Environment.NewLine + "im tego dnia."
                    + Environment.NewLine + "Nie pozwólmy by i nas dopadł ten los";
                new FormEvent(message);
                return true;
            }
        }

        /// <summary>
        /// Funkcja wywolywana w przypadku ataku na stolicę
        /// </summary>
        /// <param name="store"></param>
        /// <param name="vikings"></param>
        /// <returns></returns>
        private bool AttackCapitol(Store store, Soldiers vikings)
        {
            // Sprawdza czy bitwa jest wygrana
            bool isWinning = IsWinnigFight(store.SoldierUnits, vikings);


            if (isWinning)
            {
                String message = "Nie dali nam rady, mimo iż było ich wielu"
                    + Environment.NewLine + "Ale nie wiemy jak bedzie następnym razem";
                new FormEvent(message);
                return true;
            }
            else
            { 
                String message = "Przegraliśmy, to koniec Anglii";
                new FormEvent(message);
                return false;
            }

        }

        /// <summary>
        /// Funkcja sprawdza rezultat bitwy i odejmuje stracone jednostki
        /// </summary>
        /// <param name="soldiers"></param>
        /// <param name="vikings"></param>
        /// <returns></returns>
        private bool IsWinnigFight(Soldiers soldiers, Soldiers vikings)
        {
            // siła wojenna gracza
            uint playerStrenght = soldiers.SoldiersAmount * soldiers.FightingSkill;
            // siła przeciwnika
            uint computerStrenght = vikings.SoldiersAmount * vikings.FightingSkill;
            // przypadek wygranej
            if (playerStrenght > computerStrenght)
            {
                soldiers.SoldiersAmount =
                    (playerStrenght - computerStrenght) / soldiers.FightingSkill;
                return true;
            }
            else
            {
                soldiers.SoldiersAmount = 0;
                return false;
            }
        }

        /// <summary>
        /// Funkcja aktywowana daje bonusy do zasobow w zależnosci ile 
        /// wiosek jest jeszcze nie zniszcoznych
        /// </summary>
        /// <param name="store"></param>
        public void ActivateBonuses(Village.Store store)
        {
            // Zyski z wiosek z polnocy
            switch (DestoyedTopVillages)
            {
                case 0:
                    store.Wood.ResourceAmount += store.Wood.ProduceResources();
                    store.Gold.ResourceAmount += store.Gold.ProduceResources();
                    store.Citizens.ResourceAmount += 10;
                    break;
                case 1:
                    store.Gold.ResourceAmount += store.Gold.ProduceResources();
                    store.Citizens.ResourceAmount += 10;
                    break;
                case 2:
                    store.Citizens.ResourceAmount += 10;
                    break;
                default:
                    break;
            }

            // Zyski z wiosek z poludnia
            switch (DestoyedBottomVillages)
            {
                case 0:
                    store.Gold.ResourceAmount += store.Gold.ProduceResources();
                    store.SoldierUnits.SoldiersAmount += 1;
                    store.Mine.ResourceAmount += store.Mine.ProduceResources();
                    break;
                case 1:
                    store.Mine.ResourceAmount += store.Mine.ProduceResources();
                    store.SoldierUnits.SoldiersAmount += 1;
                    break;
                case 2:
                    store.Mine.ResourceAmount += store.Mine.ProduceResources();
                    break;
                default:
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyZadanieDomoweLab1.Village
{
    /// <summary>
    /// Klasa do zarządzania wydarzeniami nie-wojennymi
    /// </summary>
    public class Event
    {
        // Ilość dni które upłyneły w grze
        public uint DaysPassed { set; get; }

        public Event()
        {
            // Moment wystartowania gry
            DaysPassed = 0;
        }

        /// <summary>
        /// Sprawdza czy jakieś zdarzenie zachodzi w grze
        /// </summary>
        /// <param name="store"></param>
        public void EventHandler(Village.Store store)
        {
            HandleWood(store);
            HandlePeople(store);
            HandleMine(store);
            HandleGold(store);
           
        }


        /// <summary>
        /// W przypadku Gold.ResourceAmount = 0 zostaje obniżona wartość Wood.BuildingLevel
        /// </summary>
        /// <param name="store"></param>
        private void HandleGold(Store store)
        {
            if (store.Gold.ResourceAmount == 0)
            {
                // Zmniejsza poziom budynku
                store.Wood.BuildingLevel -= 1;
                String message  =           "Panie, na podzamczu krązy plotka"
                    + Environment.NewLine + "że nasz skarbiec świeci pustką."
                    + Environment.NewLine + "Jeśli to prawda to nie powinniśmy"
                    + Environment.NewLine + "tak rozrzucać pieniędzy, bo spowodowało"
                    + Environment.NewLine + "to, że część drwali odpuściła sobie pracę"
                    + Environment.NewLine + Environment.NewLine + "Poziom budynku drwali zmalał o poziom";
                new FormEvent(message);
            }
        }

        /// <summary>
        /// W przypadku za dużej różnicy w wartościach BuildingLevel zostaje zmniejszona
        /// ilość Citizens.ResourceAmount o pewną wartość
        /// </summary>
        /// <param name="store"></param>
        public void HandleMine(Village.Store store)
        {
            // Wartość graniczna
            uint toBigDiffrence = 5;

            
            if (store.Citizens.BuildingLevel - store.Mine.BuildingLevel < toBigDiffrence)
            {

                if (store.Citizens.ResourceAmount > 10)
                {
                    store.Citizens.ResourceAmount -= 10;
                }
                else
                {
                    store.Citizens.ResourceAmount = 0;
                }
                String message = "Panie, nasze kopalnie nie wyrabiają"
                    + Environment.NewLine + "z produkcją materiałów. Rodziny zaczynają"
                    + Environment.NewLine + "się wyprowadzać, bo nie mają z czego budować"
                    + Environment.NewLine + "domów. Powinniśmy rozbudować kopalnie";
                new FormEvent(message);
            }
        }

        /// <summary>
        /// W przypadku za dużej różnicy w wartościach ilością posiadanych zasobów zostaje zmniejszona
        /// ilość przechowywanej wartości Gold.ResourceAmount
        /// </summary>
        /// <param name="store"></param>
        public void HandlePeople(Village.Store store)
        {
            uint toBigDiffrence = 20;
            // Sprawdza czy wieśniaków jest maksymalnie 20 razy wiecej
            if (store.Citizens.BuildingLevel * store.Citizens.ProducedResourcesPerLevel / store.SoldierUnits.SoldiersAmount > toBigDiffrence)
            {
                // Losuje wartosc ile zabrac zasobow
                int stolenValue = new Random().Next(0, (int)store.Gold.ProduceResources());
                // Warunek żeby nie dać wartości ujemnej
                if (store.Gold.ResourceAmount < (uint)stolenValue)
                {
                    store.Gold.ResourceAmount = 0;
                }
                else
                {
                    store.Gold.ResourceAmount -= (uint)stolenValue;
                }
                String message =            "Panie, w mieście jest za mało straży."
                    + Environment.NewLine + "Nie jesteśmy wstanie upilnować motłochu,"
                    + Environment.NewLine + "a wczoraj w nocy okradziono skarbiec."
                    + Environment.NewLine + "Nikt tego nie zauważył. Powinniśmy poważnie"
                    + Environment.NewLine + "zastanowaić się nad zrekrutowaniem wojaków"
                    + Environment.NewLine + Environment.NewLine + "Straciliśmy złoto";
                new FormEvent(message);
            }
        }


        /// <summary>
        /// w przypadku dużej różnicy w BuildingLevel wartość tejże BuildingLevel
        /// zostanie zmniejszona
        /// </summary>
        /// <param name="store"></param>
        public void HandleWood(Village.Store store)
        {
            uint toBigDiffrence = 3;

            // Jeśli jest za duża rożnica w poziomach
            if (store.Wood.BuildingLevel - store.Mine.BuildingLevel > toBigDiffrence)
            {
                // Budynek nie może zawalić się całkowicie tzn. zejsc do poziomu 0
                if (store.Mine.BuildingLevel != 1)
                {
                    store.Mine.BuildingLevel--;
                }
                String message =            "Panie, mamy za mało drwali."
                    + Environment.NewLine + "Brakuje budulca, przez co oszczędni" 
                    +Environment.NewLine +  "górnicy oszczędzali na materiale do"
                    + Environment.NewLine + "utrzymywania konstrukcji tuneli"
                    + Environment.NewLine + "przez co jedna z odnóch zawaliła się"
                    + Environment.NewLine + "spróbujmy do tego nie dopuścić następnym razem"
                    + Environment.NewLine + Environment.NewLine + "Poziom kopalni zmniejszył się o jeden poziom";

                new FormEvent(message);
            }
        }

        /// <summary>
        /// W przypadku niewystarczającej ilości store.Gold.ResourcesAmount 
        /// zostaje zmniejszona ogólna ilość SoldierUnits.SoldiersAmount
        /// </summary>
        /// <param name="store"></param>
        public void HandleSoldier(Village.Store store)
        {
            // sprawdza czy można opłacić żołnierzy
            bool isPayed = store.SoldierUnits.PaySoldiers(store.Gold);
            if (isPayed == false)
            {
                // Losowa ilosc miedzy 1 a 1/3 posiadanych żołnierzy zostanie usunieta
                store.SoldierUnits.SoldiersAmount -= (uint)new Random().Next(1, (int)store.SoldierUnits.SoldiersAmount / 3);
                String message = "Panie, zabrakło nam złota, aby opłacić"
                    + Environment.NewLine + "tygodniowy żołd wojów."
                    + Environment.NewLine + "Musimy zacząć oszczędzać, bo nasze wojska"
                    + Environment.NewLine + "zaczynają dezerterować";
                new FormEvent(message);
            }
        }
    }
}

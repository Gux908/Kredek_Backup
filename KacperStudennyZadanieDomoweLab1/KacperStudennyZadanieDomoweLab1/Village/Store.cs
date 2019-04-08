using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyZadanieDomoweLab1.Village
{

    public class Store
    {
        // Służy do procentowego zwiększania kosztu rozbudowania budynku względem poprzedniego poziomu budynku
        public readonly double increamentPercent = 1.4;
        // Początkowa wartość na starcie gry zasobów jakich potrzeba do rozbudowania budynku
        public readonly int startingResourcesNeededToBuild = 100;

        // Zasoby osady
        public Resources Wood { get; set; }
        public Resources Mine { get; set; }
        public Resources Gold { get; set; }
        public Resources Citizens{ get; set; }
        public Soldiers SoldierUnits { get; set; }

        
        public Store()
        {
            Wood = new Resources(40);
            Mine = new Resources(50);
            Gold = new Gold(60);
            Citizens = new People(50);
            SoldierUnits = new Soldiers();
        }


        #region zarządzanie zasobami
        /// <summary>
        /// Sprawdza czy jest odpowiednia ilość zasobów (drewno, ludzie, jedzenie) potrzebnych do rozbudowania budynku
        /// </summary>
        /// <param name="resources"></param>
        /// <returns></returns>
        public Boolean IsEnoughResources(Resources resources)
        {
            // Oblicza ilość potrzebnych zasobów do rozbudowy budynku na następny poziom
            UInt64 neededResourceAmount = NeddedResourceAmount(resources);

            // Sprawdza czy wszystkich potrzebnych zasobów jest odpowienia ilość 
            if (Wood.ResourceAmount >= neededResourceAmount &&
                Gold.ResourceAmount >= neededResourceAmount &&
                Mine.ResourceAmount >= neededResourceAmount &&
                Citizens.ResourceAmount >=10)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Zwraca ilość materiałów potrzebnych do rozbudowy budynku na tym poziomie
        /// </summary>
        /// <param name="resources"></param>
        /// <returns></returns>
        public UInt64 NeddedResourceAmount(Resources resources)
        {
            return Convert.ToUInt64(Math.Pow(increamentPercent, resources.BuildingLevel) * startingResourcesNeededToBuild);
        }

        /// <summary>
        /// Wywoluje produkcje każdego z zasobów
        /// </summary>
        public void ProduceResources()
        {
            Wood.ResourceAmount += Wood.ProduceResources();
            Mine.ResourceAmount += Mine.ProduceResources();
            Gold.ResourceAmount += Gold.ProduceResources();
        }

        /// <summary>
        /// Usuwa odpowiednią ilość każdego z zasobów po rozbudowaniu budynku
        /// </summary>
        /// <param name="resources"></param>
        public void TakeUsedResources(Resources resources)
        {
            const int newWorkersPerLvl = 10;
            Wood.ResourceAmount -= NeddedResourceAmount(resources);
            Mine.ResourceAmount -= NeddedResourceAmount(resources);
            Gold.ResourceAmount -= NeddedResourceAmount(resources);
            // Jeśli zasób jest ludźmi to jego rozbudowa nie wymaga zużycia zasobów ludzkich
            if (resources.GetType() != new People().GetType())
            {
                Citizens.ResourceAmount -= newWorkersPerLvl;
            }
        }

        #endregion

        #region zarzadzanie rycerzami

        /// <summary>
        /// Zwraca max wartość możliwych do zrekrutowania żołnierzy
        /// </summary>
        /// <returns></returns>
        public uint RecruitableSoldiers()
        {
            uint maxAmount=0;
            const uint resourcesCost = 20;
            // Sprawdza dostępną ilosć możliwych do zrekrutowania jednostek
            maxAmount = Convert.ToUInt32(Gold.ResourceAmount / resourcesCost);
            maxAmount = Math.Min(maxAmount, Convert.ToUInt32(Mine.ResourceAmount / resourcesCost));
            maxAmount = Math.Min(maxAmount, Convert.ToUInt32(Citizens.ResourceAmount));

            return maxAmount;
        }

        /// <summary>
        /// Rekrutuje daną wartość żołnierzy
        /// </summary>
        /// <param name="soldiersToRecruit"></param>
        public void RecruitSoldiers(uint soldiersToRecruit)
        {
            // koszt w zasobach za jednego wojownika
            const int recruitmentPrice = 20;
            if (soldiersToRecruit <= RecruitableSoldiers())
            {
                SoldierUnits.SoldiersAmount += soldiersToRecruit;
                Gold.ResourceAmount -= soldiersToRecruit * recruitmentPrice;
                Mine.ResourceAmount -= soldiersToRecruit * recruitmentPrice;
                Citizens.ResourceAmount -= soldiersToRecruit;
            }
        }
        #endregion
    }
}


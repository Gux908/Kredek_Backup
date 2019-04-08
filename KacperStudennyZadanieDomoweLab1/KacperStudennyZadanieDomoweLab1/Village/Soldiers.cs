using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyZadanieDomoweLab1.Village
{
    /// <summary>
    /// Klasa przechowuje informacje o siłach zbrojnych
    /// </summary>
    public class Soldiers
    {
        // ilość posiadanych żołnierzy
        public uint SoldiersAmount { get; set; }
        // siła pojedyńczego żołnierza
        public uint FightingSkill { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="soldiers"></param>
        /// <param name="strenght"></param>
        public Soldiers(uint soldiers = 10, uint strenght = 5)
        {
            SoldiersAmount = soldiers;
            FightingSkill = strenght;
        }

        /// <summary>
        /// Sprawdza czy jest wystarczająca ilość gold dla soldiers
        /// </summary>
        /// <param name="gold"></param>
        /// <returns></returns>
        public bool PaySoldiers(Resources gold)
        {
            // koszt zatrudnienia nowego wojownika
            uint hireCost = 5;
            if (gold.ResourceAmount > hireCost * SoldiersAmount)
            {
                gold.ResourceAmount -= hireCost * SoldiersAmount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

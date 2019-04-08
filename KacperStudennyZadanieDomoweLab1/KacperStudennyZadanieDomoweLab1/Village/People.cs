using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyZadanieDomoweLab1.Village
{
    /// <summary>
    /// Klasa zarządza zasobem ludzkim
    /// </summary>
    public class People : Village.Resources
    {
        /// <summary>
        /// Konstruktor wywołuje konstruktor rodzica
        /// </summary>
        /// <param name="buildingCost"></param>
        public People(int buildingCost = 50) : base(buildingCost)
        {  }

        /// <summary>
        /// Zwiększa wartość BuildingLevel i ResourceAmount
        /// </summary>
        public override void AddBuildingLevel()
        {
            uint newPeoplePerLevel = 50;
            ++BuildingLevel;
            ResourceAmount += newPeoplePerLevel;
        }
    }
}

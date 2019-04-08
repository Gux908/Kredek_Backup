using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyZadanieDomoweLab1.Village
{
    /// <summary>
    /// Klasa przechowuje i zarządza jednym zasobem
    /// </summary>
    public class Resources
    {
        // Obecny poziom budynku
        public UInt16 BuildingLevel { get; set; }
        // Obecna ilość surowców
        public UInt64 ResourceAmount { get; set; }
        // Ilość produkowanych zasobób na poziom budynku
        public int ProducedResourcesPerLevel { get; set; }

        public Resources(int producedResourcesPerLevel = 50)
        {
            // startowy poziom budynku
            BuildingLevel = 1;
            // startowa ilość zasobów
            ResourceAmount = 100;
            this.ProducedResourcesPerLevel = producedResourcesPerLevel;
        }


        /// <summary>
        /// Zwiększa przetrzymywany zasób o zadaną ilość 
        /// </summary>
        /// <param name="addedResource"></param>
        public void AddResources(UInt64 addedResource)
        {
            ResourceAmount += addedResource;
        }


        /// <summary>
        /// Zwiększa poziom budynku o jeden
        /// </summary>
        /// <returns></returns>
        public virtual void AddBuildingLevel()
        {
            ++BuildingLevel;
        }


        /// <summary>
        /// Dokłada ilość przetrzymywanych zasobów 
        /// </summary>
        public virtual UInt64 ProduceResources()
        {
            // Dodaje do spichlerza odpowiednią ilość surowcu
            return Convert.ToUInt64(ProducedResourcesPerLevel * BuildingLevel);
        }

    }

}

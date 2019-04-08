using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyZadanieDomoweLab1.Village
{
    /// <summary>
    /// Klasa zarządzająca pieniędzmi
    /// </summary>
    public class Gold : Village.Resources
    {
        public Gold(int producedResourcesPerLevel = 60) : base(producedResourcesPerLevel)
        { }

        /// <summary>
        /// Zwraca wyprodukowaną ilość zasobów
        /// </summary>
        /// <returns></returns>
        public override UInt64 ProduceResources() 
        {
            // Dodaje do spichlerza odpowiednią ilość surowcu
            return Convert.ToUInt64(ProducedResourcesPerLevel/ 2 * BuildingLevel);
        }
    }
}

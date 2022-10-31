using System.Collections.Generic;
using Nusfjord.Cost;

namespace Nusfjord.BuildableObject.Boat
{
    /// <summary>
    /// Стандартная лодка на планшете улова
    /// </summary>
    public class SmallBoat : IBoat
    {
        public string Name { get; } = "Маленькая лодка";
        public int VictoryPoints { get; } = 0;
        public List<IResourceCost> ResourceCoastList { get; set; } = EmptyResourceCost.CreateEmptyResourceCostsList();
        public int Length { get; } = 1;
    }
}
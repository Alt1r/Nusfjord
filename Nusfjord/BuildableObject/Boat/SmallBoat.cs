using System.Collections.Generic;
using Nusfjord.Coast;

namespace Nusfjord.BuildableObject.Boat
{
    /// <summary>
    /// Стандартная лодка на планшете улова
    /// </summary>
    public class SmallBoat : IBoat
    {
        public string Name { get; } = "Маленькая лодка";
        public int VictoryPoints { get; } = 0;
        public List<IResourceCost> ResourceCoastList { get; set; } = EmptyResourceCoast.CreateEmptyResourceCostsList();
        public int Length { get; } = 1;
    }
}
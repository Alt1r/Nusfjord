using System.Collections.Generic;
using Nusfjord.Coast;

namespace Nusfjord.BuildableObject.Construction
{
    /// <summary>
    /// Лес - конструкция для ячеек планшета строительства
    /// </summary>
    public class ForestConstruction : IConstruction
    {
        private const int ForestVictotyPoints = 0;
        private const string ForestName = "Лес";

        #region IBuildable

        public string Name { get; } = ForestName;
        public int VictoryPoints { get; } = ForestVictotyPoints;
        public List<IResourceCost> ResourceCoastList { get; set; } = EmptyResourceCoast.CreateEmptyResourceCostsList();
        
        #endregion

        #region IConstruction

        public ConstructionType ConstructionType { get; set; } = ConstructionType.Forest;
        
        #endregion

        private int ForestCount { get; set; }

        public ForestConstruction(int forestCount)
        {
            ForestCount = forestCount;
        }
    }
}
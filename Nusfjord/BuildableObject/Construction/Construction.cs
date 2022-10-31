using System.Collections.Generic;
using Nusfjord.Cost;

namespace Nusfjord.BuildableObject.Construction
{
    /// <summary>
    /// Конструкция для строительства на планшете строительства
    /// Заполняется в процессе создания игры
    /// </summary>
    public class Construction : IConstruction
    {
        #region IBuildable
        
        public string Name { get; }
        public int VictoryPoints { get; }
        public List<IResourceCost> ResourceCoastList { get; set; }

        #endregion

        #region IConstruction
        
        public ConstructionType ConstructionType { get; set; }

        #endregion
        

        public Construction(string name, int victoryPoints, ConstructionType type, List<IResourceCost> resourceCostList)
        {
            Name = name;
            VictoryPoints = victoryPoints;
            ConstructionType = type;
            ResourceCoastList = resourceCostList;
        }
    }
}
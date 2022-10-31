using System.Collections.Generic;
using Nusfjord.Cost;

namespace Nusfjord.BuildableObject.Construction
{
    /// <summary>
    /// Пуста конструкция на планшете строительства
    /// </summary>
    public class EmptyConstruction : IConstruction
    {
        private const int EmptyVictoryPoint = -1;
        private const string EmptyName = "Пустое поле";

        #region IBuildable 
        
        public string Name { get; } = EmptyName;
        public int VictoryPoints { get; } = EmptyVictoryPoint;
        public List<IResourceCost> ResourceCoastList { get; set; } = EmptyResourceCost.CreateEmptyResourceCostsList();
        
        #endregion

        #region IConstruction
        
        public ConstructionType ConstructionType { get; set; } = ConstructionType.Empty;
        
        #endregion
        
    }
}
using System.Collections.Generic;
using Nusfjord.Coast;

namespace Nusfjord.BuildableObject.Construction
{
    /// <summary>
    /// Запрещенная для строительства конструкция
    /// Помещается в 1 ячейку планшета строительства
    /// </summary>
    public class RestrictedConstruction : IConstruction
    {
        #region IBuildable

        public string Name { get; } = "Нельзя строить";
        public int VictoryPoints { get; } = 0;
        public List<IResourceCost> ResourceCoastList { get; set; } = EmptyResourceCoast.CreateEmptyResourceCostsList();
        
        #endregion

        #region IConstruction

        public ConstructionType ConstructionType { get; set; } = ConstructionType.Restricted;
        
        #endregion
    }
}
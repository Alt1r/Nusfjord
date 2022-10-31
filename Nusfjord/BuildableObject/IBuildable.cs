using System.Collections.Generic;
using Nusfjord.Cost;

namespace Nusfjord.BuildableObject
{
    public interface IBuildable
    {
        public string Name { get; }
        public int VictoryPoints { get; }
        public List<IResourceCost> ResourceCoastList { get; set; }
    }
}
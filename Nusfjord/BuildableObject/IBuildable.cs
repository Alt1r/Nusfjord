using System.Collections.Generic;
using Nusfjord.Coast;

namespace Nusfjord.BuildableObject
{
    public interface IBuildable
    {
        public string Name { get; }
        public int VictoryPoints { get; }
        public List<IResourceCost> ResourceCoastList { get; set; }
    }
}
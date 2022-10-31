using System.Collections.Generic;

namespace Nusfjord.Cost
{
    public class EmptyResourceCost : IResourceCost
    {
        public int WoodCost { get; } = 0;
        public int FishCost { get; } = 0;
        public int GoldCost { get; } = 0;

        public static List<IResourceCost> CreateEmptyResourceCostsList()
        {
            return new List<IResourceCost>{new EmptyResourceCost()};
        }
    }
}
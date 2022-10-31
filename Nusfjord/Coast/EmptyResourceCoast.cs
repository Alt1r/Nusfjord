using System.Collections.Generic;

namespace Nusfjord.Coast
{
    public class EmptyResourceCoast : IResourceCost
    {
        public int WoodCost { get; } = 0;
        public int FishCost { get; } = 0;
        public int GoldCost { get; } = 0;

        public static List<IResourceCost> CreateEmptyResourceCostsList()
        {
            return new List<IResourceCost>{new EmptyResourceCoast()};
        }
    }
}
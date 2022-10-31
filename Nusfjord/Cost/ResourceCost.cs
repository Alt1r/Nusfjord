namespace Nusfjord.Cost
{
    public class ResourceCost : IResourceCost
    {
        public int WoodCost { get; }
        public int FishCost { get; }
        public int GoldCost { get; }

        public ResourceCost(int woodCost = 0, int fishCost = 0, int goldCoast = 0)
        {
            WoodCost = woodCost;
            FishCost = fishCost;
            GoldCost = goldCoast;
        }
    }
}
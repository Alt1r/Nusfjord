namespace Nusfjord.Coast
{
    public class ResourceCoast : IResourceCost
    {
        public int WoodCost { get; }
        public int FishCost { get; }
        public int GoldCost { get; }

        public ResourceCoast(int woodCost = 0, int fishCost = 0, int goldCoast = 0)
        {
            WoodCost = woodCost;
            FishCost = fishCost;
            GoldCost = goldCoast;
        }
    }
}
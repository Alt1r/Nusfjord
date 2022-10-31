namespace Nusfjord.Cost
{
    public interface IResourceCost
    {
        public int WoodCost { get; }
        public int FishCost { get; }
        public int GoldCost { get; }
    }
}
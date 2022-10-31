namespace Nusfjord.Stock
{
    public interface IStock
    {
        public int FishCount { get; set; }
        public int WoodCount { get; set; }
        public int GoldCount { get; set; }

        public void AddWood(int woodCount)
        {
            WoodCount =+ woodCount;
        }
        
        public void AddFish(int fishCount)
        {
            FishCount =+ fishCount;
        }
        public void AddGold(int goldCount)
        {
            GoldCount =+ goldCount;
        }
    }
}
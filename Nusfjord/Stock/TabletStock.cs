namespace Nusfjord.Stock
{
    /// <summary>
    /// Склад
    /// Имеет ограничение на количество рыб = 8
    /// </summary>
    public class TabletStock : IStock
    {
        private const int MaxFishCount = 8;
        private int _fishCount = 0;
        
        public int FishCount
        {
            get => _fishCount;
            set => _fishCount = _fishCount + value < MaxFishCount ? _fishCount + value : MaxFishCount;
        }

        public int WoodCount { get; set; }
        public int GoldCount { get; set; }
    }
}
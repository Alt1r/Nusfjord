namespace Nusfjord.Stock
{
    /// <summary>
    /// Личный склад
    /// Имеет ограничение на количество дерева = 12
    /// </summary>
    public class PersonalStock : IStock
    {
        private const int MaxWoodCount = 12;
        private int _woodCount = 0;
        
        public int WoodCount
        {
            get => _woodCount;
            set => _woodCount = _woodCount + value < _woodCount ? _woodCount + value : MaxWoodCount;
        }

        public int FishCount { get; set; } = 0;
        public int GoldCount { get; set; } = 0;
    }
}
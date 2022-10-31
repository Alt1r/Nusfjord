using System.Collections.Generic;
using Nusfjord.BuildableObject.Construction;

namespace Nusfjord.Tablet.ConstructionTablet
{
    /// <summary>
    /// Поле строительства
    /// 0 1 2 3
    /// 4 5 6 7
    /// 8 9 10 11
    /// </summary>
    public class ConstructionTable
    {
        private const int RestrictedPosition = 0;
        private const int CellCount = 12;
        
        private const int SoloForestCount = 1;
        private const int DoubleForestCount = 2;
        private readonly List<int> DoubleForestPosition = new List<int>{2,3};
        
        private int[] _defaultEmptyCellsPosition = {1, 4, 5, 8, 9};
        private int[] _defaultForestCellPosition = {2, 3, 6, 7, 10, 11};
        
        private ConstructionCell[] _constructionCells;

        public ConstructionTable()
        {
            _constructionCells = new ConstructionCell[CellCount];
            var restrictedConstruction = new RestrictedConstruction();
            //Заполняем стандартные ячейки на планшете строительства
            //1-ое - запрещено для строительства
            _constructionCells[RestrictedPosition] = new ConstructionCell(RestrictedPosition, restrictedConstruction);
            // 2, 5, 6, 9, 10 - пустые клетки строительства
            foreach (var position in _defaultEmptyCellsPosition)
            {
                var emptyConstruction = new EmptyConstruction();
                _constructionCells[position] = new ConstructionCell(position, emptyConstruction);
            }
            // 2, 3, 6, 7, 10, 11 - клетки леса на планшете строительства
            // 2,3 - имеет две клетки леса
            foreach (var position in _defaultForestCellPosition)
            {
                var forestCount = DoubleForestPosition.Contains(position) ? DoubleForestCount : SoloForestCount;
                var forestConstruction = new ForestConstruction(forestCount);
                _constructionCells[position] = new ConstructionCell(position, forestConstruction);
            }
        }

        public void Build(int position, IConstruction construction)
        {
            
        }
    }
}
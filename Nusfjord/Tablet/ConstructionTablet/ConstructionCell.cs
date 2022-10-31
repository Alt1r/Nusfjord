using Nusfjord.BuildableObject.Construction;

namespace Nusfjord.Tablet.ConstructionTablet
{
    public class ConstructionCell
    {
        public int Position;
        public IConstruction Construction;

        public ConstructionCell(int position, IConstruction construction)
        {
            Position = position;
            Construction = construction;
        }
    }
}
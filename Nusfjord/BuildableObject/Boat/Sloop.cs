using System.Collections.Generic;
using Nusfjord.Coast;

namespace Nusfjord.BuildableObject.Boat
{
    /// <summary>
    /// Шлюп
    /// </summary>
    public class Sloop : IBoat
    {
        private const int SloopWoodCoast = 2;
        private const int SloopFishCoast = 2;
        private const string SloopName = "Шлюп";
        private const int SloopVictoryPoints = 1;
        private const int SloopBoatLength = 2;
        
        public string Name { get; } = SloopName;
        public int VictoryPoints { get; } = SloopVictoryPoints;

        public List<IResourceCost> ResourceCoastList { get; set; } =
            new List<IResourceCost> {new ResourceCoast(woodCost: SloopWoodCoast, fishCost: SloopFishCoast)};

        public int Length { get; } = SloopBoatLength;
    }
}
using System.Collections.Generic;
using Nusfjord.Cost;

namespace Nusfjord.BuildableObject.Boat
{
    /// <summary>
    /// Катер
    /// </summary>
    public class Launch : IBoat
    {
        private const int launchWoodCost = 6;
        private const int launchGoldCost = 1;
        private const string launchName = "Катер";
        private const int launchVictoryPoints = 2;
        private const int LauncthBoatLength = 3;

        public string Name { get; } = launchName;
        public int VictoryPoints { get; } = launchVictoryPoints;
        public List<IResourceCost> ResourceCoastList { get; set; } = new List<IResourceCost>{new ResourceCost(woodCost: launchWoodCost, goldCoast: launchGoldCost)};
        public int Length { get; } = LauncthBoatLength;
    }
}
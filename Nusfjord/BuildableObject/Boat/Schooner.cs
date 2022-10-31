using System.Collections.Generic;
using Nusfjord.Coast;

namespace Nusfjord.BuildableObject.Boat
{
    /// <summary>
    /// Шхуна
    /// </summary>
    public class Schooner : IBoat
    {
        private const int SchoonerWoodCoast1 = 8;
        private const int SchoonerFishCoast1 = 8;
        private const int SchoonerGoldCoast2 = 4;
        private const string SchoonerName = "Шхуна";
        private const int SchoonerVictoryPoints = 4;
        private const int SchoonerBoatLength = 4;

        public string Name { get; } = SchoonerName;
        public int VictoryPoints { get; } = SchoonerVictoryPoints;
        public List<IResourceCost> ResourceCoastList { get; set; } = new List<IResourceCost>
        {
            new ResourceCoast(woodCost: SchoonerWoodCoast1, fishCost: SchoonerFishCoast1), 
            new ResourceCoast(goldCoast: SchoonerGoldCoast2)
        };

        public int Length { get; } = SchoonerBoatLength;
    }
}
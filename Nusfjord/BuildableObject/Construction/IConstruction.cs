namespace Nusfjord.BuildableObject.Construction
{
    public interface IConstruction : IBuildable
    {
        public ConstructionType ConstructionType { get; set; }
    }
}
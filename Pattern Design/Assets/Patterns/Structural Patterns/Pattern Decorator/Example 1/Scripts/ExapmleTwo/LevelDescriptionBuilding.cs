public class LevelDescriptionBuilding : BuildingDecorator
{
    private readonly int _level;

    public LevelDescriptionBuilding(IDescription wrapped, int level) : base(wrapped)
    {
        _level = level;
    }

    protected override string Get()
    {
        return _wrapped.GetDescription() + " Level building" + " - " + _level.ToString() + " Level";
    }
}
public class DefaultDescriptionBuilding : BuildingDecorator
{
    public DefaultDescriptionBuilding(IDescription wrapped) : base(wrapped) { }

    protected override string Get()
    {
        return _wrapped.GetDescription() + " Default building";
    }
}
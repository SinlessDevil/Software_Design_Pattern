public abstract class BuildingDecorator : IDescription
{
    protected readonly IDescription _wrapped;

    public BuildingDecorator(IDescription wrapped)
    {
        _wrapped = wrapped;
    }

    public string GetDescription()
    {
        return "Foundation" + " - " + Get();
    }

    protected abstract string Get();
}
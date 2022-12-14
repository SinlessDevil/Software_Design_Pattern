namespace CompositeAndVisitor
{
    public interface ISelectableEntityVisitor
    {
        void Visit(Unit unit);
        void Visit(Squad squad);
    }
}
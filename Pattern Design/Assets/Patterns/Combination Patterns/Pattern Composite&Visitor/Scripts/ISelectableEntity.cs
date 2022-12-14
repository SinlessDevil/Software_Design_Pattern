namespace CompositeAndVisitor
{
    public interface ISelectableEntity
    {
        void Accept(ISelectableEntityVisitor visitor);
        void MoveTo(int x, int y);
    }
}
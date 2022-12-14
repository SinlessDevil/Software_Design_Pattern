namespace CompositeAndVisitor
{
    public class Unit : ISelectableEntity
    {
        public Unit(int health)
        {
            Health = health;
        }
        public int Health { get; private set; }

        public void Accept(ISelectableEntityVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void MoveTo(int x, int y)
        {
            UnityEngine.Debug.Log($"Unit move to {x}:{y}");
        }
    }
}
namespace CompositeAndVisitor
{
    public class UnitHealth : ISelectableEntityVisitor
    {
        public int Result { get; private set; }
        public void Visit(Unit unit)
        {
            Result += unit.Health;
        }

        public void Visit(Squad squad)
        {
            //throw new System.NotImplementedException();
        }
    }
}
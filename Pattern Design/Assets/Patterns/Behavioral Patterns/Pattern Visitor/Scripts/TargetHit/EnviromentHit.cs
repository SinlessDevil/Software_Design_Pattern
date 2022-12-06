namespace Visitor
{
    public class EnviromentHit : Hit
    {
        public override void Accept(IHitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

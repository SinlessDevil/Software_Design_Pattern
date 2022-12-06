namespace Visitor
{
    public class EnemyHit : Hit
    {
        public override void Accept(IHitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
namespace Visitor
{
    public class FriendHit : Hit
    {
        public override void Accept(IHitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
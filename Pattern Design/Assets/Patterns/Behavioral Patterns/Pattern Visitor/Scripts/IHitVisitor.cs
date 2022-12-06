namespace Visitor
{
    public interface IHitVisitor
    {
        void Visit(EnemyHit hit);
        void Visit(EnviromentHit hit);
        void Visit(FriendHit hit);
    }
}
namespace Visitor
{
    public class HitSomething : IHitVisitor
    {
        public void Visit(EnemyHit hit)
        {
            UnityEngine.Debug.Log("Enemy Hit");
        }

        public void Visit(EnviromentHit hit)
        {
            UnityEngine.Debug.Log("Enviroment Hit");
        }

        public void Visit(FriendHit hit)
        {
            UnityEngine.Debug.Log("Friend Hit");
        }
    }
}
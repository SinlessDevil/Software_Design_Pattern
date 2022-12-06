using UnityEngine;
namespace Visitor
{
    public abstract class Hit : MonoBehaviour
    {
        public abstract void Accept(IHitVisitor visitor);
    }
}
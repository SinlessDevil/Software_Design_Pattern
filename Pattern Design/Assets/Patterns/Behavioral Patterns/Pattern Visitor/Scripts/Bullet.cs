using UnityEngine;
using Visitor;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Hit componnet))
        {
            componnet.Accept(new HitSomething());
        }
    }
}
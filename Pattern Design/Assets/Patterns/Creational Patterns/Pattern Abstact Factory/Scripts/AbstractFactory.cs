using UnityEngine;

namespace AbstFactory
{
    public abstract class AbstractFactory : MonoBehaviour
    {
        public abstract GameObject CreateUnitStandard();
    }
}
using UnityEngine;

namespace Prototype
{
    public abstract class ColorPrototype : MonoBehaviour
    {
        protected Color color;
        public abstract ColorPrototype Clone();
    }
}
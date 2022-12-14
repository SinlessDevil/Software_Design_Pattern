using UnityEngine;

namespace Composite
{
    public class Potion : MonoBehaviour, IUsedPotion
    {
        protected string _namePotion = "Base Potion";
        public virtual string Name { get => _namePotion; set => _namePotion = value; }

        public virtual void Use()
        {
            Debug.Log($"You used {Name}");
        }
    }
}
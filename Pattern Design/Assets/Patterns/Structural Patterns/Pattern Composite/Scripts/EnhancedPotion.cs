using System.Collections.Generic;

namespace Composite
{
    public class EnhancedPotion : Potion
    {
        [UnityEngine.SerializeField] protected List<Potion> _potions;

        public override void Use()
        {
            base.Use();
            UseOtherPotion();
        }
        protected void UseOtherPotion()
        {
            foreach (var item in _potions)
            {
                item.Use();
            }
        }
    }
}
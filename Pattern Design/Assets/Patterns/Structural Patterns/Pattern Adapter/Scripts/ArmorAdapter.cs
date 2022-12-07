using UnityEngine;
namespace Adapter
{
    public class ArmorAdapter : MonoBehaviour, IDamage
    {
        private Armor _armor = new();
        public void ApplyDamage(float damage)
        {
            _armor.DestroyArmor(damage);
        }
    }
}
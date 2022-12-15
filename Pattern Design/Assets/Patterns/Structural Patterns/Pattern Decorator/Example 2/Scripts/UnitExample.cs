using UnityEngine;

namespace Decorator.Example2
{
    public class UnitExample : MonoBehaviour, ICanBeDamaged
    {
        [SerializeField] private DecoratorExampleController _ui;
        public void TakeDamage(DamageType type, int damage)
        {
            _ui.CreateWidgetDamageValue(type, damage);

            Debug.Log($"Damage received. Type: {type}, damage: {damage}");
        }
    }
}

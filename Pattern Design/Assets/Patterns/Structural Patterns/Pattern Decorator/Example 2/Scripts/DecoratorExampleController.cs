using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Decorator.Example2
{
    public class DecoratorExampleController : MonoBehaviour
    {
        [SerializeField] private UnitExample _unit;
        [SerializeField] private Button _buttonDamage;
        [SerializeField] private WidgetDamageValue _widgetDamageValuePrefab;
        [SerializeField] private Transform _damageValuesContainer;

        private Dictionary<DamageType, Color> _damageColorMap = new Dictionary<DamageType, Color>()
        {
            {DamageType.Physical, Color.white},
            {DamageType.Electrical, Color.yellow},
            {DamageType.Water, Color.blue}
        };

        private void OnEnable()
        {
            _buttonDamage.onClick.AddListener(OnButtonDamageClick);
        }
        private void OnDisable()
        {
            _buttonDamage.onClick.RemoveListener(OnButtonDamageClick);
        }

        public void CreateWidgetDamageValue(DamageType damageType, int damage)
        {
            var color = _damageColorMap[damageType];
            var widget = Instantiate(_widgetDamageValuePrefab, _damageValuesContainer);
            var maxDistance = 0.5f;
            var randomOffset = Random.insideUnitCircle * maxDistance;
            var position = _damageValuesContainer.position + new Vector3(randomOffset.x, randomOffset.y, 0f);
            widget.transform.position = position;

            widget.SetValue(damage.ToString());
            widget.SetColor(color);
        }

        private void OnButtonDamageClick()
        {
            Debug.Log("Damage");

            IAbility ability = new Ability(10, DamageType.Physical);
            // ability = new AbilityAdditionalDamage(ability,20,DamageType.Electrical);
            ability = new AbilityDurationDamage(ability, 2, 10);

            ability = new AbilityAdditionalDamage(ability, 20, DamageType.Electrical);

            ability = new AbilityAdditionalDamage(ability, 10, DamageType.Water);
            ability.ApplyDaamage(_unit);
        }
    }
}
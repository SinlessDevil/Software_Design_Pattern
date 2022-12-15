using System.Collections;
using UnityEngine;

namespace Decorator.Example2
{
    public class AbilityDurationDamage : AbilityUpgrade
    {
        private float _duration;
        private int _partsAmount;
        public AbilityDurationDamage(IAbility ability, float duration, int partsAmount) : base(ability)
        {
            _duration = duration;
            _partsAmount = partsAmount;
        }

        public override void ApplyDaamage(ICanBeDamaged canBeDamaged)
        {
            Coroutines.StartRoutine(ApplyDamageRoutine(canBeDamaged));
        }

        private IEnumerator ApplyDamageRoutine(ICanBeDamaged canBeDamaged)
        {
            int damage = Mathf.CeilToInt(MainAbility.GetDamage() / (float) _partsAmount);
            float partDuration = _duration / damage;

            canBeDamaged.TakeDamage(MainAbility.GetDamageType(), damage);

            for (int i = 0; i < _partsAmount; i++)
            {
                yield return new WaitForSeconds(partDuration);
                canBeDamaged.TakeDamage(MainAbility.GetDamageType(), damage);
            }
        }
    }
}
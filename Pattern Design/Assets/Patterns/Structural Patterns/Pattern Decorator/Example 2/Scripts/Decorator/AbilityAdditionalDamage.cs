namespace Decorator.Example2
{
    public class AbilityAdditionalDamage : AbilityUpgrade
    {
        private int _additionalDamage;
        private DamageType _additionalDamageType;

        public AbilityAdditionalDamage(IAbility ability, int additionalDamage, DamageType damageType) : base(ability)
        {
            _additionalDamage = additionalDamage;
            _additionalDamageType = damageType;
        }

        public override void ApplyDaamage(ICanBeDamaged canBeDamaged)
        {
            base.ApplyDaamage(canBeDamaged);
            canBeDamaged.TakeDamage(_additionalDamageType, _additionalDamage);
        }
    }
}
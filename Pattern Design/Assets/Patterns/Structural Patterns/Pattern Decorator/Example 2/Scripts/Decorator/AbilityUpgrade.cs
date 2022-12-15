namespace Decorator.Example2
{
    public abstract class AbilityUpgrade : IAbility
    {
        protected IAbility MainAbility;

        public AbilityUpgrade(IAbility ability)
        {
            MainAbility = ability;
        }

        public virtual void ApplyDaamage(ICanBeDamaged canBeDamaged)
        {
           MainAbility.ApplyDaamage(canBeDamaged);
        }

        public virtual int GetDamage()
        {
            return MainAbility.GetDamage();
        }

        public DamageType GetDamageType()
        {
            return MainAbility.GetDamageType();
        }
    }
}
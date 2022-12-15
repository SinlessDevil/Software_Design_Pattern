namespace Decorator.Example2
{
    public class Ability : IAbility
    {
        private int _damage;
        private DamageType _damageType;

        public Ability(int damage, DamageType damageType)
        {
            _damage = damage;
            _damageType = damageType;
        }

        public void ApplyDaamage(ICanBeDamaged canBeDamaged)
        {
            canBeDamaged.TakeDamage(_damageType, _damage);
        }
        public int GetDamage()
        {
            return _damage;
        }
        public DamageType GetDamageType()
        {
            return _damageType;
        }
    }
}
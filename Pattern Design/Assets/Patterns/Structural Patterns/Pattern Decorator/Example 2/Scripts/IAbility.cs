namespace Decorator.Example2
{
    public interface IAbility
    {
        int GetDamage();
        DamageType GetDamageType();
        void ApplyDaamage(ICanBeDamaged canBeDamaged);
    }
}
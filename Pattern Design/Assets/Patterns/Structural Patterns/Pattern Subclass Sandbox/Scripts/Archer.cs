namespace SubclassSandbox
{
    public class Archer : HeroClass
    {
        public override void Activate()
        {
            SetName("Archer");
            ArmedWeapon("Bow");
            MoveTo(10, 10);
            BattleCry();
        }
    }
}
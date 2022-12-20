namespace SubclassSandbox
{
    public class LanceMan : HeroClass
    {
        public override void Activate()
        {
            SetName("LanceMan");
            ArmedWeapon("Lance");
            MoveTo(10, 10);
            BattleCry();
        }
    }
}
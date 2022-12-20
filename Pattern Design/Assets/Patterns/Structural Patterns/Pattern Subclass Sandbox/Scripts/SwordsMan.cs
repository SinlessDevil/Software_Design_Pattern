namespace SubclassSandbox
{
    public class SwordsMan : HeroClass
    {
        public override void Activate()
        {
            SetName("SwordsMan");
            ArmedWeapon("Swords");
            MoveTo(10, 10);
            BattleCry();
        }
    }
}
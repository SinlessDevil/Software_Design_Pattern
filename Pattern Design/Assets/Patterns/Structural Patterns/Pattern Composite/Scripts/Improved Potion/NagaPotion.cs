namespace Composite
{
    public class NagaPotion : EnhancedPotion
    {
        public override string Name => "Naga Potion";

        private void Start()
        {
            _potions.Add(GetComponent<PotionHealth>());
            _potions.Add(GetComponent<PotionSpeed>());
        }
    }
}
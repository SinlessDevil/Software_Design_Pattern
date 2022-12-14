namespace Composite
{
    public class DragonPotion : EnhancedPotion
    {
        public override string Name => "Dragon Potion";

        private void Start()
        {
            _potions.Add(GetComponent<PotionHealth>());
            _potions.Add(GetComponent<PotionStrength>());
        }
    }
}
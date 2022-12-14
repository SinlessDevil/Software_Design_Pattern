namespace Composite
{
    public class PhoenixPotion : EnhancedPotion
    {
        public override string Name { get => "Phoenix Potion"; set => _namePotion = value; }

        private void Start()
        {
            _potions.Add(GetComponent<PotionHealth>());
            _potions.Add(GetComponent<PotionSpeed>());
            _potions.Add(GetComponent<PotionStrength>());
        }
    }
}
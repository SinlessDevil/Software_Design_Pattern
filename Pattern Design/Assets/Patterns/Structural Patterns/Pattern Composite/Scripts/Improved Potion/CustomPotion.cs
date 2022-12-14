namespace Composite
{
    public class CustomPotion : EnhancedPotion
    {
        [UnityEngine.SerializeField] private TMPro.TMP_InputField _inputName;
        private string SetName()
        {
            Name = _inputName.text;
            return Name;
        }


        public override void Use()
        {
            Name = SetName();
            base.Use();
        }

        public void AddEffectPotion(Potion effect)
        {
            _potions.Add(effect);
        }
    }
}
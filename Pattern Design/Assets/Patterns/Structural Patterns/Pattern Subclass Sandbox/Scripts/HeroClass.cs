using UnityEngine;

namespace SubclassSandbox
{
    public abstract class HeroClass
    {
        private string _nameHero = "Hero";
        public abstract void Activate();

        public string SetName(string name)
        {
            _nameHero = name;
            return _nameHero;
        }

        protected void MoveTo(float x, float y)
        {
            Debug.Log($"{_nameHero} Moving to Start Pos {x} : {y}");
        }

        protected void ArmedWeapon(string gun)
        {
            Debug.Log($"{_nameHero} Armed with a {gun}");
        }

        protected void BattleCry()
        {
            Debug.Log($"{_nameHero} Leat out BATTLE CRY!");
        }
    }
}
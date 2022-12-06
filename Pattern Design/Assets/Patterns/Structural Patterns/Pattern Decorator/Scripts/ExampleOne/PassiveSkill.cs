using System.Collections.Generic;

namespace Decorator
{
    public class PassiveSkill : IStats
    {
        private IStats _stats;

        public PassiveSkill(IStats stats)
        {
            _stats = stats;
        }

        public IEnumerable<Stat> GetStats()
        {
            foreach (var item in _stats.GetStats())
            {              
                yield return new Stat(item.value * 2, item.name);
                UnityEngine.Debug.Log("Value: " + item.value + "Name: " + item.name);
            }
        }
    }
}
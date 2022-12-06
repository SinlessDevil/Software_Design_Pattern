using System.Collections.Generic;

namespace Decorator
{
    public class Stats : IStats
    {
        private List<Stat> _stats;
        public IEnumerable<Stat> GetStats()
        {
            return _stats;
        }
    }
}
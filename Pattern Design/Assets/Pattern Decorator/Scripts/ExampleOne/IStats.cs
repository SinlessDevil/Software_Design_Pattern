using System.Collections.Generic;
namespace Decorator
{
    public interface IStats
    {
        IEnumerable<Stat> GetStats();
    }
}
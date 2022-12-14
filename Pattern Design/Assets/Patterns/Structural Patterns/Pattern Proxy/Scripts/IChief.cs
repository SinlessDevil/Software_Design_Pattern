using System.Collections.Generic;

namespace Proxy
{
    public interface IChief
    {
        IDictionary<int, string> GetStatuses();

        IEnumerable<Order> GetOrders();
    }
}
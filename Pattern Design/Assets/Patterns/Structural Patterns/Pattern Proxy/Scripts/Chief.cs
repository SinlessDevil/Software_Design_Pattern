using System.Collections.Generic;
namespace Proxy
{
    public class Chief : IChief
    {
        public IDictionary<int, string> GetStatuses()
        {
            Dictionary<int, string> statuses = new();

            statuses.Add(1, "ready");
            statuses.Add(2, "not ready");
            statuses.Add(3, "preparing");

            System.Threading.Thread.Sleep(2000);

            return statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            List<Order> orders = new();

            orders.Add(new Order()
            {
                Name = "Burger",
                StatusId = RandomizeStatus()
            });

            orders.Add(new Order()
            {
                Name = "Pizza",
                StatusId = RandomizeStatus()
            });

            orders.Add(new Order()
            {
                Name = "Fries",
                StatusId = RandomizeStatus()
            });

            return orders;
        }

        private static int RandomizeStatus() => new System.Random().Next(1, 4);
    }
}
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Proxy
{
    public class StartUp : MonoBehaviour
    {
        private void Start()
        {
            IChief chief = new ChiefProxy(new Chief());

            while (true)
            {
                System.Threading.Thread.Sleep(2000);

                Debug.Log("Welcom to Cooker!\n");
                Debug.Log("========== Orders ==========\n");

                IEnumerable<Order> orders = chief.GetOrders();

                foreach (Order order in orders)
                {
                    string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;
                    Debug.Log($"{order.StatusId}\t\t{status}");
                }
            }
        }
    }
}
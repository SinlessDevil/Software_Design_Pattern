using UnityEngine;

namespace TemplateMethod
{
    public class StartUp : MonoBehaviour
    {
        [SerializeField] private PurchaseOrder _order;
        private void Start()
        {
            _order.Execute();
        }
    }
}
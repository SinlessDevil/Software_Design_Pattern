using UnityEngine;

namespace TemplateMethod
{
    public abstract class PurchaseOrder : MonoBehaviour
    {
        public void Execute()
        {
            Accept();
            Prepare();
            Deliver();
        }

        protected virtual void Accept()
        {
            print("The order is accepted!");
        }

        protected virtual void Prepare()
        {
            print("The order is being prepared!");
        }

        protected abstract void Deliver();
    }
}
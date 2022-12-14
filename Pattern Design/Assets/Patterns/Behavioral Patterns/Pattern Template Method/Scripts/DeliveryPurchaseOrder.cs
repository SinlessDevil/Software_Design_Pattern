namespace TemplateMethod
{
    public class DeliveryPurchaseOrder : PurchaseOrder
    {
        protected override void Prepare()
        {
            base.Prepare();
            print("Prepare a courier");
        }

        protected override void Deliver()
        {
            print("The courier delivered the order!");
        }
    }
}
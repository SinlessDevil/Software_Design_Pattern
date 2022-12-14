namespace TemplateMethod
{
    public class OnSportPurchaseOrder : PurchaseOrder
    {
        protected override void Deliver()
        {
            print("The customer took the order!");
        }
    }
}
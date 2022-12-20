namespace PattenMediator
{
    public class DeliveryProductPackage : Package
    {
        public void Send(string productPackage)
        {
            var package = productPackage + " Delivery";

            print("Delivery: " + package);
        }
    }
}
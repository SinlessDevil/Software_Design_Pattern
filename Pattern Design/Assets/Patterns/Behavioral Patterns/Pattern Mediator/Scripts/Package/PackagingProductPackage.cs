namespace PattenMediator
{
    public class PackagingProductPackage : Package
    {
        public string ProductPackage { get; private set; }

        public void Execute(string productPackage)
        {
            ProductPackage = productPackage + " Packaging";
            Mediator.Do(this);

            print("Packaging" + ProductPackage);
        }
    }
}
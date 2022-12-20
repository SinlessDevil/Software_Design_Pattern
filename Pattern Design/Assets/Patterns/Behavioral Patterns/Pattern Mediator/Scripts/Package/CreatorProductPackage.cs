namespace PattenMediator
{
    public class CreatorProductPackage : Package
    {
        public string ProductPackage { get; private set; }

        public void Create()
        {
            ProductPackage = "ProductPackage_1";
            Mediator.Do(this);

            print("Create: " + ProductPackage);
        }
    }
}
using UnityEngine;

namespace PattenMediator
{
    public class PackageMediator : MonoBehaviour, IPackageMediator
    {
        [SerializeField] private CreatorProductPackage _create;
        [SerializeField] private PackagingProductPackage _packaging;
        [SerializeField] private DeliveryProductPackage _delivery;

        public void Do(Package package)
        {
            if(package == _create)
            {
                _packaging.Execute(_create.ProductPackage);
                return;
            }

            if(package == _packaging)
            {
                _delivery.Send(_packaging.ProductPackage);
                return;
            }
        }
    }
}
using UnityEngine;

namespace PattenMediator
{
    public class Package : MonoBehaviour
    {
        [SerializeField] protected GameObject _mediatorObject;
        protected IPackageMediator Mediator => _mediatorObject.GetComponent<IPackageMediator>();
    }
}
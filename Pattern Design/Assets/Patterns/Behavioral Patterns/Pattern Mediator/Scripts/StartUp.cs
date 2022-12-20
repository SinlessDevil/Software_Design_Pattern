using UnityEngine;

namespace PattenMediator
{
    public class StartUp : MonoBehaviour
    {
        [SerializeField] private CreatorProductPackage _creator;

        private void Start()
        {
            _creator.Create();
        }
    }
}
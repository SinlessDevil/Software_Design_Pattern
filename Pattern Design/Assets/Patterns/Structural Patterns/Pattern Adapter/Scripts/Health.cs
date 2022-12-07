using UnityEngine;

namespace Adapter
{
    public class Health : MonoBehaviour, IDamage
    {
        public void ApplyDamage(float damage)
        {
            Debug.Log("ApplyDamage - " + damage.ToString());
        }
    }
}

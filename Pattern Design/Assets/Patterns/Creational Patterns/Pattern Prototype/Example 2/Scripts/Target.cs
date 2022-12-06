using UnityEngine;

namespace PrototypeV2
{
    public class Target : MonoBehaviour
    {
        [SerializeField] private int _currentHealth = 10;

        public void TakeDamage(int damage)
        {
            if (damage >= _currentHealth) OnDead();
            _currentHealth -= damage;

            Debug.Log("Take Damage : " + damage + " Current Health = " + _currentHealth);
        }

        public void Freeze(int seconds){
            Debug.Log("Frozen for " + seconds);
        }
        public void Stun(int seconds){
            Debug.Log("Frozen for " + seconds);
        }

        public void OnDead()
        {
            Destroy(this.gameObject);
        }
    }
}
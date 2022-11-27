using UnityEngine;
using System;

namespace Bank{
    public class Coin : MonoBehaviour{
        public static event Action<int> addCoinsEvent;

        [SerializeField] private int coinsAmount = 50;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Player>())
            {
                addCoinsEvent?.Invoke(coinsAmount);
                Destroy(this.gameObject);
            }
        }
    }
}
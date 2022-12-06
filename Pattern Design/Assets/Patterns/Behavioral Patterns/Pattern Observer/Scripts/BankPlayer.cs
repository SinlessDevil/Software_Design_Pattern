using UnityEngine;

namespace Bank{
    public class BankPlayer: MonoBehaviour{
        private int coins { get; set; }

        private void OnEnable(){
            Coin.addCoinsEvent += AddCoins;
        }

        private void OnDisable(){
            Coin.addCoinsEvent -= AddCoins;
        }

        private void AddCoins(int amount){
            this.coins += amount;
            Debug.Log(this.coins);
        }
        private void SpendCoins(int amount){
            if (amount > coins){
                Debug.LogError("the player's bank does not have enough coins");
                return;
            }
            this.coins -= amount;
        }

        public bool IsEnoughCoins(int amount){
            return amount <= this.coins;
        }
    }
}
using System.Collections.Generic;
using UnityEngine;

namespace ChainOfResponsibility
{
    public class ChainManager : MonoBehaviour
    {
        public List<GameHandler> gameHablers;

        private void Start()
        {
            gameHablers[0].Handler(null);
            for (int i = 1; i < gameHablers.Count; i++)
            {
                gameHablers[i - 1].SetNext(gameHablers[i]);
            }
        }
    }
}
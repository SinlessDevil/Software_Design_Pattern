using UnityEngine;
using Decorator;

public class StratUpTest : MonoBehaviour
{
    private void Start()
    {
        Stat player0 = new Stat(10, "Vasya");
        Stat player1 = new Stat(20, "Petya");
        Stat player2 = new Stat(30, "Sema");
        Stat player3 = new Stat(40, "Blad");
        Stat player4 = new Stat(50, "Eugene");


        PassiveSkill passiveSkill = new(new Stats());

        passiveSkill.GetStats();
    }
}

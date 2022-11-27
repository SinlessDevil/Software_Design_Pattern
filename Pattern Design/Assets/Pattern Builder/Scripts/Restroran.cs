using UnityEngine;
using Burger.Builder;

public class Restroran : MonoBehaviour
{
    private void Start()
    {
        var builder = new BurgerBuilder();

        var cheeseDirector = new CheeseburgerDirector(builder);

        cheeseDirector.Build();

        var report = builder.GetReport();

        Debug.Log(report);
    }
}
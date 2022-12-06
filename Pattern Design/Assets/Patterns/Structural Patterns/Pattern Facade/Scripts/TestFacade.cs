using UnityEngine;
using Facade;

public class TestFacade : MonoBehaviour
{
    private void Start()
    {
        MarketPlace marketPlace = new();

        marketPlace.ProductReceipt();

        Debug.Log(new string('-', 20));

        marketPlace.ProductRelease();
    }
}
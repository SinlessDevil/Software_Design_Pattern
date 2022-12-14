using UnityEngine;
using System.Collections.Generic;
using Burger.Builder;
using System;
using System.Linq;

public class Restoran: IRestoran
{
    const string RESTORN_MENU = "===================== Restoran Menu ======================";

    private Citchen _citchen;

    private List<IBurgerDerector> _menuList;

    private bool isElementFound = false;
    public Restoran()
    {
        _citchen = new();
        SetRestoranMenu();
    }

    private void SetRestoranMenu()
    {
        Debug.Log(RESTORN_MENU);

        //Searching for classes that implement the interface
        var iBurgerDerector = typeof(IBurgerDerector);
        var burgerDerectorsTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => iBurgerDerector.IsAssignableFrom(type) && type.IsClass);

        _menuList = new();

        //Add Class in List
        foreach (var burger in burgerDerectorsTypes)
        {
            _menuList.Add(Activator.CreateInstance(burger) as IBurgerDerector);
        }

        //Call the "SetNameBurger" method for each class
        _menuList.ForEach(burger => burger.SetNameBurger());
    }

    public void SetBurger(string nameBurger)
    {
        foreach (var item in _menuList) 
        {
            if (item.nameBuger == nameBurger)
            {
                _citchen.CookingBurger(item);
                isElementFound = true;
            }
        }
        if (!isElementFound) UnityEngine.Debug.Log($"Burger with this name : {nameBurger}, was not found");
        isElementFound = false;
    }
}
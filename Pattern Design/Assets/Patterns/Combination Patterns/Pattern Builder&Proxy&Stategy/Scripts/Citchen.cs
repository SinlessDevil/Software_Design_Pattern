namespace Burger.Builder
{
    public class Citchen
    {
        const string INGREDIENTS = "Ingredients : ";
        public void CookingBurger(IBurgerDerector _derector)
        {
            var burgerBuilder = new BurgerBuilder();

            _derector.SetNameBurger();

            _derector.SetBurgerBuilder(burgerBuilder);

            _derector.Build();

            var report = burgerBuilder.GetReport();

            UnityEngine.Debug.Log(INGREDIENTS);
            UnityEngine.Debug.Log(report);
        }
    }
}
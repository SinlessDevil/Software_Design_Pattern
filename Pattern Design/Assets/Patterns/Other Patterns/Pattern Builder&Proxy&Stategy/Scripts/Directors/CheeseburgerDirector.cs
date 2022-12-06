namespace Burger.Builder
{
    public class CheeseBurgerDirector : IBurgerDerector
    {
        public string nameBuger => "CheeseBurger";
        public void SetNameBurger()
        {
            UnityEngine.Debug.Log(nameBuger);
        }

        private IBurgerBuilder _builder;
        public void SetBurgerBuilder(IBurgerBuilder builder)
        {
            this._builder = builder;
        }
        public void Build()
        {
            _builder.BuildBun();
            _builder.BuildCutlet();
            _builder.BuildCheese();
            _builder.BuildSauce();
        }
    }
}
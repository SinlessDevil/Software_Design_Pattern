namespace Burger.Builder
{
    public class BigMagBurgerDerector : IBurgerDerector
    {
        public string nameBuger => "BigMagBurger";
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
            _builder.BuildTomato();
            _builder.BuildBacon();
            _builder.BuildCucumbers();
        }
    }
}
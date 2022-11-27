using UnityEngine;

namespace Burger.Builder
{
    public class CheeseburgerDirector : MonoBehaviour
    {
        private readonly IBurgerBuilder _builder;

        public CheeseburgerDirector(IBurgerBuilder builder)
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
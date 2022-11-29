namespace Burger.Builder
{
    public class BurgerBuilder: IBurgerBuilder
    {
        private Burger _burger;

        public BurgerBuilder()
        {
            _burger = new();
        }

        public void BuildBacon()
        {
            _burger.Bacon = " Bacon ";
        }
        public void BuildBun()
        {
            _burger.Bun = " Bun ";
        }
        public void BuildCabbage()
        {
            _burger.Cabbage = " Cabbage ";
        }
        public void BuildCucumbers()
        {
            _burger.Cucumbers = " Cucumbers ";
        }
        public void BuildCutlet()
        {
            _burger.Cutlet = " Cutlet ";
        }
        public void BuildSauce()
        {
            _burger.Sauce = " Sauce ";
        }
        public void BuildTomato()
        {
            _burger.Tomato = " Tomato ";
        }
        public void BuildCheese()
        {
            _burger.Cheese = " Cheese ";
        }

        public Burger GetReport()
        {
            Burger burger = this._burger;

            this._burger = new();

            return burger;
        }
    }
}
namespace Burger.Builder{
    public interface IBurgerBuilder{
        void BuildBun();
        void BuildCutlet();
        void BuildTomato();
        void BuildCucumbers();
        void BuildSauce();
        void BuildCabbage();
        void BuildBacon();
        void BuildCheese();

        Burger GetReport();
    }
}
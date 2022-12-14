namespace Burger.Builder{
    public interface IBurgerDerector{

        string nameBuger { get; }
        void SetNameBurger();
        void SetBurgerBuilder(IBurgerBuilder builder);
        void Build();
    }
}
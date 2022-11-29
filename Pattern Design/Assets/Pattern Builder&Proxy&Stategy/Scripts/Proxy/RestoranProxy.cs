public class RestoranProxy: IRestoran
{
    private readonly Restoran _restoran;

    public RestoranProxy(Restoran restoran)
    {
        _restoran = restoran;
    }

    public void SetBurger(string nameBurger)
    {
        if (nameBurger is null || nameBurger.Length == 0)
        {
            UnityEngine.Debug.Log("You did not fill in the text field");
            return;
        }
        _restoran.SetBurger(nameBurger);
    }
}

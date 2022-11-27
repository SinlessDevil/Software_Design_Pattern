using Strategy;
public interface IControllable
{
    public void SetWeapon(IWeapon weapon);
    public void Attacked();

    public void Move();
    public void Jump();
}
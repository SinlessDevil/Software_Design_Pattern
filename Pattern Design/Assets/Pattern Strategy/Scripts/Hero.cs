using UnityEngine;
using Strategy;

public class Hero : MonoBehaviour, IControllable
{
    const string NAME_HERO = "Hero";
    private IWeapon _weapon;

    public void SetWeapon(IWeapon weapon)
    {
        this._weapon = weapon;
    }
    public void Attacked()
    {
        Debug.Log("Switch Weapon");
        if (_weapon == null){
            Debug.Log($"{NAME_HERO} can't attack. Set a weapon");
            return;
        }
        Debug.Log($"{NAME_HERO} stands menacingly");
        _weapon.Attack();
        Debug.Log($"{NAME_HERO} ceases to stand menacing");
    }

    public void Move()
    {
        Debug.Log($"{NAME_HERO}, Move");
    }

    public void Jump()
    {
        Debug.Log($"{NAME_HERO}, Jump");
    }
}
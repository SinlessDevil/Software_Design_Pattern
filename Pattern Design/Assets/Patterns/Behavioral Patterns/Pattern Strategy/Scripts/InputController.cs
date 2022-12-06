using UnityEngine;
using Strategy;

public class InputController : MonoBehaviour
{
    [SerializeField] private GameObject _hero;
    private IControllable _contollavleObject;
    private void Start()
    {
        _contollavleObject = _hero.GetComponent<IControllable>();
        if(_contollavleObject == null)
        {
            throw new System.NullReferenceException("_hero dons not have IControllable interface");
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _contollavleObject.Jump();
        }
        if (Input.GetKey(KeyCode.W))
        {
            _contollavleObject.Move();
        }

        if (Input.GetKey(KeyCode.R))
        {
            _contollavleObject.SetWeapon(new Sword());
           // _contollavleObject.SetWeapon(new Axe());
           // _contollavleObject.SetWeapon(new Lance());
        }

        if (Input.GetMouseButton(0))
        {
            _contollavleObject.Attacked();
        }
    }
}
using UnityEngine;
using PrototypeV2;

[RequireComponent(typeof(Weapon))]
public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;
    [SerializeField] private Target _enemy;
    private void Start()
    {
        _weapon = GetComponent<Weapon>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _weapon.Attack(_enemy);
        }
    }
}
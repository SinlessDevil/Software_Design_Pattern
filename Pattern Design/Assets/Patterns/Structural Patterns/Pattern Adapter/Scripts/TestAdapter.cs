using UnityEngine;
using Adapter;

public class TestAdapter : MonoBehaviour
{
    [SerializeField] private GameObject _alive;
    [SerializeField][Range(1f, 5f)] private float _damage = 2f;
    private void Start()
    {
        var health = _alive.GetComponent<Health>();
        health?.ApplyDamage(_damage);
        var armor = _alive.GetComponent<ArmorAdapter>();
        armor?.ApplyDamage(_damage);
    }
}
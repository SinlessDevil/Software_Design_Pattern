using UnityEngine;
using TMPro;

public class Client : MonoBehaviour
{
    private RestoranProxy _restoran;

    [SerializeField] private TMP_InputField _nameOrder;
    private void Start()
    {
        _restoran = new RestoranProxy(new Restoran());
    }

    public void ButtonClickOrder()
    {
        _restoran.SetBurger(_nameOrder.text);
    }
}
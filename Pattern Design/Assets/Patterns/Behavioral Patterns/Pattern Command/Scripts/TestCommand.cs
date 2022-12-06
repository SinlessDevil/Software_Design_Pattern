using UnityEngine;
using Command;
using TMPro;

public class TestCommand : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputNumber;
    [SerializeField] private TMP_InputField _inputCommand;
    private ViewCalculator _view;

    private void Start()
    {
        _view = new ViewCalculator(_inputCommand, _inputNumber, new User());
    }

    public void ButtonClickEnter() => _view.ClickCalculat();
    public void ButtonClickUndo() => _view.ClickUndo();
    public void ButtonClickRedo() => _view.ClickRedo();
}
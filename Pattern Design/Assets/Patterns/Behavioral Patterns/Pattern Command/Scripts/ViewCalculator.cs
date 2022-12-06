using Command;
using TMPro;

public class ViewCalculator
{
    private TMP_InputField _inputCommand;
    private TMP_InputField _inputNumber;
    private User _user;

    public ViewCalculator( TMP_InputField input, TMP_InputField input2, User user)
    {
        _inputCommand = input;
        _inputNumber = input2;
        _user = user;
    }

    public void ClickCalculat()
    {
        char symbol = System.Convert.ToChar(_inputCommand.text);
        int number = System.Convert.ToInt32(_inputNumber.text);
        _user.Compute(symbol,number);
    }

    public void ClickUndo() => _user.Undo(1);

    public void ClickRedo() => _user.Redo(1);
}
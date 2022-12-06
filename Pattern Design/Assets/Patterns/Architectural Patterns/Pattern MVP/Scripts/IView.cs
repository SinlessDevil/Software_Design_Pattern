using System;

namespace MVP
{
    internal interface IView
    {
        string GetLabelText();
        string GetInputText();
        string SetLabelText(string text);
        string SetInputText(string text);
        void UpdateText(string labelText);

        event Action<string> ReportMassageEvent;
    }
}
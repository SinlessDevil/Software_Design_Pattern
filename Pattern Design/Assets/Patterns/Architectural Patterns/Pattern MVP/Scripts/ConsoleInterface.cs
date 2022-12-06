using System;
using UnityEngine;
using TMPro;

namespace MVP{
    public class ConsoleInterface : MonoBehaviour, IView
    {
        public event Action<string> ReportMassageEvent;

        [Header("UI Text")]
        public TMP_Text labelText;
        public TMP_InputField inputText;

       
        private TextPresenter _presenter;
        private void Start()
        {
            _presenter = new(this);
        }

        public void SetTextButtonClick()
        {
            _presenter.SetTextDisplay(inputText.text);
            ReportMassageEvent.Invoke("Text label Set");
        }
        public void ReversTextButtonClick()
        {
            _presenter.ReverseTextDisplay();
            ReportMassageEvent.Invoke("Text label Revers");
        }
        public void ToUpperTextButtonClick()
        {
            _presenter.ToUpperDisplay();
            ReportMassageEvent.Invoke("Text label ToUpper");
        }
        public void ToLowerTextButtonClick()
        {
            _presenter.ToLowerDisplay();
            ReportMassageEvent.Invoke("Text label ToLower");
        }
        public void ClearTextButtonClick()
        {
            _presenter.ClearTextDisplay();
            ReportMassageEvent.Invoke("Text label Cleared");
        }

        public string GetLabelText()
        {
            return labelText.text;
        }

        public string GetInputText()
        {
            return inputText.text;
        }

        public string SetLabelText(string text)
        {
            labelText.text = text;
            return labelText.text;
        }

        public string SetInputText(string text)
        {
            inputText.text = text;
            return inputText.text;
        }

        public void UpdateText(string labelText)
        {
            this.labelText.text = labelText;
        }
    }
}
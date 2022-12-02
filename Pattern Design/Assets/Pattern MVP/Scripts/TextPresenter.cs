namespace MVP
{
    internal class TextPresenter
    {
        private readonly IView _textView;
        private string _currentText;
        public TextPresenter(IView inputText)
        {
            _textView = inputText;

            _textView.ReportMassageEvent += GetReport;

        }

        public void GetReport(string text)
        {
            UnityEngine.Debug.Log(text);
        }

        public void SetTextDisplay(string text)
        {
            _textView.SetLabelText(text);
        }

        public void ReverseTextDisplay()
        {
            TextDisplay textDisplay = new();
            _currentText = _textView.GetLabelText();
            string reverseText = textDisplay.ReverseText(_currentText);
            _textView.SetLabelText(reverseText);
        }

        public void ToUpperDisplay()
        {
            _currentText = _textView.GetLabelText();
            string newLabelText = _currentText.ToUpper();
            _textView.SetLabelText(newLabelText);
        }

        public void ToLowerDisplay()
        {
            _currentText = _textView.GetLabelText();
            string newLabelText = _currentText.ToLower();
            _textView.SetLabelText(newLabelText);
        }

        public void ClearTextDisplay()
        {
            _textView.SetLabelText("");
            _textView.SetInputText("");
        }
    }
}
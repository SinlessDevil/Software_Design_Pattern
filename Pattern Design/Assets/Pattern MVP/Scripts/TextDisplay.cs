namespace MVP
{
    public class TextDisplay : ITextDisplay
    {
        public string ReverseText(string text)
        {
            char[] charArray = text.ToCharArray();
            System.Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
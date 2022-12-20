namespace PatternMemento
{
    public class Memento
    {
        public string article { get; protected set; }
        public Memento(string article)
        {
            this.article = article;
        }
    }
}
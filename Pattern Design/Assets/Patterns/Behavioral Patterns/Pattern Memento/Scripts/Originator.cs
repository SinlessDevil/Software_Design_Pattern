namespace PatternMemento
{
    public class Originator
    {
        public string article { get; protected set; }

        public void Set(string article)
        {
            UnityEngine.Debug.Log("From Originator: Current Version of article is: [\"" + article + "\"]");
            this.article = article;
        }

        public Memento StoreInMemento()
        {
            UnityEngine.Debug.Log("From Originator: Saving in Memento: [\"" + this.article + "\"]");
            return new Memento(this.article);
        }

        public string RestoreFromMemento(Memento memento)
        {
            article = memento.article;
            UnityEngine.Debug.Log("From Originator: Previous Article saved in Memento: [\"" + article + "\"]");
            return article;
        }
    }
}
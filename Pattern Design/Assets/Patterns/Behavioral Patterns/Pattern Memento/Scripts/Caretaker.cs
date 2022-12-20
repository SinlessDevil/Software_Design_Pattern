namespace PatternMemento
{
    public class Caretaker
    {
        System.Collections.Generic.List<Memento> savedArticles = new();

        public void Add(Memento m)
        {
            savedArticles.Add(m);
        }

        public Memento Get(int i)
        {
            return savedArticles[i];
        }

        public int GetCountOfSavedArticles()
        {
            return savedArticles.Count;
        }
    }
}
using UnityEngine;

namespace PatternMemento
{
    public class MementoDesignPattern : MonoBehaviour
    {
        private Caretaker _caretaker = new();

        private Originator _originator = new();

        int savedFiles = 0, currentArticle = 0;

        private void Start()
        {
            Debug.Log("------------------");
            Debug.Log("MEMENTO DESIGN PATTERN");

            // here we do some virtual typing and saving texts:
            Save("Tex1: Hello World, this is text example 1");
            Save("Text2: Ok here comes example number 2.");
            Save("Text3: And example number 3. Just testing.");
            Save("Text4: ....");

            // Here we do some virtual button pressing
            Debug.Log("Pressing Undo");
            Undo();
            Debug.Log("Pressing Undo");
            Undo();
            Debug.Log("Pressing Undo");
            Undo();
            Debug.Log("Pressing Redo");
            Redo();
        }

        // these methods below might get called when someone is pressing a button
        // you could easily implement it with unitys new ui system :)
        public void Save(string text)
        {
            _originator.Set(text);
            _caretaker.Add(_originator.StoreInMemento());
            savedFiles = _caretaker.GetCountOfSavedArticles();
            currentArticle = savedFiles;
        }
        public string Undo()
        {
            if (currentArticle > 0)
                currentArticle -= 1;

            Memento prev = _caretaker.Get(currentArticle);
            string prevArticle = _originator.RestoreFromMemento(prev);
            return prevArticle;
        }
        public string Redo()
        {
            if (currentArticle < savedFiles)
                currentArticle += 1;

            Memento next = _caretaker.Get(currentArticle);
            string nextArticle = _originator.RestoreFromMemento(next);
            return nextArticle;
        }
    }
}
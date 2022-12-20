using UnityEngine;

namespace PatternIterator
{
    public class StartUp : MonoBehaviour
    {
        private void Start()
        {
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Debug.Log("Straight traversal:");

            foreach (var element in collection)
            {
                Debug.Log(element);
            }

            Debug.Log("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Debug.Log(element);
            }
        }
    }
}
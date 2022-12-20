using System.Collections;

namespace PatternIterator
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => GetCurrentElement();
        // Returns the key of the current element
        public abstract int GetKey();
        // Returns the current element
        public abstract object GetCurrentElement();
        // Move forward to next element
        public abstract bool MoveNext();
        // Rewinds the Iterator to the first element
        public abstract void Reset();
    }
}
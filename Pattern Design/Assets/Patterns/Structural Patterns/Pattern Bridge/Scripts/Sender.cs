namespace Bridge
{
    public abstract class Sender 
    {
        protected IDataReader _reader;

        public Sender(IDataReader reader) => _reader = reader;
        public void SetDataReader(IDataReader reader) => _reader = reader;
        public abstract void Send();

    }
}

namespace Bridge
{
    public class EmailSender : Sender
    {
        public EmailSender(IDataReader reader) : base(reader) { }
        public override void Send()
        {
            _reader.Reade();
            UnityEngine.Debug.Log("Отправлены при помощи Email");
        }
    }
}

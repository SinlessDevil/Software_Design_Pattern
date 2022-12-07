namespace Bridge
{
    public class TelegramBotSender :Sender
    {
        public TelegramBotSender(IDataReader reader) : base(reader) { }
        public override void Send()
        {
            _reader.Reade();
            UnityEngine.Debug.Log("Отправлены при Telegram бота");
        }
    }
}
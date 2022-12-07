using UnityEngine;
using Bridge;

public class TestBridge : MonoBehaviour
{
    private void Start()
    {
        Sender sender = new EmailSender(new DataBaseReader());
        sender.Send();

        sender.SetDataReader(new FileReader());
        sender.Send();

        sender = new TelegramBotSender(new DataBaseReader());
        sender.Send();
    }
}
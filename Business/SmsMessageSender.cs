using Handlers;

namespace Business;

public class SmsMessageSender : IMessageSender
{
    public void SendMessage(MessageHandler message)
    {
        Console.WriteLine("SmsMessageSender : Sending sms message... ");
    }
}
using Handlers;

namespace Business;

public class EmailMessageSender : IMessageSender
{
    public void SendMessage(MessageHandler messageHandler)
    {
        Console.WriteLine("EmailMessageSender: Sending email message...");
    }
}
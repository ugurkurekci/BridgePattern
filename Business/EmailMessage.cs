using Handlers;

namespace Business;

public class EmailMessage : MessageHandler
{
    public EmailMessage(IMessageSender messageSender) : base(messageSender)
    {
    }

    public override void Send()
    {
        _messageSender.SendMessage(this);
    }
}
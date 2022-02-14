using Handlers;

namespace Business;

public class SmsMessage : MessageHandler
{
    public SmsMessage(IMessageSender messageSender) : base(messageSender)
    {
    }

    public override void Send()
    {
        _messageSender.SendMessage(this);
    }
}
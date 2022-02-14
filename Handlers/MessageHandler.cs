namespace Handlers;

public abstract class MessageHandler
{
    protected IMessageSender _messageSender;

    public MessageHandler(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public abstract void Send();
}
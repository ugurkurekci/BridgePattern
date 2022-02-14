namespace Handlers;

public interface IMessageSender
{
    void SendMessage(MessageHandler message);
}
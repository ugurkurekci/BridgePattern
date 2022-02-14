using Business;
using Handlers;

IMessageSender emailMessageSender = new EmailMessageSender();
MessageHandler emailMessage = new EmailMessage(emailMessageSender);
emailMessage.Send(); // output: EmailMessageSender: Sending email message...

IMessageSender smsMessageSender = new SmsMessageSender();
MessageHandler smsMessage = new SmsMessage(smsMessageSender);
smsMessage.Send();
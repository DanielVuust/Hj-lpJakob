
using System;
using System.Net.Mail;

namespace HjælpJakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("test", "me", "test", "Subject2", "testcc");
            IConvertMessage convertMessageToHtml = new ConvertMessageToHtml();
            message.Body = convertMessageToHtml.ConvertMessage(message.Body);

            SendMessage sendMessage = new SendMessage(message);
            sendMessage.SendMessageWithSpecificMessageCarrier(MessageCarrier.Smtp);

        }
    }
}

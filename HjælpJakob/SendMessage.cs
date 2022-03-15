using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpJakob
{
    class SendMessage
    {
        private Message _message;
        public SendMessage(Message message)
        {
            this._message = message;
        }
        public void SendMessageWithSpecificMessageCarrier(MessageCarrier type)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                SendMessageWithSmtp();
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                SendMessageWithVMessage(); 
            }
        }

        private void SendMessageWithSmtp()
        {
            Console.WriteLine("The message has been send with smpt");
        }
        private void SendMessageWithVMessage()
        {
            Console.WriteLine("The message has been send with VMessage");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    public class MessageContent
    {
        public string Message { get; set; }

        public string Sender { get; set; }

        public string Color { get; set; }

        public MessageContent(string message, string sender, string color)
        {
            Message = message;
            Sender = sender;
            Color = color;
        }

    }
}

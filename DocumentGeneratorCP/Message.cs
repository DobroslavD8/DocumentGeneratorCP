using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    class Message : IMessage
    {
        string message;

        public Message(string value)
        {
            message = value;
        }

        public string Operation()
        {
            return message;
        }
    }
}

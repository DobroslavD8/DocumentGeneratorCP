using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    class ApplicationDecorator : IMessage
    {
        IMessage message;

        public ApplicationDecorator(IMessage m)
        {
            message = m;
        }

        public string Operation()
        {
            DateTime currentTimeAndDate = DateTime.Now;
            currentTimeAndDate.ToString();
            return this.message.Operation() + "Application document created on " + currentTimeAndDate;
        }
    }
}

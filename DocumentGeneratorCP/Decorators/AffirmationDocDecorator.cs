using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    class AffirmationDocDecorator : IMessage
    {
        IMessage message;

        public AffirmationDocDecorator(IMessage m)
        {
            message = m;
        }

        public string Operation()
        {
            DateTime currentTimeAndDate = DateTime.Now;
            currentTimeAndDate.ToString();
            return this.message.Operation() + "Affirmation document created on " + currentTimeAndDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentGeneratorCP
{
    class ApologeticNoteDecorator : IMessage
    {
        IMessage message;

        public ApologeticNoteDecorator(IMessage m)
        {
            message = m;
        }

        public string Operation()
        {
            DateTime currentTimeAndDate = DateTime.Now;
            currentTimeAndDate.ToString();
            return this.message.Operation() + "Apologetic Note document created on " + currentTimeAndDate;
        }
    }
}

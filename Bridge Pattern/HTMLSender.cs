using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class HTMLSender:SenderMessages
    {
        public HTMLSender(IMessenger msg) : base(msg) { }

        public override void Send()
        {
            msg.SendMessage();
            Console.WriteLine("форматом .html");
        }
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    abstract public class SenderMessages
    {
        protected IMessenger msg;
        protected SenderMessages(IMessenger messenger) 
        {
            msg = messenger;
        }

        public virtual void Send() { }
    }
}

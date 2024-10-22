using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class SMS:IMessenger
    {
        public void SendMessage() => Console.Write("Сообщение отправлено через SMS ");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class Email:IMessenger
    {
        public void SendMessage() => Console.WriteLine("Сообщение отправлено через EMAIL ");
    }
}

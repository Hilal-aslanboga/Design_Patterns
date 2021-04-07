using Bridge.Lab_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Lab_2.Abstarct
{
    public abstract class MailSenderBase
    {
        public abstract void Send(MailStructure mailStructure);

        public void Save() => Console.WriteLine("Message saved.");
    }
}

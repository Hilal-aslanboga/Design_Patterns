using Bridge.Lab_2.Abstarct;
using Bridge.Lab_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Lab_2.Concrete
{
    public class OutlookSender : MailSenderBase
    {
        public override void Send(MailStructure mailStructure) => Console.WriteLine($"Title: {mailStructure.Title}\nText: {mailStructure.Text}\nDescription: The mail send via outlook service..!");
    }
}

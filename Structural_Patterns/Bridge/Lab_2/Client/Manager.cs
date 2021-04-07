using Bridge.Lab_2.Abstarct;
using Bridge.Lab_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Lab_2.Client
{
    public class Manager
    {
        public MailSenderBase MailSenderBase { get; set; }

        public void Info()
        {
            MailSenderBase.Send(new MailStructure
            {
                Title = "About The Course",
                Text = "Dear Participants,\nOur course hours were been changed.\nSincererly"
            });
        }

    }
}

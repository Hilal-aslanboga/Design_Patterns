using Bridge.Lab_1.Clients;
using Bridge.Lab_1.Concrete;
using Bridge.Lab_2.Client;
using Bridge.Lab_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1

            Console.WriteLine(new Client(new Operasyon_A()).Operasyon());
            Console.WriteLine(new Client(new Operasyon_B()).Operasyon());
            #endregion

            Console.WriteLine("\n");

            #region Lab_2
            Manager hilal = new Manager();
            Manager havva = new Manager();

            hilal.MailSenderBase = new OutlookSender();
            hilal.Info();

            Console.WriteLine("\n");

            havva.MailSenderBase = new GmailSender();
            havva.Info();
            #endregion

            Console.ReadKey();
        }
    }
}

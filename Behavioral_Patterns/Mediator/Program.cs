using Mediator.Lab_1.Concrete;
using Mediator.Lab_1.Interface;
using Mediator.Lab_2.BaseColleague;
using Mediator.Lab_2.BaseMediator;
using Mediator.Lab_2.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            IChatMediator chatMediator = new ChatMediator();
            IUser hilal = new BasicUser(chatMediator, "Beast");
            IUser havva = new GoldUser(chatMediator, "Savage");

            chatMediator.AddUser(hilal);
            chatMediator.AddUser(havva);

            hilal.SendMessage("Hello Suprise.");
            #endregion

            Console.WriteLine("\n");

            #region

            Arabulucu arabulucu = new Arabulucu();

            MainColleague merkez = new MainColleague(arabulucu, "Hilal Aslanboğa");
            Colleague_A sube_1 = new Colleague_A(arabulucu, "Burak Yılmaz");
            merkez.Gonder("Cuma günü için bir toplantı düzenledim. Lütfen e-posta üzerinden onaylar mısınız?");
            sube_1.Gonder("Tabiki efendim kontrol ediyorum.");

            Colleague_A sube_2 = new Colleague_A(arabulucu, "Havva Kaya");
            sube_2.Gonder("Toplantıya katılamayacağım.");
            arabulucu.Engellenmis(merkez.TeslimAlma);

            sube_2.Gonder("Engellendim");
            merkez.Gonder("Toplantıda görüşürüz");

            #endregion

            Console.ReadKey();
        }
    }
}

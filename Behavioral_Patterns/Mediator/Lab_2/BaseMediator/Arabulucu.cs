using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Lab_2.BaseMediator
{
    public class Arabulucu
    {
        public delegate void CallBack(string message, string sender);

        CallBack callBack;

        public void GirisYap(CallBack method) => callBack += method;
        public void Gonder(string message, string sender) => callBack(message, sender);

        public void Engellenmis(CallBack method) => callBack += method;
        public void Engellenmemis(CallBack method) => callBack += method;
    }
}

using Bridge.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Lab_1.Clients
{
    public class Client
    {
        IKopru _kopru;

        public Client(IKopru kopru) => _kopru = kopru;

        public string Operasyon() => $"Soyutlama <==Koprü==> {_kopru.OperasyonUygulamasi()}";
    }
}

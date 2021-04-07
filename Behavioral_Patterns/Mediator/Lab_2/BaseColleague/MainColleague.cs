using Mediator.Lab_2.BaseMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Lab_2.BaseColleague
{
    public class MainColleague
    {
        Arabulucu _mediator;
        protected string _name;
        public MainColleague(Arabulucu mediator, string name)
        {
            this._name = name;
            this._mediator = mediator;
            _mediator.GirisYap(TeslimAlma);
        }

        public virtual void TeslimAlma(string mesaj, string kimden) => Console.WriteLine($"Gönderen: {_name}\nMessage: {mesaj}");

        public void Gonder(string message) => Console.WriteLine($"Gönderen: {_name}\nMessage: {message}");
    }
}

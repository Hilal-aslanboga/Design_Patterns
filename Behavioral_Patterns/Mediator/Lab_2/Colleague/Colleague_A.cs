using Mediator.Lab_2.BaseColleague;
using Mediator.Lab_2.BaseMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Lab_2.Colleague
{
    public class Colleague_A : MainColleague
    {
        public Colleague_A(Arabulucu arabulucu, string name) : base(arabulucu, name) { }

        public override void TeslimAlma(string mesaj, string kimden)
        {
            if (!String.Equals(kimden, _name))
                Console.WriteLine($"{_name} alındı {kimden} : {mesaj}");
        }
    }
}

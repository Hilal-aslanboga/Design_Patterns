using Observer.Lab_1.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lab_1.Concrete
{
    public class CustomerObserver : BaseObserver
    {
        public override void Notification() => Console.WriteLine("Message to Customer ==> Product price changerd.");
    }
}

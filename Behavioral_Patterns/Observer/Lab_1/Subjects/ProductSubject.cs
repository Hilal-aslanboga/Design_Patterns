using Observer.Lab_1.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lab_1.Subjects
{
    public class ProductSubject
    {
        List<BaseObserver> observers = new List<BaseObserver>();

        public void Update()
        {
            Console.WriteLine("Product price changed");
            NotificationToAppUser();
        }

        public void Attached(BaseObserver observer) => observers.Add(observer);

        public void Dettached(BaseObserver observer) => observers.Remove(observer);

        private void NotificationToAppUser()
        {
            foreach (BaseObserver observer in observers)
                observer.Notification();
        }
    }
}

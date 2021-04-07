using Observer.Lab_1.Concrete;
using Observer.Lab_1.Subjects;
using Observer.Lab_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            var customerObesrver = new CustomerObserver();
            var employeeObserver = new EmployeeObserver();

            ProductSubject productSubject = new ProductSubject();

            productSubject.Attached(customerObesrver);
            productSubject.Attached(employeeObserver);

            productSubject.Update();

            #endregion


            Console.WriteLine("\n");

            #region Lab_2
            ConcreteProduct concreteProduct = new ConcreteProduct("HP Laptop", 12);

            concreteProduct.members.Add(new ConcreteMember { EmailAddress = "hilal_aslanboga@hotmail.com" });
            concreteProduct.members.Add(new ConcreteMember { EmailAddress = "burak.ylmz@hotmail.com" });

            concreteProduct.Price = 15;
            #endregion

            Console.ReadKey();
        }
    }
}

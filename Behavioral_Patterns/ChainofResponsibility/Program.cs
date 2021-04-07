using ChainofResponsibility.Lab_2.Concrete;
using ChainofResponsibility.Lab_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1

            #endregion

            Console.WriteLine("\n");

            #region Lab_2    
            //Sınıf içersindeki üyelere erişmek için örneklem çıkarıldı.
            Accounter accounter = new Accounter();
            Manager manager = new Manager();
            UnitManager unitManager = new UnitManager();

            //İşler alttan üste devredildi.
            accounter.SetNextHandler(manager);
            manager.SetNextHandler(unitManager);

            //Kredileri listeledik ve fiyatına göre hangi yöneticiye ait ise yazdırılcak.
            List<Loan> loans = new List<Loan>()
            {
                new Loan { Details = "Course", Amount = 50},
                new Loan { Details = "Course", Amount = 120},
                new Loan { Details = "Course", Amount = 200},
                new Loan { Details = "Course", Amount = 520}

            };

            foreach (Loan loan in loans)
            {
                accounter.HandlerLoan(loan);
            }

            #endregion

            Console.ReadKey();
        }
    }
}

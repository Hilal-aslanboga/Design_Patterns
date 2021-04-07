using ChainofResponsibility.Lab_2.Abstarct;
using ChainofResponsibility.Lab_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Lab_2.Concrete
{
    public class Manager : LoanHandlerBase
    {
        public override void HandlerLoan(Loan loan)
        {
            if (loan.Amount > 100 && loan.Amount <= 500) Console.WriteLine("Manager handle the loan request");
            else if (_nextHandler != null)
                _nextHandler.SetNextHandler(_nextHandler);
        }
    }
}

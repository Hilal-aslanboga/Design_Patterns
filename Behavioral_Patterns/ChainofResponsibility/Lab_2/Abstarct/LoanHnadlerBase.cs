using ChainofResponsibility.Lab_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Lab_2.Abstarct
{
    public abstract class LoanHandlerBase
    {
        protected LoanHandlerBase _nextHandler;

        //Sonraki işi devretmek için SetNextHandler methodu oluşturuldu. Şu anki işi sonraki işe atadı.
        public void SetNextHandler(LoanHandlerBase nextHnadler) => _nextHandler = nextHnadler;

        public abstract void HandlerLoan(Loan loan);
    }
}

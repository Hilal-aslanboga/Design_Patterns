using Decorator.Lab_2.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lab_2.Concrete
{
    public class Database : Lesson
    {
        public override string LessonName { get; set; }
        public override decimal PurchasePrice { get; set; }
    }
}

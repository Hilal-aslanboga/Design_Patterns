using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lab_2.Abstarct
{
    public abstract class Lesson
    {
        public abstract string LessonName { get; set; }
        public abstract decimal PurchasePrice { get; set; }
    }
}

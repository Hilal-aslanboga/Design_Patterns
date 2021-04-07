using Decorator.Lab_2.Abstarct;
using Decorator.Lab_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lab_2.Concrete
{
    public class PurchaseOffer : LessonDecorator
    {
        private readonly Lesson _lesson;

        public PurchaseOffer(Lesson lesson) : base(lesson) => _lesson = lesson;

        public int DiscountedPercentage { get; set; }

        public override string LessonName { get; set; }

        public override decimal PurchasePrice
        {
            get => _lesson.PurchasePrice - _lesson.PurchasePrice * DiscountedPercentage / 100;
            set { }
        }
    }
}

using Decorator.Lab_2.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Lab_2.Model
{
    public abstract class LessonDecorator : Lesson
    {
        private Lesson _lesson;

        public LessonDecorator(Lesson lesson) => _lesson = lesson;
    }
}

using Builder.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_1.Directories
{
    public class Directory
    {
        public void Constructor(IBuilder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();


            builder.BuilderPartA();
            builder.BuilderPartB();
            builder.BuilderPartA();
        }
    }
}

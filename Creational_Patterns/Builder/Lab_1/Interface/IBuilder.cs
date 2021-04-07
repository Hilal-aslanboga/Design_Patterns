using Builder.Lab_1.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_1.Interface
{
    public interface IBuilder
    {
        void BuilderPartA();
        void BuilderPartB();
        Product GetResult();
    }
}

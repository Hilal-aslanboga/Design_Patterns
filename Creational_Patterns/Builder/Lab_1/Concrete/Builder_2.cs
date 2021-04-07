using Builder.Lab_1.Delegate;
using Builder.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_1.Concrete
{
    public class Builder_2 : IBuilder
    {
        private Product product = new Product();

        public void BuilderPartA() => product.Add("T Component");

        public void BuilderPartB() => product.Add("Y Component");

        public Product GetResult() => product;
    }
}

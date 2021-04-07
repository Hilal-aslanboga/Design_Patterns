using Builder.Lab_1.Delegate;
using Builder.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lab_1.Concrete
{
    public class Builder_1 : IBuilder
    {
        private Product product = new Product();

        public void BuilderPartA() => product.Add("M Component");

        public void BuilderPartB() => product.Add("N Component");

        public Product GetResult() => product;
    }
}

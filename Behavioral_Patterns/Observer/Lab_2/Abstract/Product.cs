using Observer.Lab_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lab_2.Abstract
{
    public abstract class Product
    {
        public string ProductName { get; set; }

        private int _price;
        public int Price
        {
            get => _price;
            set
            {
                if (value > _price)
                {
                    Notification();
                }
                _price = value;
            }
        }

        public Product(string productName, int price)
        {
            this.ProductName = productName;
            this._price = price;
        }

        public List<ConcreteMember> members = new List<ConcreteMember>();

        private void Notification()
        {
            foreach (ConcreteMember member in members)
                member.Update(this);
        }
    }
}

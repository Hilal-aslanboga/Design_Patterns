using Observer.Lab_2.Abstract;
using Observer.Lab_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lab_2.Concrete
{
    public class ConcreteMember : IMember
    {
        public string EmailAddress { get; set; }

        public void Update(Product product) => Console.WriteLine($"{product.ProductName} fiyatı {product.Price} oldu. Bilgilendirme {EmailAddress} gönderildi.");      
    }
}

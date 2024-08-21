using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public abstract class Product : IProduct
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; private set; }

        public Product(int code, string name, decimal price)
        {
            Code = code;
            Name = name;
            Price = price;
            CalculateDiscount();
        }

        private void CalculateDiscount()
        {
            if (Price < 15)
                Discount = Price * 0.05m;
            else if (Price <= 50)
                Discount = Price * 0.25m;
            else
                Discount = Price * 0.30m;
        }
    }
}

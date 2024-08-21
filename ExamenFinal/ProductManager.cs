using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class ProductManager
    {
        private List<IProduct> products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            if (products.Any(p => p.Code == product.Code))
                throw new InvalidOperationException("Product with same code already exists");
            products.Add(product);
        }

        public void RemoveProduct(int code)
        {
            products.RemoveAll(p => p.Code == code);
        }

        public IProduct GetProduct(int code)
        {
            return products.FirstOrDefault(p => p.Code == code);
        }

        public void UpdateProductPrice(int code, decimal newPrice)
        {
            IProduct product = GetProduct(code);
            if (product != null)
                product.Price = newPrice;
        }

        public void ShowProducts()
        {
            foreach (IProduct product in products)
                Console.WriteLine($"CODIGO: {product.Code}, NOMBRE: {product.Name}, PRECIO: {product.Price}, DESCUENTO: {product.Discount}");
        }
    }
}

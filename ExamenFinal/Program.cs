using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();

            while (true)
            {
                Console.WriteLine("1. Introducir producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Consultar producto");
                Console.WriteLine("4. Modificar precio");
                Console.WriteLine("5. Mostrar productos");
                Console.WriteLine("6. Salir");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Código: ");
                        int code = int.Parse(Console.ReadLine());
                        Console.Write("Nombre: ");
                        string name = Console.ReadLine();
                        Console.Write("Precio: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        manager.AddProduct(new ProductImpl(code, name, price));
                        break;
                    case 2:
                        Console.Write("Código del producto a eliminar: ");
                        int codeToRemove = int.Parse(Console.ReadLine());
                        manager.RemoveProduct(codeToRemove);
                        break;
                    case 3:
                        Console.Write("Código del producto a consultar: ");
                        int codeToConsult = int.Parse(Console.ReadLine());
                        IProduct product = manager.GetProduct(codeToConsult);
                        if (product != null)
                            Console.WriteLine($"NOMBRE: {product.Name}, PRECIO: {product.Price}");
                        else
                            Console.WriteLine("Producto no encontrado");
                        break;
                    case 4:
                        Console.Write("Código del producto a modificar: ");
                        int codeToUpdate = int.Parse(Console.ReadLine());
                        Console.Write("Nuevo precio: ");
                        decimal newPrice = decimal.Parse(Console.ReadLine());
                        manager.UpdateProductPrice(codeToUpdate, newPrice);
                        break;
                    case 5:
                        manager.ShowProducts();
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}

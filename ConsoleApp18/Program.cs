using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductCrud productCrud = new ProductCrud();
            int c = 0;
            do
            {
                Console.WriteLine("1. Product list");
                Console.WriteLine("2.Add Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Get Product by id");
                Console.WriteLine("Select above options");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        List<Product> prods = productCrud.List();
                        Console.WriteLine("Id \t Name \t Price ");
                        foreach (Product p in prods)
                        {
                            Console.WriteLine($"{p.Id} \t {p.Name}  \t {p.Price}");
                        }
                        break;

                    case 2:
                        Product p1 = new Product();
                        Console.WriteLine("Enter an id");
                        p1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter an name");
                        p1.Name = Console.ReadLine();
                        Console.WriteLine("Enter an Price");
                        p1.Price = Convert.ToInt32(Console.ReadLine());
                        productCrud.AddProduct(p1);
                        Console.WriteLine("Product Added...");
                        break;

                    case 3:
                        Product p2 = new Product();
                        Console.WriteLine("Enter an id");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter an name");
                        p2.Name = Console.ReadLine();
                        Console.WriteLine("Enter an Price");
                        p2.Price = Convert.ToInt32(Console.ReadLine());
                        productCrud.UpdateProduct(p2);
                        Console.WriteLine("Product Uppdated...");
                        break;

                    case 4:
                        Product p3 = new Product();
                        Console.WriteLine("Enter id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        productCrud.DeleteProduct(id);
                        Console.WriteLine("Product Deleted..");
                        break;

                    case 5:
                        Console.WriteLine("Enter Product id to search");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Product product = productCrud.GetProductbyId(id2);
                        if(product.Id>0)
                        {
                            Console.WriteLine($"Id = {product.Id} , Name ={product.Name}, Price= {product.Price}");
                        }
                        else
                        {
                            Console.WriteLine("Product not found..");
                            break;

                        }
                        break;
                 default:
                        Console.WriteLine("Wrong option selected");
                        break;

                }
                Console.WriteLine("Select 1 for continue and 0 for exit");
                c = Convert.ToInt32(Console.ReadLine());
            }
            while (c == 1);
          
        }
    }
}

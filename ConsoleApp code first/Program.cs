using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_code_first.db;

namespace ConsoleApp_code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager db = new DatabaseManager();
            //db.addProduct(new Product() { name = "product 1", price = 50.6f, quantity = 140 });
            //db.addProduct(new Product() { name = "product 1", price = 50.6f, quantity = 140 });
            //db.addProduct(new Product() { name = "product 1", price = 50.6f, quantity = 140 });
            //db.addProduct(new Product() { name = "product 1", price = 50.6f, quantity = 140 });

            List<Product> products = db.getAllProducts();

            System.Console.WriteLine("*************** Old Value*******************");
            foreach (Product p in products)
            {
                System.Console.WriteLine(
                    "id         = " + p.id +
                    "\nname     = " + p.name +
                    "\nprice    = " + p.price +
                    "\nquantity = " + p.quantity);
                System.Console.WriteLine("**********************************");
            }

            /*for (int i = 0; i < products.Count; i++)
            {
                products[i].name = "asd " + i;
                products[i].price = i + 2.5;
                products[i].quantity = (1 + i) * 10;
                db.updateProduct(products[i]);
            }*/
            db.deleteProduct(products[products.Count - 1]);
            db.deleteProduct(products[2]);
            System.Console.WriteLine("*************** new Value *******************");
            foreach (Product p in db.getAllProducts())
            {
                System.Console.WriteLine(
                    "id         = " + p.id +
                    "\nname     = " + p.name +
                    "\nprice    = " + p.price +
                    "\nquantity = " + p.quantity);
                System.Console.WriteLine("**********************************");
            }
            System.Console.Read();
        }
    }
}

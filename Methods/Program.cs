using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Cost = 15;
            product1.Definition = "Just an apple";

            Product product2 = new Product();
            product2.Name = "Melon";
            product2.Cost = 80;
            product2.Definition = "Just a melon";

            Product[] products = new Product[] { product1, product2 };
            

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Cost);
                Console.WriteLine(product.Definition);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("--------------Methods-------");
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);
        }
    }
}

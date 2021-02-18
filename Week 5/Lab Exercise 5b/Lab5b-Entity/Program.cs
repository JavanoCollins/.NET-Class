using System;
using Lab5b_Entity.Data;
using Lab5b_Entity.Models;
using System.Linq;

namespace Lab5b_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Books365");

            // Adding products to the database table

            // This makes sure that the context is 
            // disposed off when we're finished with it
            using BookstoreContext context = new BookstoreContext();

            // Reading items from the database
            //var cheapProducts = from product in context.Products
            //                    where product.Price > 0.1m
            //                    orderby product.Id
            //                    select product;

            //Console.WriteLine("Books costing less than 0.75M are: ");

            //foreach(Product p in cheapProducts)
            //{
            //    Console.WriteLine($"ID: {p.Id}");
            //    Console.WriteLine($"Name: {p.Name}");
            //    Console.WriteLine($"Price: {p.Price}");
            //    Console.WriteLine();
            //}

            // Deleting items from the database
            var excessItems = context.Products.Where(p => p.Id >= 5).FirstOrDefault();

            if (excessItems is Product)
            {
                context.Remove(excessItems);
            }
            
            context.SaveChanges();
            

            // Create products
            //Product book1 = new Product()
            //{
            //    Name = "Moby Dick",
            //    Price = 0.95M
            //};

            // Add to the products table
            //context.Products.Add(book1);

            //Product book2 = new Product()
            //{
            //    Name = "Scienceblind",
            //    Price = 0.50M
            //};

            //Product book3 = new Product()
            //{
            //    Name = "Letters to a Young Scientist",
            //    Price = 0.75M
            //};

            //Product book4 = new Product()
            //{
            //    Name = "Notes from Underground",
            //    Price = 0.97M
            //};

            //// Add it to the database (Entity Framework knows it is a product)
            //context.Add(book2);
            //context.Add(book3);
            //context.Add(book4);

            //// Save the changes
            //context.SaveChanges();
            //Console.WriteLine("Saved prodcuts to the database as required.");

        }
    }
}

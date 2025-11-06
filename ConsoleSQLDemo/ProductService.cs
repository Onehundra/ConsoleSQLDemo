using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSQLDemo
{
    public class ProductService
    {
        private readonly AppDbContext db;



        public ProductService()
        {
            db = new AppDbContext();
        }
        //Add Product till databasen 
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            Console.WriteLine("Added product successfully");
        }

        //Läsa produkter från databas

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

    }
}

namespace ConsoleSQLDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbService = new ProductService();

            //Product cola = new Product();
            //cola.Name = "Coca-Cola";
            //cola.Price = 9.99m;
            //cola.CreateData = DateTime.Now;
            //dbService.AddProduct(cola);


            //Se alla produkter
            //Console.WriteLine("All products in the database: ");
            //var products = dbService.GetProducts();

            //foreach(var product in products)
            //{
            //    Console.WriteLine($"{product.Id} {product.Name} {product.Price}");
            //}


            //Hämta ut en produkt
            //Console.WriteLine("One product from database: ");

            //var product= dbService.GetProduct(1);

            //Console.WriteLine(product.Name);
        }
    }
}

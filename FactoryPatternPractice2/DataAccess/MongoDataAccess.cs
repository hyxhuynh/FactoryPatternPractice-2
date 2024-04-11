using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPractice2.DataAccess
{
    public class MongoDataAccess : IDataAccess
   {
        // List of products
        // Static: Data in the list never change
        public static List<Product> Furnitures = new List<Product>()
        {
            new Product() { Name = "Mattress", Price = 849.99},
            new Product() { Name = "Bedframe", Price = 499.99},
            new Product() { Name = "Lamp", Price = 84.99}
        };

        // Implement methods from IDataAccess
        public List<Product> LoadData()
        {
            Console.WriteLine("\nLoading MongoDataAccess...");
            return Furnitures;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving MongoDataAccess...");
        }
    }
}

namespace FactoryPatternPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User input
            Console.WriteLine("What database do you want to use? \nPlease enter: list, SQL, or Mongo");
            string userInput = Console.ReadLine();

            // Get list of data using user input
            // Call the LoadData method
            IDataAccess database = DataAccessFactory.GetDataAccessType(userInput);
            List<Product> furnitureList = database.LoadData();

            // Display list of data to the console
            Console.WriteLine("Here are the furnitures you requested:");
            foreach (Product f in furnitureList)
            {
                Console.WriteLine($"Name: {f.Name} | Price: ${f.Price}");
            }

            // Call the SaveData method
            database.SaveData();
        }
    }
}

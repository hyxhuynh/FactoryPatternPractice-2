using FactoryPatternPractice2.DataAccess;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPractice2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    Console.WriteLine($"\nYou have entered: {databaseType}. \nInput NOT recognized. \nDefault database type requested:");
                    return new ListDataAccess();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPractice2
{
    public interface IDataAccess
    {
        List<Product> LoadData();
        void SaveData();
    }
}

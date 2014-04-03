using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Inheritence
    {
        public static void Main(string[] args)
        {
            Stock stock = new Stock { Name = "hdfc", SharesOwned = 100 };
            House house = new House { Name = "bac", Mortgage = 100};
        }
    }
    public class Asset
    {
        public string Name;
    }
    public class Stock: Asset
    {
        public decimal SharesOwned;
    }
    public class House: Asset
    {
        public decimal Mortgage;
    }
}

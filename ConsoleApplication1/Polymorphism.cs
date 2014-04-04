using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Polymorphism
    {
        public static void Main(string[] args)
        {
            House house = new House { Name="house"};
            Display(house);

            //UpCasting
            Stock msft = new Stock();
            Asset a = msft;
            if (a == msft)
                Console.WriteLine("Identical");

            Console.WriteLine(a.Name);
            //Console.WriteLine(a.SharesOwned); //Error

            //downcasting and as operator
            Asset asset = new Asset();
            //Stock stock = (Stock)asset; // this will fail at runtime
            Stock stock = asset as Stock; // this will not fail but return null and will not give actual casting error
            if (stock !=  null)
                Console.WriteLine(stock);
            else
                Console.WriteLine("stock object is null");

            //is operator
            if (asset is Stock)
                Console.WriteLine("a is stock");
            else
                Console.WriteLine("a is not stock");

            //virtual

            Console.Read();
        }
        public static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }
      
    }
}
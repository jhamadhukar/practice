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

            //downcasting


            Console.Read();
        }
        public static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }
    }
}
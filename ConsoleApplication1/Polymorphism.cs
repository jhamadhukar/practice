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
            Console.Read();
        }
        public static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }
    }
}
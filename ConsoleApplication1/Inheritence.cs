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

            Overrider overrider = new Overrider();
            BaseClass b = overrider;
            b.Foo();
            overrider.Foo();

            Hider hider = new Hider();
            BaseClass b2 = hider;
            hider.Foo();
            b2.Foo();




            Console.Read();
        }
    }
    public class Asset
    {
        public Asset()
        {
            Console.WriteLine("asset constructor");
        }
        public string Name;
        public virtual decimal Liability { get { return 0; } }
    }
    public class Stock: Asset
    {
       
        public decimal SharesOwned;

    }
    public class House: Asset
    {
        public House()
        {
            Console.WriteLine("house constructor");
        }
        public decimal Mortgage;
        public override decimal Liability
        {
            get
            {
                return Mortgage;
            }
        }
    }

    public class BaseClass
    {
        public virtual void Foo(){ Console.WriteLine("Baseclass.Foo()"); }
    }

    public class Overrider: BaseClass
    {
        public override void Foo()
        {
            Console.WriteLine("Overrider.Foo()");
        }
    }
    public class Hider: BaseClass
    {
        public new void Foo()
        {
            Console.WriteLine("Hider.Foo()");
        }
    }
}
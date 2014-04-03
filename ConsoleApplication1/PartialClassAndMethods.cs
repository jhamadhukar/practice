using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PartialClassAndMethods
    {
        public static void Main(string[] args)
        {
            abc abc = new abc();
            //abc.a() // partial method must be implicitly private
            
            Console.Read();
        }
    }

    partial class abc : b
    {
        public abc()
            : base("abc partial constructor")
        {


        }
        partial void a()
        {

            Console.WriteLine("partial class method a");
        }


    }
    public class partialtest
    {
        public void a()// partial method must have declared inside partial method
        {

        }
    }
}

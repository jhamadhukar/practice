using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class OrderOfExecution
    {
        public static void Main(string[] args)
        {
            b a = new ConsoleApplication1.b();



            Console.ReadLine();
        }
    }
    public class a
    {
        static a()
        {
            Console.WriteLine("a static constructor");
        }
     
        public a()
        {
            Console.WriteLine("a instance constructor");
        }
        public a(string a)
        {
            Console.WriteLine(a);
        }
    }
    public class b: a
    {
        static b()
        {
              Console.WriteLine("b static constructor");
        }
        
        public b()
            : this("base parameter")
        {
              Console.WriteLine("b instance constructor");
        }
        public b(string bParam):base ("base single parameter constructor")
        {
            Console.WriteLine(bParam);
        }
    }
    public static class c
    {
        static string a = "abc";
    }
    partial class abc
    {
        partial void a();
        

    }
}
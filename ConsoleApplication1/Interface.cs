using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     //If a class is Inherited by two interfaces having method with same name.
    public class Interface
    {
        public static void Main(string[] args)
        {
            InterfaceTesting i = new InterfaceTesting();
            
             ((I1)i).Foo();// To call Foo method we must have to cast object to that interface.
             ((I2)i).Foo();
        }
    }
    public interface I1
    {
        void Foo();
    }
    public interface I2
    {
        int Foo();
    }
    public class InterfaceTesting: I1, I2
    {
        void I1.Foo()  //doesn't accept access modifier.
        {

        }
        int I2.Foo()  
        {
            return 0;
        }
    }
}

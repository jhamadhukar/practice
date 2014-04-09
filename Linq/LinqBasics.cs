using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class LinqBasics
    {
        public static void Main(string[] args)
        {
            GetFourCharacterLongStringFromArray();
            GetStringsContainingCharacterAUsingQueryExpressionSyntax();
            Console.Read();
        }

        public static void GetFourCharacterLongStringFromArray()
        {
            string[] names = { "Tom", "Dick", "Harry" };
            IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n=> n.Length >=4);
            foreach (var item in filteredNames)
            {
                Console.WriteLine(item);
            }

            filteredNames = names.Where(n=> n.Length >= 4);
            foreach (var item in filteredNames)
            {
                Console.WriteLine(item);
            }
        }
        public static void GetStringsContainingCharacterAUsingQueryExpressionSyntax()
        {
            string[] names = { "Tom", "Dick", "Harry" };
            IEnumerable<string> filteredNames = from n in names
                                                where n.Contains("a")
                                                select n;
            foreach (var item in filteredNames)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(item);
            }

        }
    }
}
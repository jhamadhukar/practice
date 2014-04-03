using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = GenerateRandomEmailAddress();
              string str= RandomDigit(5);
              Console.WriteLine(email);
            Task<int> task =Task.Run(()=> Enumerable.Range(2, 3000000).Count(n=> Enumerable.Range(2,(int)Math.Sqrt(n) -1 ).All(i=> n % i > 0)));

            Console.WriteLine("task running...");
            Console.WriteLine("result {0}", task.Result.ToString());
            Console.ReadLine();
        }
        public static string RandomDigit(int length)
        {
            Random random = new Random();
            String randomString = "";
            int randNumber;

            for (int i = 0; i < length; i++)
            {
                randNumber = random.Next(48, 58);
                randomString = randomString + (char)randNumber;
            }
            return randomString;
        }

        public static string GenerateRandomEmailAddress()
        {
            string[] domainNames = { "gmail.com", "yahoo.com", "hotmail.com", "aol.com" };
            Random random = new Random();
            String randomString = "";
            int randNumber;
            int maxEmailChars = random.Next(3, 20);
            int capitalCharPosition = random.Next(0, maxEmailChars -3);
            int numericCharPosition = random.Next(capitalCharPosition, maxEmailChars - 1);
            for (int i = 0; i < maxEmailChars; i++)
            {
                if(i == capitalCharPosition)
                    randNumber = random.Next(65, 91);
                else if(i == numericCharPosition)
                    randNumber = random.Next(48, 58);
                else
                    randNumber = random.Next(97, 123);
                randomString = randomString + (char)randNumber;
            }
            int domainPosition = random.Next(0, 3);
            
            return randomString +"@" + domainNames[domainPosition];
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTesting
{
    public class Abstract
    {
        public static void Main(string[] args)
        {
            
        }
    }
    public abstract class Asset
    {
        public abstract decimal NetValue { get; }
    }
    public class Stock: Asset
    {
        public long SharesOwned;
        public decimal CurrentPrice;

        public override decimal NetValue
        {
            get { return SharesOwned * CurrentPrice; }
        }
    }
}
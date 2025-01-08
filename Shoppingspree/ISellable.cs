using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal interface ISellable
    {


        public double CalculateSalePrice(double discountPercentage, bool hasTax);
    }
}

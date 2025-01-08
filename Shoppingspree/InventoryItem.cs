using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal class InventoryItem : ISellable
    {
        private string _description;
        private int _count;
        private int _price;


        public InventoryItem(string description, int count, int price)
        {
            _description = description;
            _count = count;
            _price = price;
        }

        public double CalculateSalePrice(double discountPercentage, bool hasTax)
        {
            double taxMultiplier = 1;
            if (hasTax) { taxMultiplier = 1.25; }
            return _price * (1 - discountPercentage / 100)*taxMultiplier;
        }
    }
}

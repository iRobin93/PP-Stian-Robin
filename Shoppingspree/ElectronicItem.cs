using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal class ElectronicItem : InventoryItem
    {
        private int _voltage;
        private string _insurance;


        public ElectronicItem(string description, int count, int price, string insurance):base(description, count, price)
        {
            _voltage = 5;
            _insurance = insurance;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal class ClothingItem : InventoryItem
    {

        private string _size;
        private string _color;


        public ClothingItem(string description, int count, int price, string size, string color) :base(description, count, price)
        {
            _size = size;
            _color = color;
        }
    }
}

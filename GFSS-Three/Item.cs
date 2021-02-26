using System;
using System.Collections.Generic;
using System.Text;

namespace GFSS_Three
{
    public class Item
    {
        private List<Item> _subItems = new List<Item>();
        public string Number { get; set; }

        public Item(string number)
        {
            this.Number = number;
        }

        public IEnumerable<Item> GetSubItems()
        {
            return _subItems;
        }

        public void AddSubItem(Item it)
        {
            _subItems.Add(it);
        }
    }
}

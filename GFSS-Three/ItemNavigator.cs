using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GFSS_Three
{
    public class ItemNavigator
    {
        private List<Item> Items = new List<Item>();

        public void AddItem(Item it)
        {
            Items.Add(it);
        }

        /// <summary>
        /// Gets a sub-item summary for a given item number.
        /// </summary>
        /// <param name="itemNumber">The item number of the item to get the sub-item summary of.</param>
        public SubItemSummary[] GetSubItemSummary(string itemNumber)
        {
            IEnumerable<Item> subItems = GetSubItems(itemNumber);

            List<SubItemSummary> subItemSummary = new List<SubItemSummary>();

            foreach (Item item in subItems)
            {
                IEnumerable<SubItemSummary> tempSummaries = TransformSubItems(item, item.GetSubItems());

                subItemSummary.AddRange(tempSummaries);
            }

            return subItemSummary.ToArray();
        }

        public SubItemSummary[] AlternativeGetSubItemSummary(string itemNumber)
        {
            var collSubItemSummary = GetSubItems(itemNumber).Aggregate<Item, List<SubItemSummary>>(new List<SubItemSummary>(), (list, it) => {
                list.AddRange(TransformSubItems(it, it.GetSubItems()));
                return list;                                                                              
            });

            return collSubItemSummary.ToArray();
        }

        public IEnumerable<Item> GetSubItems(string itemNumber)
        {
            var item =Items.First(it => string.Equals(it.Number, itemNumber));
            return item.GetSubItems();
        }

        public IEnumerable<SubItemSummary> TransformSubItems(Item item, IEnumerable<Item> subItems)
        {
            return subItems.Select(si => new SubItemSummary() { Number = si.Number, ParentItemNumber = item.Number });
        }

    }
}

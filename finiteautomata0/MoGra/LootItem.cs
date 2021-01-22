using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGra
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropRate { get; set; }
        public bool IsDefaultItem { get; set; }
        public LootItem(Item details, int dropRate, bool isDefaultItem)
        {
            Details = details;
            DropRate = dropRate;
            IsDefaultItem = isDefaultItem;
        }
    }
}

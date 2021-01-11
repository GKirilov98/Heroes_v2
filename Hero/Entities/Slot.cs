using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.Entities
{
    public class Slot
    {
        public Guid SlotId { get; set; }
        public string Name { get; set; }
        public List<Item> items { get; set; }
    }
}

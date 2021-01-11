using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.Entities
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public Guid SlotId { get; set; }
        public  Slot Slot { get; set; }
        public  int Stamina { get; set; }
        public  int Strength { get; set; }
        public  int Attack { get; set; }
        public  int Defence { get; set; }
        public List<HeroItem> Inventory { get; set; }
    }
}

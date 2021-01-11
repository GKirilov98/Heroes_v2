using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.Entities
{
    public class HeroItem
    {
        public Guid HeroItemId { get; set; }
        public Guid HeroEId { get; set; }
        public HeroE HeroE { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}

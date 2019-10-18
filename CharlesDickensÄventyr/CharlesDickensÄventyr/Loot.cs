using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesDickensÄventyr
{
    public class Loot
    ///<summary>
    /// This is for the loot that can be dropped by monster
    /// 
    /// Programmers: Christopher Velander, Johan Danielsson, Patrik Hurtig
    /// 
    /// Date: 2018-03-21
    /// </summary>
    {
        public AllItems Item { get; set; } // I heard that you need a property of the Allitems class in order for them to truly exist
        public bool Important { get; set; } //Is the item important for progress?
        public int DropChance { get; set; } // What is the dropchance of this item?

        public Loot(AllItems item, bool important, int dropChance)
        {
            Item = item;
            Important = important;
            DropChance = dropChance;
        }
    }
}

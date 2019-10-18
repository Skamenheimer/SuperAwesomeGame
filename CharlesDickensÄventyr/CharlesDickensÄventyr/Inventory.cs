using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesDickensÄventyr
{
    public class Inventory
    ///<summary>
    /// Items in the inventory
    /// 
    /// Programmers: Christopher Velander, Johan Danielsson, Patrik Hurtig
    /// 
    /// Date: 2018-03-21
    /// </summary>
    {
        public AllItems Items { get; set; } // I heard that you need a property of the Allitems class in order for them to truly exist
        public int Amount { get; set; } // How many memes do you have on you?

        public Inventory(AllItems items, int amount)
        {
            Items = items;
            Amount = amount;
        }
    }
}

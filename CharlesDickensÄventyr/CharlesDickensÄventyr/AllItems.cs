using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesDickensÄventyr
{
    public class AllItems
        ///<summary>
        /// Well, there is a lot of items, give them an ID and a name so we know what is what, superclass. Big Dawg
        /// </summary>
    {
        public int ID { get; set; } //Puts a number to each item, it will make everything easier telling them apart
        public string Name { get; set; } //The item still needs a name

        public AllItems(int id, string namn, AllItems key = null)
        {
            ID = id;
            Name = namn;
        }
    }
}

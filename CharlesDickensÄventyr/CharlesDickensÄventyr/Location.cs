using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesDickensÄventyr
{
    public class Location: AllItems
    ///<summary>
    /// A class for the locations, keep in mind, subclass of AllItems in order to gain that juicy ID and Name properties
    /// 
    /// Programmers: Christopher Velander, Johan Danielsson, Patrik Hurtig
    /// 
    /// Date: 2018-03-21
    /// </summary>
    {
        public string LokationsDesc { get; set; } //Description of the current location
        public AllItems RequiredKey { get; set; } // Does the location require a key?
        public Enemy RoomEnemy { get; set; } // Does the location have an enemy?

        public Location Up { get; set; } // Want to go up?
        public Location Right { get; set; } // They say girls are always right..
        public Location Left { get; set; } // To the left to the left
        public Location Down { get; set; } // Come from a land down under?

        public Location(int id, string namn, string beskrivning, 
               AllItems required = null, Enemy enemy = null) : base(id,namn) // base is there because the base of ID and Name is in AllItems, we want it
        {
            ID = id;
            Name = namn;
            LokationsDesc = beskrivning;
            RequiredKey = required;
            RoomEnemy = enemy;
        }
    }
}

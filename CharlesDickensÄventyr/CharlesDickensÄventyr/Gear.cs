using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesDickensÄventyr
{
    public class Gear: AllItems
    ///<summary>
    /// Gear A.K.A Weapons where it will let you know how much damage the weapons can do, this will be useful for the random class
    /// Keep in mind, subclass of AllItems for that ID and Name
    /// 
    /// Programmers: Christopher Velander, Johan Danielsson, Patrik Hurtig
    /// 
    /// Date: 2018-03-21
    /// </summary>
    {
        public int MinDmg { get; set; } //minimum amount of damage done
        public int MaxDmg { get; set; } //maximum amount of damage done

        public Gear(int id, string namn, int minDmg, int maxDmg): base(id, namn) // base is there because the base of ID and Name is in AllItems, we want it
        {
            ID = id;
            Name = namn;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
        }
    }
}

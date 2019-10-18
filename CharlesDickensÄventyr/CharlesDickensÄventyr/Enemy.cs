using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesDickensÄventyr
{
    public class Enemy: AllItems
    ///<summary>
    /// This class will aid in creating the enemies you fight in this game, keep in mind it is a subclass of AllItems so we can use the ID and Name
    /// Properties
    /// 
    /// Programmers: Christopher Velander, Johan Danielsson, Patrik Hurtig
    /// 
    /// Date: 2018-03-21
    /// </summary>
    {
        public int Health { get; set; } // How much health will the enemy have?
        public int TotalHealth { get; set; } // What is the total amount of health the enemy will have?
        public int GivenExp { get; set; } // How much gainz will the enemy provide?
        public int Damage { get; set; } // How much will the enemy be able to hit?

        public List<Loot> DropLoot { get; set; } // A list for taking in the dropped loot

        public Enemy(int id, string namn, int damage, int exp, int health, int totalHealth) : base(id,namn) // base is there because the base of ID and Name is in AllItems, we want it
        {
            Health = health;
            TotalHealth = totalHealth;
            GivenExp = exp;
            Damage = damage;
            ID = id;
            Name = namn;

            DropLoot = new List<Loot>();
        }
    }
}

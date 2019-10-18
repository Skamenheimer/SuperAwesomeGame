using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesDickensÄventyr
{
    public class Character
    ///<summary>
    /// The class for the character
    /// 
    /// Programmers: Christopher Velander, Johan Danielsson, Patrik Hurtig
    /// 
    /// Date: 2018-03-21
    /// </summary>
    {
        public int Exp { get; private set; } //Property for gainz
        public int CurrentHealth { get; set; } //Wounded much?
        public int TotalHealth { get; set; } //Healthy boi
        public Location CharLocation { get; set; } //Where are you?
        public List<Inventory> Bag { get; set; } // What do you have in your bag?

        public Character(int exp, int totalHealth, int currentHealth)
        {
            Exp = exp;
            TotalHealth = totalHealth;
            CurrentHealth = currentHealth;

            Bag = new List<Inventory>();
        }

        public bool HasGotKey(Location location) //Do you have the key? It is bool, never forget
        {
            if (location.RequiredKey == null) //Do you need a key?
            {
                return true;
            }

            foreach (Inventory item in Bag) //Do you have the key?
            {
                if (item.Items.ID == location.RequiredKey.ID)
                {
                    return true; // Yeah you do
                }
            }

            return false;
        }

        public void AddItem(AllItems items) //Method for adding items to your bag
        {
            foreach (Inventory item in Bag)
            {
                if (item.Items.ID == items.ID) //Does the item exist in your bag already?
                {
                    item.Amount++; //Add another one, save some space
                }
            }

            Bag.Add(new Inventory(items, 1)); //Add a new item
        }

        public int Level() //Method for dem gainz
        {
            int level = ((Exp / 50) + 1); //50 exp for 1 level, seems fair

            if (Exp >= 1000) //Max level? shii
            {
                level = 10;
            }
            return level;
        }

        public void HealthPerLevel(int exp) //Want some gainz with that level?
        {
            Exp += exp;
            TotalHealth = (Level() * 10);
        }
    }
}

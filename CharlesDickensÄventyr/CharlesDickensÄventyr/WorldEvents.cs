using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesDickensÄventyr
{
    public static class WorldEvents
    ///<summary>
    /// The world put in a class, this is muchos importante
    /// Keep in mind, it is a static class, meaning you can't create an object of this, it will always be available and active for you, bby
    /// 
    /// Programmers: Christopher Velander, Johan Danielsson, Patrik Hurtig
    /// 
    /// Date: 2018-03-21
    /// </summary>
    {
        public static readonly List<AllItems> WorldItems = new List<AllItems>(); //List for taking in all the weapons and items in the game
        public static readonly List<Location> Locations = new List<Location>(); // List for taking in all the locations in the game
        public static readonly List<Enemy> WorldEnemies = new List<Enemy>(); // List for taking in all the enemies in the game

        // Inputting a specific ID number to each item
        public const int Weapon_ID_Iron_Sword = 1;
        public const int Weapon_ID_Stone_Axe = 2;
        public const int Weapon_ID_GreatSword = 3;
        public const int Weapon_ID_BattleAxe = 4;

        public const int Loot_ID_Key = 5;

        public const int Enemy_ID_Llama = 6;
        public const int Enemy_ID_Ghoul = 7;
        public const int Enemy_ID_WereWolf = 8;
        public const int Enemy_ID_Snake = 9;
        public const int Enemy_ID_Skeleton = 10;
        public const int Enemy_ID_Minitaur = 11;
        public const int Enemy_ID_Dragon = 12;

        public const int Location_ID_Start = 13;
        public const int Location_ID_Garden = 14;
        public const int Location_ID_GraveYard = 15;
        public const int Location_ID_Woods = 16;
        public const int Location_ID_GrassLand = 17;
        public const int Location_ID_Crypt = 18;
        public const int Location_ID_Clearing = 19;
        public const int Location_ID_Cave = 20;

        static WorldEvents()
        {
            AddingItems();
            AddingEnemies();
            AddingLocation();
            
        }

        /// <summary>
        /// Creating all the items and putting them in the WorldItems list
        /// </summary>
        private static void AddingItems()
        {
            WorldItems.Add(new Gear(Weapon_ID_Iron_Sword, "Iron Sword", 1, 3)); // (ID, Name, minDamage, maxDamage)
            WorldItems.Add(new Gear(Weapon_ID_Stone_Axe, "Stone Axe", 2, 3)); // (ID, Name, minDamage, maxDamage)
            WorldItems.Add(new Gear(Weapon_ID_GreatSword, "Greatsword", 3, 5)); // (ID, Name, minDamage, maxDamage)
            WorldItems.Add(new Gear(Weapon_ID_BattleAxe, "Battleaxe", 5, 12)); // (ID, Name, minDamage, maxDamage)
            WorldItems.Add(new AllItems(Loot_ID_Key, "Key")); // Keep in mind, object of AllItems (ID, Name)
        }

        /// <summary>
        /// Creating all the enemies and putting them in the WorldEnemies list
        /// </summary>
        private static void AddingEnemies()
        {
            Enemy Llama = new Enemy(Enemy_ID_Llama, "Llama", 3, 5, 6, 6); // (ID, name, maxDamage, experience gain, current health, total health)
            Llama.DropLoot.Add(new Loot(ItemID(Weapon_ID_Stone_Axe), false, 5)); // What the enemy can drop (ID, Name, important, DropChance)
            Llama.DropLoot.Add(new Loot(ItemID(Weapon_ID_GreatSword), false, 1)); // What the enemy can drop (ID, Name, important, DropChance)

            Enemy Ghoul = new Enemy(Enemy_ID_Ghoul, "Ghoul", 8, 20, 15, 15); // (ID, name, maxDamage, experience gain, current health, total health)
            Ghoul.DropLoot.Add(new Loot(ItemID(Weapon_ID_Stone_Axe), false, 40)); // What the enemy can drop (ID, Name, important, DropChance)
            Ghoul.DropLoot.Add(new Loot(ItemID(Weapon_ID_GreatSword), false, 20)); // What the enemy can drop (ID, Name, important, DropChance)

            Enemy Werewolf = new Enemy(Enemy_ID_WereWolf, "Werewolf", 5, 20, 14, 14); // (ID, name, maxDamage, experience gain, current health, total health)
            Werewolf.DropLoot.Add(new Loot(ItemID(Weapon_ID_Stone_Axe), false, 40)); // What the enemy can drop (ID, Name, important, DropChance)
            Werewolf.DropLoot.Add(new Loot(ItemID(Weapon_ID_GreatSword), false, 20)); // What the enemy can drop (ID, Name, important, DropChance)

            Enemy Snake = new Enemy(Enemy_ID_Snake, "Snake", 4, 10, 10, 10); // (ID, name, maxDamage, experience gain, current health, total health)
            Snake.DropLoot.Add(new Loot(ItemID(Weapon_ID_Stone_Axe), false, 30)); // What the enemy can drop (ID, Name, important, DropChance)
            Snake.DropLoot.Add(new Loot(ItemID(Weapon_ID_GreatSword), false, 15)); // What the enemy can drop (ID, Name, important, DropChance)

            Enemy Skeleton = new Enemy(Enemy_ID_Skeleton, "Skeleton", 13, 25, 25, 25); // (ID, name, maxDamage, experience gain, current health, total health)
            Skeleton.DropLoot.Add(new Loot(ItemID(Weapon_ID_Stone_Axe), false, 50)); // What the enemy can drop (ID, Name, important, DropChance)
            Skeleton.DropLoot.Add(new Loot(ItemID(Weapon_ID_GreatSword), false, 40)); // What the enemy can drop (ID, Name, important, DropChance)
            Skeleton.DropLoot.Add(new Loot(ItemID(Weapon_ID_BattleAxe), false, 5)); // What the enemy can drop (ID, Name, important, DropChance)

            Enemy Minitaur = new Enemy(Enemy_ID_Minitaur, "Minitaur", 20, 50, 30, 30); // (ID, name, maxDamage, experience gain, current health, total health)
            Minitaur.DropLoot.Add(new Loot(ItemID(Weapon_ID_BattleAxe), false, 80)); // What the enemy can drop (ID, Name, important, DropChance)
            Minitaur.DropLoot.Add(new Loot(ItemID(Loot_ID_Key), true, 100)); // What the enemy can drop (ID, Name, important, DropChance)
            
            Enemy Dragon = new Enemy(Enemy_ID_Dragon, "Dragon", 40, 0, 50, 50); // (ID, name, maxDamage, experience gain, current health, total health)

            WorldEnemies.Add(Llama);
            WorldEnemies.Add(Snake);
            WorldEnemies.Add(Werewolf);
            WorldEnemies.Add(Ghoul);
            WorldEnemies.Add(Skeleton);
            WorldEnemies.Add(Minitaur);
            WorldEnemies.Add(Dragon);
        }
        
        /// <summary>
        /// Creating all the locations and putting them in the Locations list
        /// </summary>
        private static void AddingLocation()
        {
            Location Start = new Location(Location_ID_Start, "Start", "Start of an adventure"); // (ID, Name, Description)

            Location Garden = new Location(Location_ID_Garden, "Garden", "Llamas everywhere!"); // (ID, Name, Description)
            Garden.RoomEnemy = EnemyID(Enemy_ID_Llama); // Enemy that will spawn in the room

            Location Grassland = new Location(Location_ID_GrassLand, "Grasslands", "No step on snek"); // (ID, Name, Description)
            Grassland.RoomEnemy = EnemyID(Enemy_ID_Snake); // Enemy that will spawn in the room

            Location Woods = new Location(Location_ID_Woods, "Woods", "I can hear them"); // (ID, Name, Description)
            Woods.RoomEnemy = EnemyID(Enemy_ID_WereWolf); // Enemy that will spawn in the room

            Location Clearing = new Location(Location_ID_Clearing, "Clearing", "What is that noise? Sounds like \"moo\""); // (ID, Name, Description)
            Clearing.RoomEnemy = EnemyID(Enemy_ID_Minitaur); // Enemy that will spawn in the room

            Location GraveYard = new Location(Location_ID_GraveYard, "Graveyard", "Rest in peace"); // (ID, Name, Description)
            GraveYard.RoomEnemy = EnemyID(Enemy_ID_Ghoul); // Enemy that will spawn in the room

            Location Crypt = new Location(Location_ID_Crypt, "Crypt", "I have a bone to pick with you"); // (ID, Name, Description)
            Crypt.RoomEnemy = EnemyID(Enemy_ID_Skeleton); // Enemy that will spawn in the room

            Location Cave = new Location(Location_ID_Cave, "Cave", "Oh look, shiny", ItemID(Loot_ID_Key)); // (ID, Name, Description, required key)
            Cave.RoomEnemy = EnemyID(Enemy_ID_Dragon); // Enemy that will spawn in the room

            Locations.Add(Start);
            Locations.Add(Garden);
            Locations.Add(Grassland);
            Locations.Add(Woods);
            Locations.Add(Clearing);
            Locations.Add(GraveYard);
            Locations.Add(Crypt);
            Locations.Add(Cave);

            // Making use of the direction properties so location knows what is to the right, left, up and down
            Start.Right = Garden;

            Garden.Right = Grassland;

            Grassland.Up = Woods;
            Grassland.Down = GraveYard;
            Grassland.Left = Garden;

            Woods.Right = Clearing;
            Woods.Down = Grassland;

            Clearing.Left = Woods;

            GraveYard.Up = Grassland;
            GraveYard.Right = Crypt;

            Crypt.Left = GraveYard;
            Crypt.Right = Cave;

            Cave.Left = Crypt;
        }

        /// <summary>
        /// Will return the enemy if id matches any enemy ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Enemy EnemyID(int id)
        {
            foreach(Enemy enemies in WorldEnemies)

                if(enemies.ID == id)
                {
                    return enemies;
                }
            return null;
        }

        /// <summary>
        /// Will return the item if id matches any item ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static AllItems ItemID(int id)
        {
            foreach (AllItems items in WorldItems)
            {
                if(items.ID == id)
                {
                    return items;
                }
            }
            return null;
        }

        /// <summary>
        /// Will return the location if id matches any location ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Location LocationID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CharlesDickensÄventyr
{
    public partial class CharlesÄventyr : Form
        ///<summary>
        /// Program: This is the visual part of the program, where all the functions are used to make a working game.
        /// 
        /// Programmers: Christopher Velander, Johan Danielsson, Patrik Hurtig
        /// 
        /// Date: 2018-03-21
        /// </summary>
    {
        private Character character;
        private Enemy enemy;

        /// <summary>
        /// Creating the character, adding what the character stats with and where the character is starting.
        /// </summary>
        public CharlesÄventyr()
        {
            InitializeComponent();

            character = new Character(0, 10, 10);
            character.Bag.Add(new Inventory(WorldEvents.ItemID(WorldEvents.Weapon_ID_Iron_Sword), 1));
            MoveChar(WorldEvents.LocationID(WorldEvents.Location_ID_Start));

            CharacterUpdate();
            exitCombat();
            atkButton.Visible = false;
        }

        /// <summary>
        /// This method will be called everytime a move is made to keep track of where the character is and what enemy will spawn.
        /// </summary>
        /// <param name="location"></param>
        private void MoveChar(Location location)
        {
            if (character.HasGotKey(location) == false)
            {
                gameTextBox.Text += "You need the " + location.RequiredKey.Name + " to enter this room \n";
                BottomMsg();
                return;
            }

            character.CharLocation = location;

            locationLabel.Text = location.Name;
            descLabel.Text = location.LokationsDesc;

            if (location.RoomEnemy != null)
            {
                gameTextBox.Text += "Prepare for battle! You have a " + location.RoomEnemy.Name + " incoming! \n";

                Enemy roomEnemy = WorldEvents.EnemyID(location.RoomEnemy.ID);

                enemy = new Enemy(roomEnemy.ID, roomEnemy.Name, roomEnemy.Damage, roomEnemy.GivenExp, roomEnemy.Health, roomEnemy.TotalHealth);

                foreach (Loot droppedLoot in roomEnemy.DropLoot) // Ooh, the enemy will drop loot.
                {
                    enemy.DropLoot.Add(droppedLoot);
                }
            }

            CharacterUpdate();

            GearUpdate();
            Map();
            BottomMsg();
        }

        /// <summary>
        /// Method to update character information
        /// </summary>
        private void CharacterUpdate()
        {
            healthLabel.Text = character.CurrentHealth.ToString();
            levelLabel.Text = character.Level().ToString();

            foreach (Inventory item in character.Bag) // Will check bag if character pick up the key required to face the final boss
            {
                if (item.Items.ID == WorldEvents.Loot_ID_Key)
                {
                    keyLabel.Visible = true;
                }
            }
        }

        /// <summary>
        /// This function is used for displaying the map, it was a quick fix with 8 different pictures to display where character is mapwise
        /// </summary>
        private void Map()
        {
            if (character.CharLocation.ID == WorldEvents.Location_ID_Start)
            {
                startPic.Visible = true;
                gardenPic.Visible = false;
                grassPic.Visible = false;
                woodsPic.Visible = false;
                clearPic.Visible = false;
                gravePic.Visible = false;
                cryptPic.Visible = false;
                cavePic.Visible = false;
            }
            else if (character.CharLocation.ID == WorldEvents.Location_ID_Garden)
            {
                startPic.Visible = false;
                gardenPic.Visible = true;
                grassPic.Visible = false;
                woodsPic.Visible = false;
                clearPic.Visible = false;
                gravePic.Visible = false;
                cryptPic.Visible = false;
                cavePic.Visible = false;
            }
            else if (character.CharLocation.ID == WorldEvents.Location_ID_GrassLand)
            {
                startPic.Visible = false;
                gardenPic.Visible = false;
                grassPic.Visible = true;
                woodsPic.Visible = false;
                clearPic.Visible = false;
                gravePic.Visible = false;
                cryptPic.Visible = false;
                cavePic.Visible = false;
            }
            else if (character.CharLocation.ID == WorldEvents.Location_ID_Woods)
            {
                startPic.Visible = false; ;
                gardenPic.Visible = false;
                grassPic.Visible = false;
                woodsPic.Visible = true;
                clearPic.Visible = false;
                gravePic.Visible = false;
                cryptPic.Visible = false;
                cavePic.Visible = false;
            }
            else if (character.CharLocation.ID == WorldEvents.Location_ID_Clearing)
            {
                startPic.Visible = false;
                gardenPic.Visible = false;
                grassPic.Visible = false;
                woodsPic.Visible = false;
                clearPic.Visible = true;
                gravePic.Visible = false;
                cryptPic.Visible = false;
                cavePic.Visible = false;
            }
            else if (character.CharLocation.ID == WorldEvents.Location_ID_GraveYard)
            {
                startPic.Visible = false;
                gardenPic.Visible = false;
                grassPic.Visible = false;
                woodsPic.Visible = false;
                clearPic.Visible = false;
                gravePic.Visible = true;
                cryptPic.Visible = false;
                cavePic.Visible = false;
            }
            else if (character.CharLocation.ID == WorldEvents.Location_ID_Crypt)
            {
                startPic.Visible = false;
                gardenPic.Visible = false;
                grassPic.Visible = false;
                woodsPic.Visible = false;
                clearPic.Visible = false;
                gravePic.Visible = false;
                cryptPic.Visible = true;
                cavePic.Visible = false;
            }
            else
            {
                startPic.Visible = false;
                gardenPic.Visible = false;
                grassPic.Visible = false;
                woodsPic.Visible = false;
                clearPic.Visible = false;
                gravePic.Visible = false;
                cryptPic.Visible = false;
                cavePic.Visible = true;
            }
        }

        /// <summary>
        /// Smoothness is always nice right? This method will scroll down to the bottom of the richtextbox
        /// </summary>
        private void BottomMsg()
        {
            gameTextBox.SelectionStart = gameTextBox.Text.Length;
            gameTextBox.ScrollToCaret();
        }

        /// <summary>
        /// Speaks for itself?
        /// </summary>
        private void TheEnd()
        {
            MessageBox.Show("Eey, you completed the game. You do not have to git gud. GG");


            Application.Exit();
        }

        /// <summary>
        /// Updates the gear the character picks up, gear is mostly specified for weapons
        /// </summary>
        private void GearUpdate()
        {
            List<Gear> weapons = new List<Gear>();

            foreach (Inventory inventory in character.Bag)
            {
                if (inventory.Items is Gear)
                {
                    if (inventory.Amount > 0)
                    {
                        weapons.Add((Gear)inventory.Items);
                    }
                }
            }

            gearCombo.DataSource = weapons;
            gearCombo.DisplayMember = "Name";
        }

        /// <summary>
        /// Speaks for itself?
        /// </summary>
        private void EnterCombat()
        {
            rightButton.Visible = false;
            leftButton.Visible = false;
            upButton.Visible = false;
            downButton.Visible = false;
            enemyHealthText.Visible = true;
        }

        /// <summary>
        /// Speaks for itself?
        /// </summary>
        private void exitCombat()
        {
            rightButton.Visible = (character.CharLocation.Right != null); // Will make the button visible if path available
            leftButton.Visible = (character.CharLocation.Left != null);
            upButton.Visible = (character.CharLocation.Up != null);
            downButton.Visible = (character.CharLocation.Down != null);
            enemyHealth.Visible = false;
            enemyHealthText.Visible = false;
        }

        /// <summary>
        /// Want to go up?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upButton_Click(object sender, EventArgs e)
        {
            EnterCombat();
            MoveChar(character.CharLocation.Up);
            enemyHealth.Text = enemy.Health.ToString();
            atkButton.Visible = true;
            enemyHealth.Visible = true;
        }

        /// <summary>
        /// They say girls are always right..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightButton_Click(object sender, EventArgs e)
        {
            EnterCombat();
            MoveChar(character.CharLocation.Right);
            enemyHealth.Text = enemy.Health.ToString();
            atkButton.Visible = true;
            enemyHealth.Visible = true;
        }

        /// <summary>
        /// Come from a land down under?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downButton_Click(object sender, EventArgs e)
        {
            EnterCombat();
            MoveChar(character.CharLocation.Down);
            enemyHealth.Text = enemy.Health.ToString();
            atkButton.Visible = true;
            enemyHealth.Visible = true;
        }

        /// <summary>
        /// To the left to the left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftButton_Click(object sender, EventArgs e)
        {
            EnterCombat();
            MoveChar(character.CharLocation.Left);
            enemyHealth.Text = enemy.Health.ToString();
            atkButton.Visible = true;
            enemyHealth.Visible = true;
        }

        /// <summary>
        /// When entering combat you will be allowed to attack, this method will help you
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void atkButton_Click(object sender, EventArgs e)
        {
            Gear weapon = (Gear)gearCombo.SelectedItem; // weapon will take the selected weapon from the ComboBox

            int damageDone = Randomizer.Numbers(weapon.MinDmg, weapon.MaxDmg); // Using the randomize function of getting 2 numbers

            enemy.Health -= damageDone; // Lowering Health based upon the randomized damage

            enemyHealth.Text = enemy.Health.ToString();
            gameTextBox.Text += "You attacked the enemy for " + damageDone + " damage! \n";

            if (enemy.Health <= 0) // You are a champion
            {
                List<Inventory> droppedLoot = new List<Inventory>();

                gameTextBox.Text += "\nYou have defeated the " + enemy.Name + "\n";

                character.HealthPerLevel(enemy.GivenExp); //Calls the character method to increase experience

                if (character.CurrentHealth < character.TotalHealth) //I have heard that drinking blood is good for you
                {
                    character.CurrentHealth += 5;

                    if (character.CurrentHealth > character.TotalHealth) //Stops the character from gaining more health than total
                    {
                        character.CurrentHealth = character.TotalHealth;
                    }
                    gameTextBox.Text += "You siphoned some health from the enemy \n";
                }

                foreach(Loot enemyDrop in enemy.DropLoot) //Foreach loop so you can get some juicy items
                {
                    if (Randomizer.Numbers(1, 100) <= enemyDrop.DropChance) //Feeling lucky?
                    {
                        droppedLoot.Add(new Inventory(enemyDrop.Item, 1)); //Lady luck in action
                    }
                }

                foreach (Inventory inventory in droppedLoot) //Now we have to move that item to your characters bag
                {
                    character.AddItem(inventory.Items); //Wanna buy some memes?

                    gameTextBox.Text += "You looted " + inventory.Items.Name + " from " + enemy.Name + "\n";
                }

                CharacterUpdate();
                GearUpdate();

                enemyHealth.Visible = false;
                atkButton.Visible = false;
                exitCombat();
                
                if (character.CharLocation.ID == WorldEvents.Location_ID_Cave) //Did you kill the enemy in the cave?
                {
                    TheEnd(); //You won the game? Amazing
                }
            }
            else
            {
                int takenDmg = Randomizer.Numbers(0, enemy.Damage); //How much will the enemy hit you for?

                character.CurrentHealth -= takenDmg;

                healthLabel.Text = character.CurrentHealth.ToString();

                gameTextBox.Text += "The " + enemy.Name + " hit you for " + takenDmg + "\n";

                if (character.CurrentHealth <= 0) //Git gud
                {
                    MessageBox.Show("You have been eliminated by " + enemy.Name + " rest in peace, press OK to exit");

                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            BottomMsg();
        }
    }
}

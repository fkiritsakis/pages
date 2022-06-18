using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Windows_Forms_Simple_RPG.Scripts
{
    class Entity
    {

        private string name;

        private int health;
        private int strength;
        private int defense;


        Random random = new Random();
        


        //Taking Damage
        public void takeDamage(Entity Attacker) 
        {
            int damageAmount;

            //Creating a damage amount based on the attacker's Strength Stat and a random number from 0 to defender's Defense Stat
            damageAmount = Attacker.getStrength() - random.Next(defense + 1);

            health -= damageAmount;
        }

        //Check if Entity is Alive
        public bool isAlive() 
        {
            if (health > 0)
                return true;
            else
                return false;
        }


        //Get & Set
        public string getName() 
        {
            return name;
        }

        public void setName(string newName) 
        {
            name = newName;
        }
        public int getHealth() 
        {
            return health;
        }

        public void setHealth(int newHealth) 
        {
            health = newHealth;
        }

        public int getStrength() 
        {
            return strength;
        }

        public void setStrength(int amount) 
        {
            strength = amount;
        }

        public int getDefense() 
        {
            return defense;
        }

        public void setDefense(int amount) 
        {
            defense = amount;
        }
    }
}

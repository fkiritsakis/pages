using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Simple_RPG.Scripts
{
    class Enemy : Entity
    {


        public Enemy()
        {
            this.setName("Encoder");
            this.setHealth(50);
            this.setStrength(15);
            this.setDefense(10);
        }

        public Enemy(string name, int health, int strength, int defense) 
        {
            this.setName(name);
            this.setHealth(health);
            this.setStrength(strength);
            this.setDefense(defense);
        }

        //public Enemy generateEnemy(EnemyType enemyType) 
        //{
            
        //    Enemy generatedEnemy;

        //    int test = 5;

            

        //    switch (enemyType) 
        //    {
        //        case EnemyType.Orc:
        //            generatedEnemy = new Enemy("Orc", 40, 12, 5);
        //            break;
        //        case EnemyType.Zombie:
        //            generatedEnemy = new Enemy("Ghoul", 30, 5, 5);
        //            break;
        //        default:
        //            //If the switch case defaults, it returns a default enemy named Encoder
        //            return generatedEnemy = new Enemy();
        //    }


            

        //    return generatedEnemy;
        //}

        
    }
}

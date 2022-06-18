using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Simple_RPG.Scripts
{
    class EnemyTypes
    {
        List<Enemy> enemyTypes = new List<Enemy>();
        Random random = new Random();

        public EnemyTypes() 
        {
            enemyTypes.Add(new Enemy("Orc", 40, 10, 5));
            enemyTypes.Add(new Enemy("Zombie", 25, 5, 2));
            enemyTypes.Add(new Enemy("Ghoul", 20, 2, 2));
            enemyTypes.Add(new Enemy("Vampire", 50, 15, 8));
        }

        //Returns an enemy from the list
        public Enemy getEnemy()
        {
            return enemyTypes[random.Next(enemyTypes.Count)]; //Returns a random enemy within the range of the enemyTypes List
        }

        //Enumerator of all enemy types
        public enum EnemyType
        {
            Orc,               // 0
            Zombie,            // 1
            Ghoul,             // 2
            Vampire,           // ...
            Striga,            // ... 
            Rusalka,
            Sleep_Demon,
            Hellhound
        }

    }
}

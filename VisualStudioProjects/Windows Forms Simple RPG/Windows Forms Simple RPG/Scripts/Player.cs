using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Simple_RPG.Scripts
{
    class Player : Entity
    {
        public Player() 
        {
            //Setting the starting stats for the player
            this.setHealth(100);
            this.setStrength(10);
            this.setDefense(5);

        }
    }
}

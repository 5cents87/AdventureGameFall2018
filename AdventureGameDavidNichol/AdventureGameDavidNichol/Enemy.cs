using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameDavidNichol
{
    public class Enemy
    {
        //Enemy NPC health
        public int hitpoints;
        //Enemy's damage
        public int enemyDamage;
        //Creates the enemy object
        public static Enemy ork1 = new Enemy();
        //Default enemy constructor
        public Enemy()
        {
            //Enemy health and damage variables
            hitpoints = 100;
            enemyDamage = 0;

        }

        

    }
}

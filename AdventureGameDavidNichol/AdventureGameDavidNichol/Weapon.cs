using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameDavidNichol
{
    public class Weapon
    {
        //Character's weapon damage
        public int damage;                
        //Used to determine critical strike
        private int random;


        //Create our method to determine character's current weapon
        public int GetWeapon()
        {
           
            //Sets character damage based on equipped weapon
            if (Character.myChar1.weapon == "pistol")
            {
                damage = 50;
                return damage;
            }
            else 
            {
                damage = 80;
                return damage;
            }
              
       
        }
        //Calculates total damage including a critical strike if there is one
        public int TotalDamage()
        {
            Game g = new Game();
            //Special thanks to stackoverflow.com user Guffa for helping me create the random number generator.
            Random r = new Random();
            //Finds a random number between 1 and 10
            random = r.Next(1, 11);
            //Finds current damage
            int totalDMG = GetWeapon();
            //3/10 chance to deliver a critical strike
            if (random == 1 || random == 2 || random == 3)             
            {
                //Adds critical strike damage to damage, otherwise returns normal damage
                Console.WriteLine("\nCritical hit!\n");
                return  totalDMG *= 2;
               
            }
            else
            {
                return damage;
            }
            
        }
    }
}

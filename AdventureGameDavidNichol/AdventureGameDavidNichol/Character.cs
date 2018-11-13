using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameDavidNichol
{
    
        public class Character
        {  
            //Character's health
            public int hitpoints;
            //Character's name
            public string name;
            //Character's weapon
            public string weapon;
            //Character's armor
            public string armor;
            //Creates the character object
            public static Character myChar1 = new Character();
            
            //Default character constructor
            public Character()
            {
                //Character variables
                name = "";                
                hitpoints = 100;
                weapon = "";
                armor = "";

            }            
        }
    }




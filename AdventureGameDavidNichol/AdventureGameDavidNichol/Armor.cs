using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameDavidNichol
{   
    public class Armor
    {        
        //Sets armor values
        public int getArmor()
        {
           //Applys character health bonuses based on equipped armor
            if (Character.myChar1.armor == "leather")
            {
                return Character.myChar1.hitpoints += 20;
                
            }
            else 
            {
                return Character.myChar1.hitpoints += 25;
            }
            

        }
    }
}

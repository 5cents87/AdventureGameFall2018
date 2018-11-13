using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameDavidNichol
{
    public class Game
    {
        //Determines if the character strikes first.
        private bool charInitiative;
        //Creates the character's weapon
        Weapon weapon1 = new Weapon();
        //The variable used to run the game in the program class
        public static Game adventure = new Game();
        //Create the game menu            
        public void Menu()
        { 
            //Sets text forground color to white
            Console.ForegroundColor = ConsoleColor.White;
            //Sets text background color to dark red
            Console.BackgroundColor = ConsoleColor.DarkRed;
            //Title
            Console.WriteLine("\n\n\n\n\n\n\n                 SPACE PRISONER\n");
            //Menu options
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n\n\n                                [1] PLAY GAME\n");
            Console.WriteLine("\n                                [2] SEE CREDITS\n");
            Console.WriteLine("\n                                [3] EXIT\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void Run()
        {
            //Loop to keep the game running
            bool appRunning = true;

            while (appRunning)
            {
                //Executes menu selection
                Menu();
                int menuSelection = Convert.ToInt16(Console.ReadLine());
                switch (menuSelection)
                {  
                    //If 1, launch game
                    case 1:
                        PlayGame1();
                        Console.ReadLine();
                        break;
                    //If 2, launch credits
                    case 2:
                        Credits();                       
                        break;
                   //If 3, exit application
                    case 3:
                        Exit();
                        Console.ReadLine();
                        break;
                   //Otherwise, return error message
                    default:
                        Console.WriteLine("You did not provide a valid argument!");
                        Console.ReadLine();
                        break;
                }
            }
        }
        //First narrative segment
        private void PlayGame1()
        {
            //Clear the console window
            Console.Clear();
            //Set the font color 
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nThe year is 2188.         (press any key to continue)\n");
            Console.ReadKey();
            Console.Write("\nYou are being held captive by ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Space Orks ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("on a large freighter space ship.\n");
            Console.ReadKey();
            Console.WriteLine("Your choices will decide you fate.\n");
            Console.ReadKey();
            Console.WriteLine("What is your name?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Stores user input into charName object
            string charName = Console.ReadLine();
            Character.myChar1.name = charName;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Welcome to space, ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Displays user input
            Console.WriteLine(charName + ".\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You wake up in your cell as usual, although this time something seems a bit");
            Console.WriteLine("odd. There is a sizeable tear in your cell's wall...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Suddenly, you hear a voice.\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Come with me, ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(charName + "...\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You follow the voice through the hole into a long corridor.\n");
            Console.ReadKey();
            Console.WriteLine("\nIn front of you, a pistol sits next to a skeleton.\n");
            Console.ReadKey();
            Console.WriteLine("\nDo you wish to pick it up?\n");
            Console.ForegroundColor = ConsoleColor.Green;
            //First user branching choice, 1 to pick up the gun and 2 to leave it
            Console.WriteLine("[1] YES\n");
            Console.ForegroundColor = ConsoleColor.Red;            
            Console.WriteLine("[2] NO");
            Console.ForegroundColor = ConsoleColor.White;
            //Stores user input into pistolCheck
            int pistolCheck = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            //If user selects 1, equip pistol
            if (pistolCheck == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Pistol equipped.\n");
                //Updates character weapon
                Character.myChar1.weapon = "pistol";
                //Launches next narrative segment
                PlayGame2();

            }
            //If user decides to leave the gun, continue to the next narrative segement
            else
            {
                PlayGame2();
            }

            Console.ReadLine();
        }
        //Second narrative segment
        private void PlayGame2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You continue down the corridor.\n");
            Console.ReadKey();
            Console.Write("You see a lone ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Space Ork");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" who's back is turned.\n");
            Console.ReadKey();
            //If character has the pistol, present with a branching decision
            if (Character.myChar1.weapon == "pistol")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                //1 to shoot the ork, 2 to not shoot it
                Console.WriteLine("\n[1] SHOOT\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[2] SPARE\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Stores user input into killOrSpare
                int killOrSpare = Convert.ToInt16(Console.ReadLine());
                //If user kills the ork, display text restating it
                if (killOrSpare == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nYou shoot the");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" Ork ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("in the head and kill it.\n");
                    Console.ReadKey();
                    //Character armor updated into leather
                    Console.WriteLine("You take its leather armor.");
                    Character.myChar1.armor = "leather";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Leather armor equipped!\n");
                    PlayGame3();

                }
                //If user spares the ork, launch GameOver();
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nYou step on a piece of glass and the");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" Ork");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" shoots you in the face.");
                    GameOver();
                }
            }
            //If character didn't equip the pistol, launch GameOver();
            else
            {
                Console.Write("\nYou step on a piece of glass and the");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" Ork");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" shoots you in the face.");
                GameOver();               
            }
        }
        //Third narrative segment
        private void PlayGame3()
        {
            //Sets the ork NPC damage
            Enemy.ork1.enemyDamage = 40;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Hearing the shot, another");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Ork");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" runs into the corridor charging you with a spear.\n");
            Console.ReadKey();
            Console.Write("You shoot the ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Ork");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" as he is running at you.\n\n");
            Console.ReadKey();
            //Determines if the character attacks first
            charInitiative = true;
            //Launches Fight method
            Fight();
            //Displays character health
            Console.Write("Your hitpoints: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(Character.myChar1.hitpoints + "\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nYou take its armor.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Updates character armor to chain mail
            Console.WriteLine("Chain mail equipped.\n");          
            Character.myChar1.armor = "chain";
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("You continue down the long corridor until you stumble upon the ship's armory.\n");
            Console.ReadKey();
            Console.Write("\nYou find a rifle with ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("bullets.\n");
            //Updates character weapon to rifle
            Character.myChar1.weapon = "rifle";
            Console.ReadKey();
            Console.WriteLine("\nInside the armory, a beautifully engraved double door reveals a mysterious room.\n");
            Console.ReadKey();
            Console.WriteLine("\nYou hesitate... but decide to enter anyway.\n");
            Console.ReadKey();
            Console.WriteLine("\nImmediately, your feet lift off the ground and you can feel yourself getting\n");
            Console.WriteLine("lighter...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n                                   Suddenly,");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n  WELCOME TO THE ANTI GRAVITY CHAMBER, ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Displays character name
            Console.WriteLine(Character.myChar1.name + "...\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("             ______       ");
            Console.WriteLine(@"            /_.  ._\      ");
            Console.WriteLine(@"           (( \\// ))     ");
            Console.WriteLine(@"            \\ \/ //      ");
            Console.WriteLine(@"             \\/\//       ");
            Console.WriteLine(@"        \\\  ( '' )   ///  ");
            Console.WriteLine(@"        )))   \__/    (((   ");
            Console.WriteLine("       (((.'___||___ '.)))  ");
            Console.WriteLine(@"        \\  )      (  //   ");
            Console.WriteLine(@"         \\/.'    '.\//    ");
            Console.WriteLine(@"          \/  |,,|  \/     ");
            Console.WriteLine("              |  |        ");
            Console.WriteLine("              |  |        ");
            Console.WriteLine(@"             / /\ \        ");
            Console.WriteLine(@"            / /  \ \      ");
            Console.WriteLine("            ||    ||      ");
            Console.WriteLine("            ||    ||      ");
            Console.WriteLine("            ||    ||      ");
            Console.WriteLine("         ___))    ((___   ");
            Console.WriteLine("        (____)    (____)  ");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nIT IS I, ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("FANGWANG THE GREAT");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("!\n");
            Console.ReadKey();
            Console.WriteLine("\nBefore you can react, the alien shoots a laser at you from it's eyes.\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Removes character's armor
            Console.WriteLine(Character.myChar1.armor + " mail has been destroyed!\n");
            Character.myChar1.armor = "";
            Console.ForegroundColor = ConsoleColor.White;
            //Displays character health
            Console.Write("\nYour hitpoints: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(Character.myChar1.hitpoints - 50 + "\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nYou quickly draw your rife, firing two shots.\n");
            Console.ReadKey();
            Console.WriteLine("\nThe first shot misses.\n");
            Console.ReadKey();
            Console.WriteLine("\nThe second misses.\n");
            Console.ReadKey();
            Console.WriteLine("\nOut of the corner of your eye, you spot the core of the freight ship.");
            Console.ReadKey();
            Console.WriteLine("\nShooting it will assuredly destroy the ship and everything inside.\n");
            Console.ReadKey();
            //1 to destroy the ship's core, 2 to kill the final boss
            Console.WriteLine("\n[1] DESTROY CORE\n");
            Console.WriteLine("[2] KILL FANGWANG\n");
            //Stores user input
            int gameEnd = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            //If user choses 1, launch ending 1
            if (gameEnd == 1)
            {
                Ending1();
            }
            //Otherwise, launch ending 2
            if(gameEnd == 2)
            {
                Ending2();
            }
            
        }
        //First ending
        private void Ending1()
        {
            Console.WriteLine("You fire your last bullet at the core, causing a nuclear explosion.");
            Console.ReadKey();           
            Console.Write("The ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("ISPC ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(Intergalactic Space Peace Committee)");
            Console.WriteLine("has recognized you as a hero in the intergalactic hall of fame.");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n                                   FIN ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            //Launches credits
            Credits();
            
        }
        //Second ending
       private void Ending2()
        {
            Console.WriteLine("The final bullet hits Fangwang in his head, killing him instantly.");
            Console.ReadKey();           
            Console.WriteLine("You exit the ship using Fangwang's escape pod.");
            Console.ReadKey();
            Console.WriteLine("When you return to Earth you are awarded the 2188 Nobel Peace Prize.");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n                                  FIN ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            //Launches credits
            Credits();
            
        }
        //Game credits
        private void Credits()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("CREDITS\n");
            Console.WriteLine("\nThe three variables that affected gameplay are:");
            Console.WriteLine("\npistolCheck, gameEnd and killOrSpare\n");
            Console.WriteLine("\nGame Design: David Nichol\n");
            Console.WriteLine("\nCode Writing: David Nichol\n");
            Console.WriteLine("\nSpecial thanks to stackoverflow.com user Guffa\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\nDesigned by IAM 2018\n");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        //Exits the application
        private void Exit()
        {
            Environment.Exit(0);
        }
        //Displayed if the character dies
        public void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;            
            
            Console.WriteLine("                           __ _  __ _ _ __ ___   ___       ___ __   __ ___  __ __   ");
            Console.WriteLine(@"          / _` |/ _` | '_ ` _ \ / _ \     / _ \\ \ / // _ \|  '__|  ");
            Console.WriteLine(@"         | (_| | (_| | | | | | |  __/    | (_) |\ V /|  __/|  |     ");
            Console.WriteLine(@"          \__, |\__,_|_| |_| |_|\___|     \___/  \_/  \___||__|     ");
            Console.WriteLine("           __/ |                                                    ");
            Console.WriteLine("          |___/                                                     ");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        //Used to battle the character against an NPC
        public void Fight()
        {
            //Stores player's damage
            int dmgPlayer = weapon1.TotalDamage();
            //Stores enemy's damage
            int dmgEnemy = Enemy.ork1.enemyDamage;
            //If character attacks first, launch for loop
            if (charInitiative)
            {
                //Turn counter for the fight
                for (int i = 0; i < (Character.myChar1.hitpoints / dmgEnemy); i++)
                {
                    //Runs while both fighters are alive
                    while (Enemy.ork1.hitpoints > 0 && Character.myChar1.hitpoints > 0)
                    {
                        //Character's first turn
                        if (i == 0)
                        {
                            Enemy.ork1.hitpoints -= dmgPlayer;
                            Console.WriteLine("You hit your enemy for " + dmgPlayer + " damage.\n");
                            //If enemy dies, display this message
                            if (Enemy.ork1.hitpoints == 0)
                            {
                                Console.WriteLine("You have slain your enemy!");


                            }
                            Console.ReadKey();
                            //Increments counter
                            i++;

                        }
                        //Enemy's first turn
                        else if (i == 1)
                        {
                            Character.myChar1.hitpoints -= dmgEnemy;
                            Console.WriteLine("Your enemy hit you for " + dmgEnemy + " damage.\n");
                            //If character dies, display message and launch GameOver();
                            if (Character.myChar1.hitpoints == 0)
                            {
                                Console.WriteLine("You died!");
                                GameOver();
                            }
                            Console.ReadKey();
                            i++;

                        }
                        //Character turn 2
                        else if (i == 2)
                        {
                            Enemy.ork1.hitpoints -= dmgPlayer;
                            Console.WriteLine("You hit your enemy for " + dmgPlayer + " damage.\n");
                            if (Enemy.ork1.hitpoints == 0)
                            {
                                Console.WriteLine("You have slain your enemy!");

                            }
                            Console.ReadKey();
                            i++;

                        }
                        //Enemy turn 1
                        else if (i == 3)
                        {
                            Character.myChar1.hitpoints -= dmgEnemy;
                            Console.WriteLine("Your enemy hit you for " + dmgEnemy + " damage.\n");
                            if (Character.myChar1.hitpoints == 0)
                            {
                                Console.WriteLine("You died!");
                                GameOver();
                            }
                            Console.ReadKey();
                            i++;

                        }
                        //Character turn 3
                        else if (i == 4)
                        {
                            Enemy.ork1.hitpoints -= dmgPlayer;
                            Console.WriteLine("You hit your enemy for " + dmgPlayer + " damage.\n");
                            if (Enemy.ork1.hitpoints == 0)
                            {
                                Console.WriteLine("You have slain your enemy!");

                            }
                            Console.ReadKey();
                            i++;

                        }
                        //Enemy turn 3
                        else if (i == 5)
                        {
                            Character.myChar1.hitpoints -= dmgEnemy;
                            Console.WriteLine("Your enemy hit you for " + dmgEnemy + " damage\n");
                            if (Character.myChar1.hitpoints == 0)
                            {
                                Console.WriteLine("You died!");
                                GameOver();
                            }
                            Console.ReadKey();
                            i++;

                        }

                    }
                }
            }
            //If Enemy attacks first, launch this segement
            else
            {
                //Turn counter 
                for (int i = 0; i < (Character.myChar1.hitpoints / dmgEnemy); i++)
                {
                    //Runs while character and enemy are alive
                    while (Enemy.ork1.hitpoints > 0 && Character.myChar1.hitpoints > 0)
                    {
                        //Enemy's first turn
                        if (i == 0)
                        {
                            Character.myChar1.hitpoints -= dmgEnemy;
                            Console.WriteLine("Your enemy hit you for " + dmgEnemy + " damage.\n");
                            Console.ReadKey();
                            if (Character.myChar1.hitpoints == 0)
                            {
                                Console.WriteLine("You died!");
                                GameOver();
                            }
                            i++;

                        }
                        //Character's first turn
                        else if (i == 1)
                        {

                            Enemy.ork1.hitpoints -= dmgPlayer;
                            Console.WriteLine("You hit your enemy for " + dmgPlayer + " damage.\n");
                            Console.ReadKey();
                            if (Enemy.ork1.hitpoints == 0)
                            {
                                Console.WriteLine("You have slain your enemy!");


                            }
                            i++;

                        }
                        //Enemy's second turn
                        else if (i == 2)
                        {
                            Character.myChar1.hitpoints -= dmgEnemy;
                            Console.WriteLine("Your enemy hit you for " + dmgEnemy + " damage.\n");
                            Console.ReadKey();
                            if (Character.myChar1.hitpoints == 0)
                            {
                                Console.WriteLine("You died!");
                                GameOver();
                            }
                            i++;

                        }
                        //Character's second turn
                        else if (i == 3)
                        {
                            Enemy.ork1.hitpoints -= dmgPlayer;
                            Console.WriteLine("You hit your enemy for " + dmgPlayer + " damage.\n");
                            Console.ReadKey();
                            if (Enemy.ork1.hitpoints == 0)
                            {
                                Console.WriteLine("You have slain your enemy!");


                            }
                            i++;

                        }
                        //Enemy's third turn
                        else if (i == 4)
                        {
                            Character.myChar1.hitpoints -= dmgEnemy;
                            Console.WriteLine("Your enemy hit you for " + dmgEnemy + " damage.\n");
                            Console.ReadKey();
                            if (Character.myChar1.hitpoints == 0)
                            {
                                Console.WriteLine("You died!");
                                GameOver();
                            }
                            i++;

                        }
                        //Character's third turn
                        else if (i == 5)
                        {
                            Enemy.ork1.hitpoints -= dmgPlayer;
                            Console.WriteLine("You hit your enemy for " + dmgPlayer + " damage.\n");
                            Console.ReadKey();
                            if (Enemy.ork1.hitpoints == 0)
                            {
                                Console.WriteLine("You have slain your enemy!");


                            }
                            i++;

                        }

                    }
                }
            }
        }

    }
}




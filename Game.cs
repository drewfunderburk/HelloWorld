using System;

namespace HelloWorld
{
    class Game
    {
            string name, motto;
            float maxHealth = 100;
            float playerHealth = 100;
            float playerDamage = 10;
            float enemyHealth = 100;
            float enemyDamage = 5;
            int maxLevel = 100;
            int level = 1;
            string role = "none";
            bool dead = false;
        void PrintStats()
        {
            Console.WriteLine("Name:   " + name);
            Console.WriteLine("Motto:  " + motto);
            Console.WriteLine("Role:   " + role);
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Damage: " + playerDamage);
            Console.WriteLine("Level:  " + level + "\n\n");
        }

        void DoStrangeBeverage()
        {
            Console.WriteLine("You've been approached by a mysterious traveler.");
            Console.WriteLine("They offer you a strange beverage");
            Console.WriteLine("Do you accept?");
            Console.WriteLine("Press 1 for yes.");
            Console.WriteLine("Press 2 for no.");

            while (true)
            {
                char input = Console.ReadKey().KeyChar;

                if (input == '1')
                {
                    playerHealth = 10;
                    playerDamage = 500;
                    Console.WriteLine("\nYou feel an intense rage boil through you!");
                    Console.WriteLine("Health: " + playerHealth);
                    Console.WriteLine("Damage: " + playerDamage);

                    break;
                }
                else if (input == '2')
                {
                    Console.WriteLine("The stranger scoffs and slinks off into the shadows.");

                    break;
                }
                else
                {
                    Console.WriteLine("\nThat Input is not recognized! Try again!");
                }
            }
        }

        void DoBattle()
        {
            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("It's a fight!\n");
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("Player Damage: " + playerDamage);
                Console.WriteLine("Enemy Health:  " + enemyHealth);
                Console.WriteLine("Enemy Damage:  " + enemyDamage);
                Console.WriteLine("\n");
                Console.WriteLine("Press 1 to Attack!");

                while (true)
                {
                    char input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        Console.WriteLine("You deal " + playerDamage + " damage!");
                        Console.WriteLine("You take " + enemyDamage + " damage!");
                        playerHealth -= enemyDamage;
                        enemyHealth -= playerDamage;
                        if (enemyHealth < 0)
                            enemyHealth = 0;
                        break;
                    }
                    else
                    {
                        Console.Write("Press 1 to Attack!");
                    }
                }

                if (enemyHealth < 1)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else if (playerHealth < 1)
                {
                    Console.WriteLine("You died!");
                    break;
                }
            }
        }

        void DoRiddle()
        {
            int tries = 5;
            Console.WriteLine("Another, completely different stranger approaches you and asks you a question...");
            Console.WriteLine("\nIf all Trimps are Tramps, and all Tramps are Trumps, then all Trimps are deffinitely Trumps. True or false?");
            Console.WriteLine("Press T for true.");
            Console.WriteLine("Press F for false.");
            while (tries >= 0)
            {
                Console.WriteLine("You have " + tries + " tries left!");
                char input = Console.ReadKey().KeyChar;
                if (input == 't')
                {
                    Console.WriteLine("The stranger cackles and holds up a finger.");
                    Console.WriteLine("You have chosen... wisely.");
                    Console.WriteLine("With a shambling step, the stranger hobbles away into the distance.");
                    Console.WriteLine("You feel a rejuvenating power come over you!");
                    playerHealth = maxHealth;
                    Console.WriteLine("Player Health: " + playerHealth);
                    break;
                }
                else if (input == 'f')
                {
                    Console.WriteLine("The stranger cackles and holds up a finger.");
                    Console.WriteLine("You have chosen... poorly.");
                    Console.WriteLine("With a shambling step, the stranger hobbles away into the distance.");
                    Console.WriteLine("You feel yourself withering away...");
                    playerHealth *= 0.5f;
                    Console.WriteLine("Player Health: " + playerHealth);
                    tries--;
                    break;
                }
            }
        }

        public void Run()
        {



            Console.WriteLine("-------------------------------------");

            // Prompt for name
            Console.Write("Greetings! What is your name?> ");
            name = Console.ReadLine();

            // Prompt for motto
            Console.WriteLine("\nThat's a spectacular name, " + name + "!");
            Console.WriteLine("I'm curious though...");
            Console.Write("What words do you live your life by? What is your motto?> ");
            motto = Console.ReadLine();

            // Prompt for role
            Console.WriteLine("\nWise words indeed!");
            Console.WriteLine("Please select a role:");
            Console.WriteLine("Press 1 for Knight");
            Console.WriteLine("Press 2 for Wizard");

            // Get keyChar input and assign class
            while(true)
            {
                char roleInput = Console.ReadKey().KeyChar;
                if (roleInput == '1')
                {
                    role = "Knight";
                    maxHealth *= 2;
                    playerHealth = maxHealth;

                    break;
                }
                else if (roleInput == '2')
                {
                    role = "Wizard";
                    playerDamage *= 2;

                    break;
                }
                else
                {
                    Console.WriteLine("\nThat Input is not recognized! Try again!");
                }
            }

            // Print stats
            Console.WriteLine("\n\nWonderful! Here are your stats!\n");
            PrintStats();

            // Strange beverage
            DoStrangeBeverage();

            // Battle
            DoBattle();

            // Riddle
            DoRiddle();
        }
    }
}

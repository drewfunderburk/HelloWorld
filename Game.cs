using System;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {

            string name, motto;
            float maxHealth = 100;
            float health = 100;
            float damage = 10;
            int maxLevel = 100;
            int level = 1;
            string role = "none";
            bool ready = false;
            bool dead = false;

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
                    health = maxHealth;

                    break;
                }
                else if (roleInput == '2')
                {
                    role = "Wizard";
                    damage *= 2;

                    break;
                }
                else
                {
                    Console.WriteLine("\nThat Input is not recognized!");
                }
            }

            // Print stats
            Console.WriteLine("\n\nWonderful! Here are your stats!\n");
            Console.WriteLine("Name:   " + name);
            Console.WriteLine("Motto:  " + motto);
            Console.WriteLine("Role:   " + role);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Level:  " + level + "\n\n");

            ready = true;

            // Strange beverage
            Console.WriteLine("You've been approached by a mysterious traveler.");
            Console.WriteLine("They offer you a strange beverage");
            Console.WriteLine("Do you accept?");
            Console.WriteLine(" Press 1 for yes.");
            Console.WriteLine(" Press 2 for no.");

            while(true)
            {
                char input = Console.ReadKey().KeyChar;

                if (input == '1')
                {
                    health = 1;
                    damage = 500;
                    Console.WriteLine("\nYou feel an intense rage boil through you!");
                    Console.WriteLine("Health: " + health);
                    Console.WriteLine("Damage: " + damage);

                    break;
                }
                else if (input == '2')
                {
                    Console.WriteLine("The stranger scoffs and slinks off into the shadows.");

                    break;
                }
                else
                {
                    Console.WriteLine("\nThat Input is not recognized!");
                }
            }
        }
    }
}

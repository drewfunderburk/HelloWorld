using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            string name, motto;
            float maxHealth = 100;
            float health = maxHealth;
            int maxLevel = 100;
            int level = 1;
            bool ready = false;
            bool dead = false;

            Console.Write("Greetings! What is your name? ");
            name = Console.ReadLine();

            Console.Write("That's a spectacular name, " + name + "! I'm curious though... What words do you live your life by? What is your motto? ");
            motto = Console.ReadLine();

            Console.WriteLine("Wise words indeed! Now that I know who you are, let me tell you about yourself.");
            Console.WriteLine("Name:   " + name);
            Console.WriteLine("Motto:  " + motto);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Level:  " + level);

            ready = true;
        }
    }
}

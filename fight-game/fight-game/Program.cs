﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_game
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Character n = new Character();
            
            Console.WriteLine("Welcome to Fight Game\n\n");
            //User starts with choose if he/she wants to play 1 or 2 player
            string answer = Functionality.Select(new string[] { "1 Player", "2 Player" });

            Console.Clear();
            //If user choosed 1player user will play against a random character that program has choosed 
            if (answer == "1 Player")
            {
                string character = Functionality.Select(new string[] { "Orc Lord", "Elf Lord", "Human Lord", "Dog Lord", "Cat Lord" });

                switch (character)
                {
                    case "Orc Lord":
                        n.OrcLord();
                        break;
                    case "Elf Lord":
                        n.ElfLord();
                        break;
                    case "Human Lord":
                        n.HumanLord();
                        break;
                    case "Dog Lord":
                        n.DogLord();
                        break;
                    case "Cat Lord":
                        n.CatLord();
                        break;
                }
                //Start of random character for robot
                Random rnd = new Random();

                string[] BotChar = { "Orc Lord", "Elf Lord", "Human Lord", "Dog Lord", "Cat Lord" };
                int BotIndex = rnd.Next(BotChar.Length);
                Console.WriteLine("Robot character: {0}", BotChar[BotIndex]);
                Console.ReadKey();
                Console.Clear();

                Character war1 = new Character(character, n.Hp, n.AttkMax, n.BlockMax);
                Character war2 = new Character(BotChar[BotIndex], n.Hp, n.AttkMax, n.BlockMax);
                Battle.StartFight(war1, war2);
            }
            
            //if user choosed 2 player that means it is 2 humans play against each other
            if(answer == "2 Player")
            {

                Console.WriteLine("Player 1: ");
                //This is code so user can choose different characters with arrow keys
                string character = Functionality.Select(new string[] { "Orc Lord", "Elf Lord", "Human Lord", "Dog Lord", "Cat Lord" });
                //switch case about diiferent characters
                switch(character)
                {
                    case "Orc Lord":
                        n.OrcLord();
                        break;
                    case "Elf Lord":
                        n.ElfLord();
                        break;
                    case "Human Lord":
                        n.HumanLord();
                        break;
                    case "Dog Lord":
                        n.DogLord();
                        break;
                    case "Cat Lord":
                        n.CatLord();
                        break;
                }
                
                Console.WriteLine("\nPlayer 2: ");
                string character1 = Functionality.Select(new string[] { "Orc Lord", "Elf Lord", "Human Lord", "Dog Lord", "Cat Lord" });
                
                switch (character1)
                {
                    case "Orc Lord":
                        n.OrcLord();
                        break;
                    case "Elf Lord":
                        n.ElfLord();
                        break;
                    case "Human Lord":
                        n.HumanLord();
                        break;
                    case "Dog Lord":
                        n.DogLord();
                        break;
                    case "Cat Lord":
                        n.CatLord();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Character war1 = new Character(character, n.Hp, n.AttkMax, n.BlockMax);
                Character war2 = new Character(character1, n.Hp, n.AttkMax, n.BlockMax);
                Battle.StartFight(war1, war2);


            }
            Console.ReadLine();
        }
        
    }
}
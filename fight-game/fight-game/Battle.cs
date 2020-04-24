using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_game
{
    class Battle
    {
        // This is a utility class so it makes sense
        // to have just static methods

        // Recieve both Warrior objects
        public static void StartFight(Character warrior1, Character warrior2)
        {
            // Loop giving each Warrior a chance to attack
            // and block each turn until 1 dies
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        // Accept 2 Warriors
        public static string GetAttackResult(Character warriorA, Character warriorB)
        {
            // Calculate one Warriors attack and the others block
            double warAttack = warriorA.Attack();
            double warBlock = warriorB.Block();

            // Subtract block from attack
            double Block = warAttack - warBlock;

            // If there was damage subtract that from the health
            if (Block > 0)
            {
                warriorB.Hp = warriorB.Hp - Block;
            }
            else Block = 0;

            // Print out info on who attacked who and for how
            // much damage
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",warriorA.Name,warriorB.Name,Block);

            // Provide output on the change to health
            Console.WriteLine("{0} Has {1} Health\n",
                warriorB.Name,
                warriorB.Hp);

            // Check if the warriors health fell below
            // zero and if so print a message and send
            // a response that will end the loop
            if (warriorB.Hp <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious\n",
                    warriorB.Name,
                    warriorA.Name);

                return "Game Over";
            }
            else return "Fight Again";
        }
    }
}   
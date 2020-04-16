using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_game
{
    class Character
    {
        
        public void OrcLord()
        {
            int hp = 100;
            int MaxHit = 20;

            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + MaxHit + "\n");


        }

        public void ElfLord()
        {
            int hp = 100;
            int str = 10;
            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + str + "\n");
        }

        public void HumanLord()
        {
            int hp = 100;
            int str = 8;
            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + str + "\n");
        }

        public void DogLord()
        {
            int hp = 100;
            int str = 11;
            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + str + "\n");
        }

        public void CatLord()
        {
            int hp = 100;
            int str = 6;
            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + str + "\n");
        }
    }
}
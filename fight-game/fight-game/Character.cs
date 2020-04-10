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

            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + MaxHit);
        }

        public void ElfLord()
        {
            int hp = 100;
            int str = 10;
            double suceed = 0.50;
            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + str + "\nattack hit succeed: " + suceed);
        }

        public void HumanLord()
        {
            int hp = 100;
            int str = 8;
            double suceed = 0.93;
            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + str + "\nattack hit succeed: " + suceed);
        }

        public void DogLord()
        {
            int hp = 100;
            int str = 11;
            double suceed = 0.47;
            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + str + "\nattack hit succeed: " + suceed);
        }

        public void CatLord()
        {
            int hp = 100;
            int str = 6;
            double suceed = 1.00;
            Console.WriteLine("\nhp: " + hp + "\nstrenght: " + str + "\nattack hit succeed: " + suceed);
        }
    }
}

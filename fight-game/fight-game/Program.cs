using System;
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
            Console.WriteLine("2 player");
            Console.WriteLine("1 player");

            Console.ReadLine();
        }
    }

    public class Character
    {
        public void OrcLord()
        {
            int hp = 100;
            int str = 20;
            double suceed = 0.35;

            Console.WriteLine("hp: " + hp + "\nstrenght: " + str + "\nattack hit succeed: " + suceed);
        }

        public void ElfLord()
        {
            int hp = 100;
            int str = 10;
            double suceed = 0.50;
            Console.WriteLine("hp: " + hp + "\nstrenght: " + str + "\nattack hit succeed: " + suceed);
        }

        public void HumanLord()
        {
            int hp = 100;
            int str = 8;
            double suceed = 0.93;
            Console.WriteLine("hp: " + hp + "\nstrenght: " + str + "\nattack hit succeed: " + suceed);
        }

        public void DogLord()
        {
            int hp = 100;
            int str = 11;
            double suceed = 0.47;
            Console.WriteLine("hp: " + hp + "\nstrenght: " + str + "\nattack hit succeed: " + suceed);
        }

        public void CatLord()
        {
            int hp = 100;
            int str = 6;
            double suceed = 1.00;
            Console.WriteLine("hp: " + hp + "\nstrenght: " + str + "\nattack hit succeed: " + suceed);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_game
{//Character class

    class Character
    {
        public string Name { get; set; } = "Warrior";
        public double Hp { get; set; } = 100;
        public double AttkMax { get; set; } = 15;
        public double BlockMax { get; set; } = 10;
        //Specs about OrcLord character


        public void OrcLord()
        {
            Console.WriteLine("\nhp: " + Hp + "\nstrenght: " + AttkMax + "\n");
        }

        //specs about other characters
        public void ElfLord()
        {
            Console.WriteLine("\nhp: " + Hp + "\nstrenght: " + AttkMax + "\n");
        }

        public void HumanLord()
        {
            Console.WriteLine("\nhp: " + Hp + "\nstrenght: " + AttkMax + "\n");
        }

        public void DogLord()
        {
            Console.WriteLine("\nhp: " + Hp + "\nstrenght: " + AttkMax + "\n");
        }

        public void CatLord()
        {
            Console.WriteLine("\nhp: " + Hp + "\nstrenght: " + AttkMax + "\n");
        }

        Random rnd = new Random();

        public Character(string name = "Warrior",double health = 100,double attkMax = 15,double blockMax = 10)
        {
            Name = name;
            Hp = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
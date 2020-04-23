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
        /*
        public void Fight(String f1, String f2)
        {
            Console.WriteLine(f1 + " " + f2);
            Console.ReadKey();
            Console.Clear();

            Console.SetCursorPosition(0, 0);
            Console.Write(f1);
            
            Console.SetCursorPosition(100, 0);
            Console.Write(f2);

            var elfLord = new Stats { Name = "Elf Lord", MaxHp = 100, Strength = 10 };
            var dogLord = new Stats { Name = "Dog Lord", MaxHp = 50, Strength = 4 };

        }
        
        public Warrior(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blockMax = 0)
        {
            
            Hp = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }*/

        Random rnd = new Random();

        public Character(string name = "Warrior",
            double health = 100,
            double attkMax = 15,
            double blockMax = 10)
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
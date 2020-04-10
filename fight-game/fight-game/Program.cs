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
            string answer = Functionality.Select(new string[] { "1 Player", "2 Player" });

            Console.Clear();
            if (answer == "1 Player")
            {
                string character = Functionality.Select(new string[] { "Orc Lord", "Elf Lord", "Human Lord", "Dog Lord", "Cat Lord" });

                if(character == "Orc Lord") { n.OrcLord(); }
                if (character == "Elf Lord") { n.ElfLord(); }
                if (character == "Human Lord") { n.HumanLord(); }
                if (character == "Dog Lord") { n.DogLord(); }
                if (character == "Cat Lord") { n.CatLord(); }
                //Start of programs character it randomize it
                Random rnd = new Random();

                string[] BotChar = { "Orc Lord", "Elf Lord", "Human Lord", "Dog Lord", "Cat Lord" };

                int BotIndex = rnd.Next(BotChar.Length);
                Console.WriteLine("Robot character: {0}", BotChar[BotIndex]);
                
            }

            if(answer == "2 Player")
            {
                string character = Functionality.Select(new string[] { "Orc Lord", "Elf Lord", "Human Lord", "Dog Lord", "Cat Lord" });

                if (character == "Orc Lord") { n.OrcLord(); }
                if (character == "Elf Lord") { n.ElfLord(); }
                if (character == "Human Lord") { n.HumanLord(); }
                if (character == "Dog Lord") { n.DogLord(); }
                if (character == "Cat Lord") { n.CatLord(); }
            }
            Console.ReadLine();
        }
    }
}

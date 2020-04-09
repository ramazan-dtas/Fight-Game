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
            string answer = Functionality.Select(new string[] { "1 Player", "2 player" });

            bool ValidAns = true;

            switch(answer)
            {
                case "1 Player":
                    n.CatLord();
                    break;
            }

            Console.ReadLine();
        }
    }
}

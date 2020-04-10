using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_game
{
    class Functionality
    {
        public static string Select(string[] choices)
        {
            
            Console.CursorVisible = false;
            List<int> choicesPos = new List<int>();
            
            int pointer = 0;

            int count = 0;
            foreach (string choice in choices)
            {
                Console.Write("<<");
                if (count == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                choicesPos.Add(Console.CursorLeft);
                Console.Write(choice);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write(">>");
                Console.SetCursorPosition(Console.CursorLeft + 3, Console.CursorTop);

                count++;
            }

            ConsoleKey key;
            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter) //Will listen for any keys until the 'Enter' key is pressed
            {
                if (key == ConsoleKey.LeftArrow && pointer > 0) //Go one to the left
                {
                    ChangeChoice(pointer - 1);
                    continue;
                }
                if (key == ConsoleKey.RightArrow && pointer < choicesPos.Count - 1) //Go one to the right
                {
                    ChangeChoice(pointer + 1);
                    continue;
                }
            }

            Console.CursorVisible = true;
            return choices[pointer];

            void ChangeChoice(int newPos)
            {

                Console.SetCursorPosition(choicesPos[newPos], Console.CursorTop);

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Write(choices[newPos]);


                Console.SetCursorPosition(choicesPos[pointer], Console.CursorTop);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write(choices[pointer]);



                pointer = newPos;
            }
        }
    }
}

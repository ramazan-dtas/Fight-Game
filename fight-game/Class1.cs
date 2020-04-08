using System;

public class Character
{
	public Character()
	{
		void OrcLord()
        {
            int hp = 100;
            int str = 20;
            double suceed = 0.35;

            Console.WriteLine("hp: " + hp + "\n strenght: " + str + "");
        }

		void ElfLord()
        {
            int hp = 100;
            int str = 10;
            double suceed = 0.50;
        }

		void HumanLord()
        {
            int hp = 100;
            int str = 8;
            double succed = 0.93;
        }

        void DogLord()
        {
            int hp = 100;
            int str = 11;
            double suceed = 0.47;
        }

        void CatLord()
        {
            int hp = 100;
            int str = 6;
            double succed = 1.00;
        }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Aloha! ");
            Console.WriteLine(game.GameStart() ? "You won!":"You lost!");
            //Unit test
            Field f = new Field();
            for (int i = 0; i < 52; i++)
                f.Add(i + 1);
            for (int i = 0; i < 52; i++)
                Console.WriteLine(f.entityList[i]);

            f.Shuffle();

            for (int i = 0; i < 52; i++)
                Console.WriteLine(f.entityList[i]);

            Console.ReadKey();
        }
    }
}

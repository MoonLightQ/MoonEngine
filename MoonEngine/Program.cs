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
            Console.ReadKey();
            Field f = new Field();
            EntityList e = new EntityList();
            
        }
    }
}

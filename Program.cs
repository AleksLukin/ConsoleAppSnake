using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameBoard board = new GameBoard();
            board.ToBuildSquare();

            GameFood food = new GameFood();
            food.MakeFoodSnake();

            GameHero hero = new GameHero();
            hero.MakeHeroSnake();

            Console.ReadLine();
        }
    }
}

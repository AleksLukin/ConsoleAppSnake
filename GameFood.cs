using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    internal class GameFood
    {
        public void MakeFoodSnake()
        {
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("~");

            Console.SetCursorPosition(32, 32);
            Console.WriteLine();
        }
    }
}

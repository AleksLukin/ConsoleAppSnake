using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    internal class GameBoard
    {
        public void Square()
        {                       
            for (int i = 0; i <= 41; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int j = 0; j <= 20; j++)
            {
                Console.Write("*");

                for (int k = 0; k <= 40; k++)
                {
                    if (k < 40)
                    {
                        Console.Write(" ");
                    }                    
                    else
                    {
                        Console.WriteLine("*");
                    }                    
                }                
            }            
            for (int i = 0; i <= 41; i++)
            {
                Console.Write("*");
            }
        }
    }
}

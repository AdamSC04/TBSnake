using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TBSnake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gridSize = int.Parse(Console.ReadLine());
            Game game = new Game(gridSize);
            game.CreateBoard();
        }
    }
}

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
            Game game = new Game();
            game.CreateBoard();
            game.Run();
        }
    }
}

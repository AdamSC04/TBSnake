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
            while(true)
            {
                Game game = new Game();
                game.Run();
                Console.WriteLine("Vill du spela igen? 1 = Ja ; Allt annat = Nej");
                int again = int.Parse(Console.ReadLine());
                Console.Clear();
                if (again != 1)
                {
                    break;
                }
            }
        }
    }
}

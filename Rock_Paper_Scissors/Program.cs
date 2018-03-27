using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock Player Scissors Lizard Spock";
            Game playGame = new Game();
            playGame.PlayGame();

            Console.Read();

        }
    }
}

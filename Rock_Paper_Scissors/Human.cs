using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Human : Opponent
    {

        // member variables

        // constructor
        public Human()
        {
        }

        // member methods

        public override string GetName() // OVERRIDES Opponent base classs
        {
            Console.WriteLine("Please enter the opponent's name.");
            string humanOpponentName = Console.ReadLine();
            Console.WriteLine("\n");
            return humanOpponentName;
        }
        
        public override int ChooseActionOpponent(string name) // OVERRIDES Opponent base class
        {
            Console.WriteLine("It's " + name  + "'s turn.");
            Console.WriteLine("Please enter ROCK, PAPER, SCISSORS, LIZARD, or SPOCK.");
            Console.WriteLine("Enter 1 for ROCK.");
            Console.WriteLine("Enter 2 for PAPER.");
            Console.WriteLine("Enter 3 for SCISSORS.");
            Console.WriteLine("Enter 4 for LIZARD.");
            Console.WriteLine("Enter 5 for SPOCK.");
            int actionChosenByOpponent = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " has entered " + actionChosenByOpponent + ".");
            Console.WriteLine("\n");
            return actionChosenByOpponent;
        }



    }
}

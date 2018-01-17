using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Player
    {

        // member variables
        double scoreCounterPlayer = 0;

        // constructor
        public Player()
        {
        }

        // member methods

        public string GetName()
        {
            Console.WriteLine("Please enter your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("\n");
            return playerName;
        }

        public int ChooseActionPlayer(string name)
        {
            Console.WriteLine("It's " + name + "'s turn.");
            Console.WriteLine("Please enter ROCK, PAPER, SCISSORS, LIZARD, or SPOCK.");
            Console.WriteLine("Enter 1 for ROCK.");
            Console.WriteLine("Enter 2 for PAPER.");
            Console.WriteLine("Enter 3 for SCISSORS.");
            Console.WriteLine("Enter 4 for LIZARD.");
            Console.WriteLine("Enter 5 for SPOCK.");
            int actionChosenByPlayer = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " has entered " + actionChosenByPlayer + ".");
            Console.WriteLine("\n");
            return actionChosenByPlayer;
        }

        public double IncrementScoreOfPlayer()
        {
            double incrementedScoreOfPlayer = scoreCounterPlayer + 1;
            return incrementedScoreOfPlayer;
        }

        public void PrintScoreOfPlayer(string name, double score)
        {
            Console.WriteLine(name + "'s score is " + score + ".");
        }

        public double ReturnScoreOfPlayer(double scoreCounterPlayer)
        {
            return scoreCounterPlayer;
        }

        public void AnnouncePlayerHasWonGame(string name)
        {
            Console.WriteLine(name + " has won 2 out of 3 rounds. " + name + " wins the game!");
        }

        public void AnnouncePlayerWonThisRound(string name)
        {
            Console.WriteLine(name + " won this round!");
        }

    }
}

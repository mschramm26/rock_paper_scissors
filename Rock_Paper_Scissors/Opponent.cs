using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    abstract class Opponent
    {
        // member variables
        double scoreCounterOpponent = 0;
        string name;

        // constructor
        public Opponent()
        {
        }

        // member methods

        public abstract int ChooseActionOpponent(string name); // OVERRIDDEN by Human and AI methods

        public abstract string GetName(); // OVERRIDDEN by human and AI methods

        public double IncrementScoreOfOpponent() // doesn't need to be overridden
        {
            double incrementedScoreOfOpponent = scoreCounterOpponent + 1;
            return incrementedScoreOfOpponent;
        }

        public double ReturnScoreOfOpponent(double score) // doesn't need to be overridden
        {
            return score;
        }

        public void AnnounceOpponentHasWonGame(string name) // doesn't need to be overridden
        {
            Console.WriteLine(name + " has won 2 out of 3 rounds. " + name + " wins the game!");
        }

        public void AnnounceOpponentWonThisRound(string name) // doesn't need to be overridden
        {
            Console.WriteLine(name + " won this round!");
        }

        public void PrintScoreOfOpponent(string name, double score) // doesn't need to be overridden
        {
            Console.WriteLine(name + "'s score is " + score + ".");
        }

    }
}

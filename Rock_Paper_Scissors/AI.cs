using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class AI : Opponent
    {

        // member variables
        string name = "Computer";

        // constructor
        public AI()
        {
        }

        // member methods
        public override string GetName() // OVERRIDES Opponent base class GetName
        {
            return name;
        }
        
        public override int ChooseActionOpponent(string name) // OVERRIDES Opponent base class ChooseActionOpponent
        {
            Console.WriteLine("It's " + name + "'s turn.");
            Random rnd = new Random();
            int actionChosenByOpponent = rnd.Next(1, 5);
            Console.WriteLine(name + " has chosen " + actionChosenByOpponent + ".");
            return actionChosenByOpponent;
        }


    }
}

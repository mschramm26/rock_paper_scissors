using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Game
    {

        // member variables


        // constructor
        public Game()
        {

        }

        // member methods

        public void WelcomeAndRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Gecko!" + "\n");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("SCISSORS cuts PAPER.");
            Console.WriteLine("PAPER covers ROCK.");
            Console.WriteLine("ROCK crushes LIZARD.");
            Console.WriteLine("LIZARD poisons SPOCK.");
            Console.WriteLine("SPOCK smashes SCISSORS.");
            Console.WriteLine("SCISSORS decapitates LIZARD.");
            Console.WriteLine("LIZARD eats PAPER.");
            Console.WriteLine("PAPER disproves SPOCK.");
            Console.WriteLine("SPOCK vaporizes ROCK.");
            Console.WriteLine("ROCK crushes SCISSORS.");
            Console.WriteLine("\n");
            Console.WriteLine("Play to best of 2 out of 3." + "\n");
        }

        public int AskIfOpponentIsHumanOrComputer()
        {
            Console.WriteLine("Enter 1 to play another person. Enter 2 to play the computer.");
            int userOpponentInput = int.Parse(Console.ReadLine());
            return userOpponentInput;
        }

        public bool CheckToSeeIfOpponentIsHuman(int AskIfOpponentIsHumanOrComputer)
        {
            if (AskIfOpponentIsHumanOrComputer == 1)
            {
                bool humanOpponent = true;
                return humanOpponent;
            }
            else
            {
                return false;
            }
        }

        public bool CheckToSeeIfOpponentIsComputer(int AskIfOpponentIsHumanOrComputer)
        {
            if (AskIfOpponentIsHumanOrComputer == 2)
            {
                bool computerOpponent = true;
                return computerOpponent;
            }
            else
            {
                return false;
            }
        }

        public void ConfirmInputAndClearScreen(string name)
        {
            Console.WriteLine("Press any key to continue so " + name + " can choose an action.");
            Console.ReadLine(); // allows user to enter input
            Console.Clear(); // clear screen
        }

        public bool CheckForTie(int playerAction, int OpponentAction)
        {
            bool tie;
            if (playerAction == OpponentAction)
            {
                Console.WriteLine("It's a tie! Press any key to try again.\n");
                Console.ReadLine(); // allows user to enter input
                Console.Clear(); // clear screen
                tie = true;
            }
            else
            {
                tie = false;
            }
            return tie;
        }

        public int DetermineWhichActionWins(int playerAction, int opponentAction)
        {
            int winningAction;

            if ((playerAction == 3 & opponentAction == 2) ^ (playerAction == 2 & opponentAction == 3)) 
            {
                winningAction = 3;
                Console.WriteLine("SCISSORS cuts paper.");
                return winningAction; // returns 3
            }
            if ((playerAction == 3 & opponentAction == 4) ^ (playerAction == 4 & opponentAction == 3)) 
            {
                winningAction = 3;
                Console.WriteLine("SCISSORS decapitates lizard.");
                return winningAction; // returns 3
            }
            if ((playerAction == 2 & opponentAction == 1) ^ (playerAction == 1 & opponentAction == 2))
            {
                winningAction = 2;
                Console.WriteLine("PAPER covers rock.");
                return winningAction; // returns 2
            }
            if ((playerAction == 2 & opponentAction == 5) ^ (playerAction == 5 & opponentAction == 2)) 
            {
                winningAction = 2;
                Console.WriteLine("PAPER disproves spock.");
                return winningAction; // returns 2
            }
            if ((playerAction == 1 & opponentAction == 4) ^ (playerAction == 4 & opponentAction == 1))
            {
                winningAction = 1;
                Console.WriteLine("ROCK crushes lizard.");
                return winningAction; // returns 1
            }
            if ((playerAction == 1 & opponentAction == 3) ^ (playerAction == 3 & opponentAction == 1)) 
            {
                winningAction = 1;
                Console.WriteLine("ROCK crushes scissors.");
                return winningAction; // returns 1
            }
            if ((playerAction == 4 & opponentAction == 5) ^ (playerAction == 5 & opponentAction == 4))  
            {
                winningAction = 4;
                Console.WriteLine("LIZARD poisons spock.");
                return winningAction; // returns 4
            }
            if ((playerAction == 4 & opponentAction == 2) ^ (playerAction == 2 & opponentAction == 4)) 
            {
                winningAction = 4;
                Console.WriteLine("LIZARD eats paper.");
                return winningAction; // returns 4
            }
            if ((playerAction == 5 & opponentAction == 1) ^ (playerAction == 1 & opponentAction == 5)) 
            {
                winningAction = 5;
                Console.WriteLine("SPOCK vaporizes rock.");
                return winningAction; // returns 5
            }
            if ((playerAction == 5 & opponentAction == 3) ^ (playerAction == 3 & opponentAction == 5))  
            {
                winningAction = 5;
                Console.WriteLine("SPOCK smashes scissors.");
                return winningAction; // returns 5
            }
            else
            {
                winningAction = 0; // meaningless - only entered because i'm forced to enter something
                return winningAction; 
            }
        }


        public void PlayGame()
        {
            WelcomeAndRules(); // welcome them to the game and tell them the rules
            Player playerObject = new Player(); // instantiate new PLAYER object
            string playerName = playerObject.GetName(); // get name of player instantiated above
            int opponentChoice = AskIfOpponentIsHumanOrComputer(); // ask if opponent is human or AI 
            bool humanOpponent = CheckToSeeIfOpponentIsHuman(opponentChoice); // returns true if user chooses human opponent
            bool computerOpponent = CheckToSeeIfOpponentIsComputer(opponentChoice); // returns true if user chooses AI opponent

            if (humanOpponent == true & computerOpponent == false) /**********IF player is playing a HUMAN opponent**********/
            {
                Human opponentHumanObject = new Human(); // instantiate new HUMAN object
                string humanOpponentName = opponentHumanObject.GetName(); // get name of human object instantiated above
                int playerAction = playerObject.ChooseActionPlayer(playerName); // have player choose an action
                ConfirmInputAndClearScreen(humanOpponentName); // lets user press any key to clear the screen
                int opponentAction = opponentHumanObject.ChooseActionOpponent(humanOpponentName); // allow human to pick action
                bool isATie = CheckForTie(playerAction, opponentAction); // check for tie by seeing if human and player chose the same action; announces tie if it is a tie

                while (isATie) // what to do if it IS a tie 
                {
                    int playerActionNew = playerObject.ChooseActionPlayer(playerName); // have player choose an action (returns int, 1-5)
                    ConfirmInputAndClearScreen(humanOpponentName); // lets user press any key to clear the screen
                    int opponentActionNew = opponentHumanObject.ChooseActionOpponent(humanOpponentName); // allow human to pick action
                    bool tieCheck = CheckForTie(playerActionNew, opponentActionNew); // check for a tie again
                    isATie = tieCheck;
                }

                if (!isATie) // what to do if it IS NOT a tie
                {
                    int winnerAction = DetermineWhichActionWins(playerAction, opponentAction); // see which player's option wins (returns an int, 1-5, corresponding to the winning item)
                    double playerScore = 0;
                    double opponentScore = 0;

                    if (winnerAction == playerAction) // if the player won
                    {
                        playerObject.AnnouncePlayerWonThisRound(playerName); // announce that PLAYER won this round
                        playerScore = playerObject.IncrementScoreOfPlayer(); // add 1 to player score
                        playerObject.PrintScoreOfPlayer(playerName, playerScore); // print score of player
                        opponentHumanObject.PrintScoreOfOpponent(humanOpponentName, opponentScore); // print opponent score
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine(); // allows user to enter input
                        Console.Clear(); // clear screen
                    }
                    if (winnerAction == opponentAction) // if the opponent won
                    {
                        opponentHumanObject.AnnounceOpponentWonThisRound(humanOpponentName); // announce that OPPONENT won this round
                        opponentScore = opponentHumanObject.IncrementScoreOfOpponent(); // add 1 to opponent score
                        opponentHumanObject.PrintScoreOfOpponent(humanOpponentName, opponentScore); // print opponent score
                        playerObject.PrintScoreOfPlayer(playerName, playerScore); // print score of player
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine(); // allows user to enter input
                        Console.Clear(); // clear screen
                    }

                    while ((playerObject.ReturnScoreOfPlayer(playerScore) < 2) & (opponentHumanObject.ReturnScoreOfOpponent(opponentScore) < 2)) // keep repeating rounds until one player's score equals 2
                    {
                        int playerActionNextRound = playerObject.ChooseActionPlayer(playerName); // have player choose an action
                        ConfirmInputAndClearScreen(humanOpponentName); // lets user press any key to clear the screen
                        int opponentActionNextRound = opponentHumanObject.ChooseActionOpponent(humanOpponentName); // allow human to pick action
                        bool isATieNext = CheckForTie(playerActionNextRound, opponentActionNextRound); // check for tie by seeing if human and player chose the same action; announces tie if it is a tie

                        while (isATieNext) // what to do if it IS a tie
                        {
                            int playerActionNewNextRound = playerObject.ChooseActionPlayer(playerName); // have player choose an action
                            ConfirmInputAndClearScreen(humanOpponentName); // lets user press any key to clear the screen
                            int opponentActionNewNextRound = opponentHumanObject.ChooseActionOpponent(humanOpponentName); // allow human to pick action
                            bool tieCheck = CheckForTie(playerActionNewNextRound, opponentActionNewNextRound); // check for a tie again
                            isATie = tieCheck;
                        }

                        if (!isATieNext) // what to do if it IS NOT a tie
                        {
                            int winnerActionNext = DetermineWhichActionWins(playerActionNextRound, opponentActionNextRound); // see which player's option wins (returns an int, 1-5, corresponding to the winning item)

                            if (winnerActionNext == playerActionNextRound) // if the player won
                            {
                                playerObject.AnnouncePlayerWonThisRound(playerName); // announce that PLAYER won this round
                                playerScore = playerScore + 1; // add 1 to player score
                                playerObject.PrintScoreOfPlayer(playerName, playerScore); // print score of player
                                opponentHumanObject.PrintScoreOfOpponent(humanOpponentName, opponentScore); // print opponent score
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadLine(); // allows user to enter input
                                Console.Clear(); // clear screen
                            }
                            if (winnerActionNext == opponentActionNextRound) // if the opponent won
                            {
                                opponentHumanObject.AnnounceOpponentWonThisRound(humanOpponentName); // announce that OPPONENT won this round
                                opponentScore = opponentScore + 1; // add 1 to opponent score
                                opponentHumanObject.PrintScoreOfOpponent(humanOpponentName, opponentScore); // print opponent score
                                playerObject.PrintScoreOfPlayer(playerName, playerScore); // print score of player
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadLine(); // allows user to enter input
                                Console.Clear(); // clear screen
                            }
                        }
                    }

                    double finalScorePlayer = playerObject.ReturnScoreOfPlayer(playerScore); // when someone's score reaches 2, find player's score
                    double finalScoreOpponentHuman = opponentHumanObject.ReturnScoreOfOpponent(opponentScore); // when someone's score reaches 2, find opponent's score
                    if (finalScorePlayer == 2) // if player's score equals 2
                    {
                        playerObject.AnnouncePlayerHasWonGame(playerName); // player wins
                    }
                    if (finalScoreOpponentHuman == 2) // if opponent's score equals 2
                    {
                        opponentHumanObject.AnnounceOpponentHasWonGame(humanOpponentName); // opponent wins
                    }
                }
            }
                if (computerOpponent == true & humanOpponent == false) /**********IF player is playing computer AI opponent**********/
            {
                    AI opponentAIObject = new AI(); // instantiate new AI object
                    string AIOpponentName = opponentAIObject.GetName(); // get name of AI object instantiated above ("Computer")
                    int playerAction = playerObject.ChooseActionPlayer(playerName); // have player choose an action
                    ConfirmInputAndClearScreen(AIOpponentName); // lets user press any key to continue and let AI take turn
                    int opponentAction = opponentAIObject.ChooseActionOpponent(AIOpponentName); // allow AI to pick action
                    bool isATie = CheckForTie(playerAction, opponentAction); // check for tie by seeing if AI and player chose the same action; announces tie if it is a tie

                while (isATie) // what to do if it IS a tie
                {
                    int playerActionNew = playerObject.ChooseActionPlayer(playerName); // have player choose an action (returns int, 1-5)
                    ConfirmInputAndClearScreen(AIOpponentName); // lets user press any key to clear the screen
                    int opponentActionNew = opponentAIObject.ChooseActionOpponent(AIOpponentName); // allow AI to pick action
                    bool tieCheck = CheckForTie(playerActionNew, opponentActionNew); // check for a tie again
                    isATie = tieCheck;
                }

                if (!isATie) // what to do if it IS NOT a tie
                {
                    int winnerAction = DetermineWhichActionWins(playerAction, opponentAction); // see which player's option wins (returns an int, 1-5, corresponding to the winning item)
                    double playerScore = 0;
                    double opponentScore = 0;

                    if (winnerAction == playerAction) // if the player won
                    {
                        playerObject.AnnouncePlayerWonThisRound(playerName); // announce that PLAYER won this round
                        playerScore = playerObject.IncrementScoreOfPlayer(); // add 1 to player score
                        playerObject.PrintScoreOfPlayer(playerName, playerScore); // print score of player
                        opponentAIObject.PrintScoreOfOpponent(AIOpponentName, opponentScore); // print opponent score
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine(); // allows user to enter input
                        Console.Clear(); // clear screen
                    }
                    if (winnerAction == opponentAction) // if the AI won
                    {
                        opponentAIObject.AnnounceOpponentWonThisRound(AIOpponentName); // announce that AI won this round
                        opponentScore = opponentAIObject.IncrementScoreOfOpponent(); // add 1 to AI score
                        opponentAIObject.PrintScoreOfOpponent(AIOpponentName, opponentScore); // print AI score
                        playerObject.PrintScoreOfPlayer(playerName, playerScore); // print score of player
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine(); // allows user to enter input
                        Console.Clear(); // clear screen
                    }

                    while ((playerObject.ReturnScoreOfPlayer(playerScore) < 2) & (opponentAIObject.ReturnScoreOfOpponent(opponentScore) < 2)) // keep repeating rounds until one player's score equals 2
                    {
                        int playerActionNextRound = playerObject.ChooseActionPlayer(playerName); // have player choose an action
                        ConfirmInputAndClearScreen(AIOpponentName); // lets user press any key to continues
                        int opponentActionNextRound = opponentAIObject.ChooseActionOpponent(AIOpponentName); // allow AI to pick action
                        bool isATieNext = CheckForTie(playerActionNextRound, opponentActionNextRound); // check for tie by seeing if AI and player chose the same action; announces tie if it is a tie

                        while (isATieNext) // what to do if it IS a tie
                        {
                            int playerActionNewNextRound = playerObject.ChooseActionPlayer(playerName); // have player choose an action
                            ConfirmInputAndClearScreen(AIOpponentName); // lets user press any key to continue
                            int opponentActionNewNextRound = opponentAIObject.ChooseActionOpponent(AIOpponentName); // allow AI to pick action
                            bool tieCheck = CheckForTie(playerActionNewNextRound, opponentActionNewNextRound); // check for a tie again
                            isATie = tieCheck;
                        }

                        if (!isATieNext) // what to do if it IS NOT a tie
                        {
                            int winnerActionNext = DetermineWhichActionWins(playerActionNextRound, opponentActionNextRound); // see which player's option wins (returns an int, 1-5, corresponding to the winning item)

                            if (winnerActionNext == playerActionNextRound) // if the player won
                            {
                                playerObject.AnnouncePlayerWonThisRound(playerName); // announce that PLAYER won this round
                                playerScore = playerScore + 1; // add 1 to player score
                                playerObject.PrintScoreOfPlayer(playerName, playerScore); // print score of player
                                opponentAIObject.PrintScoreOfOpponent(AIOpponentName, opponentScore); // print opponent score
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadLine(); // allows user to enter input
                                Console.Clear(); // clear screen
                            }
                            if (winnerActionNext == opponentActionNextRound) // if the AI won
                            {
                                opponentAIObject.AnnounceOpponentWonThisRound(AIOpponentName); // announce that AI won this round
                                opponentScore = opponentScore + 1; // add 1 to opponent score
                                opponentAIObject.PrintScoreOfOpponent(AIOpponentName, opponentScore); // print AI score
                                playerObject.PrintScoreOfPlayer(playerName, playerScore); // print score of player
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadLine(); // allows user to enter input
                                Console.Clear(); // clear screen
                            }
                        }
                    }

                    double finalScorePlayer = playerObject.ReturnScoreOfPlayer(playerScore); // when someone's score reaches 2, find player's score
                    double finalScoreOpponentHuman = opponentAIObject.ReturnScoreOfOpponent(opponentScore); // when someone's score reaches 2, find opponent's score
                    if (finalScorePlayer == 2) // if player's score equals 2
                    {
                        playerObject.AnnouncePlayerHasWonGame(playerName); // player wins
                    }
                    if (finalScoreOpponentHuman == 2) // if AI's score equals 2
                    {
                        opponentAIObject.AnnounceOpponentHasWonGame(AIOpponentName); // AI wins
                    }
                }

            }
        }
        }
    }

using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class Game
    {
        private string _playerOne;
        private string _playerTwo;

        public void SetPlayerOne(string input)
        {
            _playerOne = input.ToLower();
        }

        public string GetPlayerOne()
        {
            return _playerOne;
        }

        public void SetPlayerTwo(string input)
        {
            _playerTwo = input.ToLower();
        }

        public string GetPlayerTwo()
        {
            return _playerTwo;
        }

        public string GetOutcome()
        {
            if (GetPlayerOne() == GetPlayerTwo()) return "'Tis a Draw!!!";
            else if (PlayerOneWins()) return PlayerOneWinMessage();
            else if (PlayerTwoWins()) return PlayerTwoWinMessage();
            else return "Come on, guys, put in a real, ACTUAL, answer. Pfft. Pfft. Come on. Pfft.";
        }

        public bool PlayerOneWins()
        {
            if (GetPlayerOne() == "rock" && GetPlayerTwo() == "scissors") return true;
            else if (GetPlayerOne() == "rock" && GetPlayerTwo() == "lizard") return true;
            else if (GetPlayerOne() == "scissors" && GetPlayerTwo() == "paper") return true;
            else if (GetPlayerOne() == "scissors" && GetPlayerTwo() == "lizard") return true;
            else if (GetPlayerOne() == "paper" && GetPlayerTwo() == "rock") return true;
            else if (GetPlayerOne() == "paper" && GetPlayerTwo() == "spock") return true;
            else if (GetPlayerOne() == "spock" && GetPlayerTwo() == "scissors") return true;
            else if (GetPlayerOne() == "spock" && GetPlayerTwo() == "rock") return true;
            else if (GetPlayerOne() == "lizard" && GetPlayerTwo() == "spock") return true;
            else if (GetPlayerOne() == "lizard" && GetPlayerTwo() == "paper") return true;
            else return false;
        }

        public bool PlayerTwoWins()
        {
            if (GetPlayerTwo() == "rock" && GetPlayerOne() == "scissors") return true;
            else if (GetPlayerTwo() == "rock" && GetPlayerOne() == "lizard") return true;
            else if (GetPlayerTwo() == "scissors" && GetPlayerOne() == "paper") return true;
            else if (GetPlayerTwo() == "scissors" && GetPlayerOne() == "lizard") return true;
            else if (GetPlayerTwo() == "paper" && GetPlayerOne() == "rock") return true;
            else if (GetPlayerTwo() == "paper" && GetPlayerOne() == "spock") return true;
            else if (GetPlayerTwo() == "spock" && GetPlayerOne() == "scissors") return true;
            else if (GetPlayerTwo() == "spock" && GetPlayerOne() == "rock") return true;
            else if (GetPlayerTwo() == "lizard" && GetPlayerOne() == "spock") return true;
            else if (GetPlayerTwo() == "lizard" && GetPlayerOne() == "paper") return true;
            else return false;
        }

        public string PlayerOneWinMessage()
        {
            if (GetPlayerOne() == "rock" && GetPlayerTwo() == "scissors") return "Player One wins because rock crushes scissors.";
            else if (GetPlayerOne() == "rock" && GetPlayerTwo() == "lizard") return "Player One wins because rock crushes lizard.";
            else if (GetPlayerOne() == "scissors" && GetPlayerTwo() == "paper") return "Player One wins because scissors cuts paper.";
            else if (GetPlayerOne() == "scissors" && GetPlayerTwo() == "lizard") return "Player One wins because scissors decapitates lizard.";
            else if (GetPlayerOne() == "paper" && GetPlayerTwo() == "rock") return "Player One wins because paper covers rock.";
            else if (GetPlayerOne() == "paper" && GetPlayerTwo() == "spock") return "Player One wins because paper disproves spock.";
            else if (GetPlayerOne() == "spock" && GetPlayerTwo() == "scissors") return "Player One wins because spock smashes scissors.";
            else if (GetPlayerOne() == "spock" && GetPlayerTwo() == "rock") return "Player One wins because spock vaporizes rock.";
            else if (GetPlayerOne() == "lizard" && GetPlayerTwo() == "spock") return "Player One wins because lizard poisons spock.";
            else if (GetPlayerOne() == "lizard" && GetPlayerTwo() == "paper") return "Player One wins because lizard eats paper.";
            else return String.Empty;
        }

        public string PlayerTwoWinMessage()
        {
            if (GetPlayerTwo() == "rock" && GetPlayerOne() == "scissors") return "Player Two wins because rock crushes scissors.";
            else if (GetPlayerTwo() == "rock" && GetPlayerOne() == "lizard") return "Player Two wins because rock crushes lizard.";
            else if (GetPlayerTwo() == "scissors" && GetPlayerOne() == "paper") return "Player Two wins because scissors cuts paper.";
            else if (GetPlayerTwo() == "scissors" && GetPlayerOne() == "lizard") return "Player Two wins because scissors decapitates lizard.";
            else if (GetPlayerTwo() == "paper" && GetPlayerOne() == "rock") return "Player Two wins because paper covers rock.";
            else if (GetPlayerTwo() == "paper" && GetPlayerOne() == "spock") return "Player Two wins because paper disproves spock.";
            else if (GetPlayerTwo() == "spock" && GetPlayerOne() == "scissors") return "Player Two wins because spock smashes scissors.";
            else if (GetPlayerTwo() == "spock" && GetPlayerOne() == "rock") return "Player Two wins because spock vaporizes rock.";
            else if (GetPlayerTwo() == "lizard" && GetPlayerOne() == "spock") return "Player Two wins because lizard poisons spock.";
            else if (GetPlayerTwo() == "lizard" && GetPlayerOne() == "paper") return "Player Two wins because lizard eats paper.";
            else return String.Empty;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Game newGame = new Game();
            Console.WriteLine("Player One choose a weapon. [Rock | Paper | Scissors | Lizard | Spock]");
            newGame.SetPlayerOne(Console.ReadLine());
            Console.WriteLine("Player Two choose a weapon. [Rock | Paper | Scissors | Lizard | Spock]");
            newGame.SetPlayerTwo(Console.ReadLine());
            Console.WriteLine(newGame.GetOutcome());
            Console.WriteLine("You're going to play again right now.");
            Main();
        }
    }
}

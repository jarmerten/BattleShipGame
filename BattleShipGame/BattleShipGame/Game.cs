using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class Game
    {
        ShipHitOrMiss CheckTurn = new ShipHitOrMiss();
        CheckIfGameWon DoWeHaveAWinner = new CheckIfGameWon();
        User HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses = new User(1);
        User HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses = new User(2);
        string gameStatus = "keepplaying";
        int totalHitsOnPlayer2 = 0;
        int totalHitsOnPlayer1 = 0;

        public void PlayUntilWinner()
        {
            while(gameStatus == "keepplaying")
            {
                    UserOneAttackTurn();
                if (gameStatus == "keepplaying")
                {
                    UserTwoAttackTurn();
                }
            }
        }
        public void UserOneAttackTurn()
        {
            Console.WriteLine("This gameboard shows opponents hits and misses on your ships ");
            HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
            Console.WriteLine("This gameboard shows your guesses that you hit and miss on your opponents board ");
            HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.gameBoard.PrintOutListofUsersListOfThereHitsAndMissesOnOpponentBoard();
            int attackpoint = HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.UsersInput.GuessByUserOnLocationOfOpponentsShip(HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.UsersInput.userName);
            int hitOrMiss = CheckTurn.CheckIfUserHitOrMissOpponent(attackpoint, HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.gameBoard);
            totalHitsOnPlayer2 = totalHitsOnPlayer2 + hitOrMiss;
            gameStatus = DoWeHaveAWinner.CheckTotalScoreComparedToWinningTotal(totalHitsOnPlayer2, HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.UsersInput.userName);
            HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.gameBoard.PrintOutListofUsersListOfThereHitsAndMissesOnOpponentBoard();
            Console.WriteLine("Your turn is finished, press any key and enter to end your turn and clear boards for next player ");
            Console.ReadKey();
            Console.Clear();
        }
        public void UserTwoAttackTurn()
        {
            Console.WriteLine("This gameboard shows opponents hits and misses on your ships ");
            HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
            Console.WriteLine("This gameboard shows your guesses that you hit and miss on your opponents board ");
            HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.gameBoard.PrintOutListofUsersListOfThereHitsAndMissesOnOpponentBoard();
            int attackpoint = HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.UsersInput.GuessByUserOnLocationOfOpponentsShip(HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.UsersInput.userName);
            int hitOrMiss = CheckTurn.CheckIfUserHitOrMissOpponent(attackpoint, HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.gameBoard);
            totalHitsOnPlayer1 = totalHitsOnPlayer1 + hitOrMiss;
            gameStatus = DoWeHaveAWinner.CheckTotalScoreComparedToWinningTotal(totalHitsOnPlayer1, HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.UsersInput.userName);
            HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.gameBoard.PrintOutListofUsersListOfThereHitsAndMissesOnOpponentBoard();
            Console.WriteLine("Your turn is finished, press any key and enter to end your turn and clear boards for next player ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

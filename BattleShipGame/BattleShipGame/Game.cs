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
        int userTwoTurn = 0;
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
            HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
            HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.gameBoard.PrintOutListofUsersListOfThereHitsAndMissesOnOpponentBoard();
            int attackpoint = HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.UsersInput.GuessByUserOnLocationOfOpponentsShip(HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.UsersInput.name);
            int hitOrMiss = CheckTurn.CheckIfUserHitOrMissOpponent(attackpoint, HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.gameBoard);
            totalHitsOnPlayer2 = totalHitsOnPlayer2 + hitOrMiss;
            gameStatus = DoWeHaveAWinner.CheckTotalScoreComparedToWinningTotal(totalHitsOnPlayer2, HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.UsersInput.name);
            HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.gameBoard.PrintOutListofUsersListOfThereHitsAndMissesOnOpponentBoard();
        }
        public void UserTwoAttackTurn()
        {
            HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
            HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.gameBoard.PrintOutListofUsersListOfThereHitsAndMissesOnOpponentBoard();
            int attackpoint = HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.UsersInput.GuessByUserOnLocationOfOpponentsShip(HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.UsersInput.name);
            int hitOrMiss = CheckTurn.CheckIfUserHitOrMissOpponent(attackpoint, HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.gameBoard);
            totalHitsOnPlayer1 = totalHitsOnPlayer1 + hitOrMiss;
            gameStatus = DoWeHaveAWinner.CheckTotalScoreComparedToWinningTotal(totalHitsOnPlayer1, HoldsPlayerTwoShipLocationsAndPlayerOnessHitsAndMisses.UsersInput.name);
            HoldsPlayerOneShipLocationsAndPlayerTwosHitsAndMisses.gameBoard.PrintOutListofUsersListOfThereHitsAndMissesOnOpponentBoard();
        }
    }
}

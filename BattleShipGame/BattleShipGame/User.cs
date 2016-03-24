using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class User
    {
        public UsersInput UsersInput = new UsersInput();
        public GameBoard gameBoard = new GameBoard();
        public ValidateShipPlaceMent MakeSureUserCanPlaceShipHere = new ValidateShipPlaceMent();
        int indexofship = 0;
        
        public User(int user)
        {
        UsersInput.GetUsersName(user);
            gameBoard.FillTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocationsWithO();
            gameBoard.FillTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoardWithO();
            while (indexofship <= 3)
            {
                gameBoard.PrintOutListofUsersHitsanddMissesAndShipLocationsOrListOfThereHitsAndMissesOnOpponentBoard();
                int PlayerOneShipStart = UsersInput.ShipLocationsStartingPoint(indexofship);
                int PlayerOneShipDirection = UsersInput.ShipDirectionUserWantsItToGoOnGameBoard(indexofship);
                MakeSureUserCanPlaceShipHere.ShipPlacementIsGoodOrBad(PlayerOneShipStart, PlayerOneShipDirection, gameBoard, indexofship);
                indexofship++;
            }
            gameBoard.PrintOutListofUsersHitsanddMissesAndShipLocationsOrListOfThereHitsAndMissesOnOpponentBoard();

        
        }


    }
}

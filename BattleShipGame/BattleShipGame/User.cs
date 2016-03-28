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
        int indexOfShip = 0;
        
        public User(int user)
        {
            UsersInput.GetUsersName(user);
            gameBoard.FillTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocationsWithO();
            gameBoard.FillTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoardWithO();
            while (indexOfShip <= 3)
            {
                gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
                int playerShipStart = UsersInput.ShipLocationsStartingPoint(indexOfShip);
                int playerShipDirection = UsersInput.ShipDirectionUserWantsItToGoOnGameBoard(indexOfShip);
                int isPositionValidOrInvalid = MakeSureUserCanPlaceShipHere.ShipPlacementIsGoodOrBad(playerShipStart, playerShipDirection, gameBoard, indexOfShip);
                indexOfShip++;
                indexOfShip = indexOfShip+isPositionValidOrInvalid;
            }
            gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
            Console.WriteLine("You finished placing your ships, press any key to clear your boards and allow second player to place ships ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

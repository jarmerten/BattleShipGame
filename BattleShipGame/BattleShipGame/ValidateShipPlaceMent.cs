using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class ValidateShipPlaceMent
    {
        public string[] EachShipsName = new string[] { "Destroyer", "Submarine", "Battleship", "AirCraft Carrier" };
        public int[] EachShipsLength = new int[4] { 2, 3, 4, 5 };
        public int counter = 0;
        public int shipplacementsecondnumber = 0;
        public void ShipPlacementIsGoodOrBad(int PlayerOneShipStart, int PlayerOneShipDirection, GameBoard gameBoard, int indexofship)
        {
            int firstnumber = PlayerOneShipStart / 10 % 10;
            Console.WriteLine(firstnumber);
            int secondnumber = PlayerOneShipStart % 10;
            Console.WriteLine(secondnumber);
            switch(PlayerOneShipDirection)
            {
                case 1: //up
                    {
                        if(secondnumber>=1)
                        {
                            while (counter < EachShipsLength[indexofship])
                            {
                                gameBoard.CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondnumber--][firstnumber] = 'U';
                                gameBoard.PrintOutListofUsersHitsanddMissesAndShipLocationsOrListOfThereHitsAndMissesOnOpponentBoard();
                                counter++;
                            }
                            counter = 0;
                        }
                        break;
                    }
                case 2: //down
                    {
                        if (secondnumber<=8)
                        {
                            while (counter < EachShipsLength[indexofship])
                            {
                                gameBoard.CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondnumber++][firstnumber] = 'D';
                                gameBoard.PrintOutListofUsersHitsanddMissesAndShipLocationsOrListOfThereHitsAndMissesOnOpponentBoard();
                                counter++;
                            }
                            counter = 0;
                        }
                        break;
                    }
                case 3: //left
                    {
                        if (firstnumber>=1)
                        {
                            while (counter < EachShipsLength[indexofship])
                            {
                                gameBoard.CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondnumber][firstnumber--] = 'L';
                                gameBoard.PrintOutListofUsersHitsanddMissesAndShipLocationsOrListOfThereHitsAndMissesOnOpponentBoard();
                                counter++;
                            }
                            counter = 0;
                        }
                        break;
                    }
                default: //right
                    {
                        if (firstnumber<=8)
                        {
                            while (counter < EachShipsLength[indexofship])
                            {
                                gameBoard.CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondnumber][firstnumber++] = 'R';
                                gameBoard.PrintOutListofUsersHitsanddMissesAndShipLocationsOrListOfThereHitsAndMissesOnOpponentBoard();
                                counter++;
                            }
                            counter = 0;
                        }
                        break;
                    }
            }



        }

        internal void ShipPlacementIsGoodOrBad(int playerOneShipStart, int playerOneShipDirection, List<List<char>> createTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations)
        {
            throw new NotImplementedException();
        }
    }
}

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
        public List<int> CheckStoredShipLocationsToNewShipPointsLocations = new List<int>();
        public int counter = 0;
        public int counterForIndexLoop = 0;
        public int ShipPlacementIsGoodOrBad(int playerShipStart, int playerShipDirection, GameBoard gameBoard, int indexOfShip)
        {
            counter = 0;
            int returnIfNewPointsAreValidOrInvalid = 0;
            int userSelectedShipStart = playerShipStart;
            int firstNumberOfUserEntry = playerShipStart / 10 % 10;
            int secondNumberOfUserEntry = playerShipStart % 10;

            switch (playerShipDirection)
            {
                case 1: //up
                    {
                            returnIfNewPointsAreValidOrInvalid=CheckListOfPreviousShipPlacements(indexOfShip, userSelectedShipStart, 1, firstNumberOfUserEntry);
                            if(returnIfNewPointsAreValidOrInvalid == -1)
                            {
                                return -1;
                            }
                        counter = 0;
                        while (counter < EachShipsLength[indexOfShip])
                        {
                            gameBoard.TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondNumberOfUserEntry--][firstNumberOfUserEntry] = '■';
                            CheckStoredShipLocationsToNewShipPointsLocations.Add(playerShipStart);
                            playerShipStart = playerShipStart - 1;
                            counter++;
                        }
                        counter = 0;

                        return 0;
                    }
                case 2: //down
                    {
                        returnIfNewPointsAreValidOrInvalid = CheckListOfPreviousShipPlacements(indexOfShip, userSelectedShipStart, 2, firstNumberOfUserEntry);
                        if (returnIfNewPointsAreValidOrInvalid == -1)
                        {
                            return -1;
                        }
                        counter = 0;
                        while (counter < EachShipsLength[indexOfShip])
                        {
                            gameBoard.TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondNumberOfUserEntry++][firstNumberOfUserEntry] = '■';
                            CheckStoredShipLocationsToNewShipPointsLocations.Add(playerShipStart);
                            playerShipStart = playerShipStart + 1;
                            counter++;
                        }
                        counter = 0;
                        return 0;                 
                    }
                case 3: //left
                    {
                            returnIfNewPointsAreValidOrInvalid = CheckListOfPreviousShipPlacements(indexOfShip, userSelectedShipStart, 3, firstNumberOfUserEntry);
                            if (returnIfNewPointsAreValidOrInvalid == -1)
                            {
                                return -1;
                            }
                        counter = 0;
                        while (counter < EachShipsLength[indexOfShip])
                        {
                            gameBoard.TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondNumberOfUserEntry][firstNumberOfUserEntry--] = '■';
                            CheckStoredShipLocationsToNewShipPointsLocations.Add(playerShipStart);
                            playerShipStart = playerShipStart - 10;
                            counter++;
                        }
                        counter = 0;
                        return 0;               
                    }
                default: //right
                    {
                            returnIfNewPointsAreValidOrInvalid = CheckListOfPreviousShipPlacements(indexOfShip, userSelectedShipStart, 4, firstNumberOfUserEntry);
                            if (returnIfNewPointsAreValidOrInvalid == -1)
                            {
                                return -1;
                            }
                        counter = 0;
                        while (counter < EachShipsLength[indexOfShip])
                        {
                            gameBoard.TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondNumberOfUserEntry][firstNumberOfUserEntry++] = '■';
                            CheckStoredShipLocationsToNewShipPointsLocations.Add(playerShipStart);
                            playerShipStart = playerShipStart + 10;
                            counter++;
                        }
                        counter = 0;
                        return 0;             
                    }
            }
        }
        public int CheckListOfPreviousShipPlacements(int indexOfShipInArray, int userSelectedShipStart, int ShipUserIsPlacingOnBoard, int firstNumberOfUserEntry)
        {
            int returnIfNewPointsAreValidOrInvalid = 0;
            while (counterForIndexLoop < EachShipsLength[indexOfShipInArray])
            {
                counter = 0;
                returnIfNewPointsAreValidOrInvalid = LoopThroughListOfPointsUsedToCheckOverLapInNewShip(userSelectedShipStart);
                if (returnIfNewPointsAreValidOrInvalid == -1)
                {
                    return -1;
                }
                userSelectedShipStart = ChangePointToCheckIfAllAreValidLocations(userSelectedShipStart, ShipUserIsPlacingOnBoard);
                if(ShipUserIsPlacingOnBoard == 1 || ShipUserIsPlacingOnBoard == 2)
                {
                    returnIfNewPointsAreValidOrInvalid = ValidateShipLocationNotRunningOffTopOrBottom(userSelectedShipStart, returnIfNewPointsAreValidOrInvalid, firstNumberOfUserEntry);
                }
                else
                {
                    returnIfNewPointsAreValidOrInvalid = ValidateShipLocationNotRunningOffLeftOrRight(userSelectedShipStart, returnIfNewPointsAreValidOrInvalid);
                }
                if (returnIfNewPointsAreValidOrInvalid==-1)
                {
                    return -1;
                }
                counterForIndexLoop++;
            }
            counterForIndexLoop = 0;
            return 0;
        }
        public int LoopThroughListOfPointsUsedToCheckOverLapInNewShip(int userSelectedShipStart)
        {
            counter = 0;
            while (counter < CheckStoredShipLocationsToNewShipPointsLocations.Count)
            {
                if (CheckStoredShipLocationsToNewShipPointsLocations[counter] == userSelectedShipStart)
                {
                    Console.WriteLine("You cant put a ship here! Your going to overlap another, please re enter starting point! ");
                    return -1;
                }
                else
                {
                    counter++;
                }
            }
            return 0;
        }
        public int ChangePointToCheckIfAllAreValidLocations(int userSelectedShipStart, int ShipUserIsPlacingOnBoard)
        {
            switch (ShipUserIsPlacingOnBoard)
            {
                case 1:
                    {
                        userSelectedShipStart = userSelectedShipStart - 1;
                        break;
                    }
                case 2:
                    {
                        userSelectedShipStart = userSelectedShipStart + 1;
                        break;
                    }
                case 3:
                    {
                        userSelectedShipStart = userSelectedShipStart - 10;
                        break;
                    }
                default:
                    {
                        userSelectedShipStart = userSelectedShipStart + 10;
                        break;
                    }
            }
            return userSelectedShipStart;
        }
        public int ValidateShipLocationNotRunningOffLeftOrRight(int userSelectedShipStart, int returnIfNewPointsAreValidOrInvalid)
        {
            returnIfNewPointsAreValidOrInvalid = 0;
            if (userSelectedShipStart >= 100 || userSelectedShipStart < 0)
            {
                Console.WriteLine("Placement of Ship is inncorrect, Please re enter the first point for it.");
                returnIfNewPointsAreValidOrInvalid = -1;
            }
            return returnIfNewPointsAreValidOrInvalid;
        }
        public int ValidateShipLocationNotRunningOffTopOrBottom(int sameAsPlayerShipStart, int returnValidOrInvalid, int firstnumber)
        {
            returnValidOrInvalid = 0;
            string firstNumberToString = firstnumber.ToString();
            string firstNumberToStringtoTopofNine = firstNumberToString + "9";
            string firstNumberToStringtoTopBottom = firstNumberToString + "0";
            int turnFirstNumberStringNine = Int32.Parse(firstNumberToStringtoTopofNine);
            int turnFirstNumberStringBottom = Int32.Parse(firstNumberToStringtoTopBottom);
            if (sameAsPlayerShipStart > turnFirstNumberStringNine || sameAsPlayerShipStart < turnFirstNumberStringBottom)
            {
                Console.WriteLine("Placement of Ship is inncorrect, Please re enter the first point for it.");
                returnValidOrInvalid = -1;
            }
            return returnValidOrInvalid;
        }
      }
    }


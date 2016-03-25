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
        public List<int> StoreAndMakeSureNoOtherShipIsLocatedThere = new List<int>();
        public int counter = 0;
        public int counterforindexloop = 0;
        int returnIfEqualsMinusOneForInvalidShipPlacement = 0;
        public int shipplacementsecondnumber = 0;
        public int ShipPlacementIsGoodOrBad(int PlayerShipStart, int PlayerShipDirection, GameBoard gameBoard, int indexofship)
        {
            counter = 0;
            int returnIfEqualsMinusOneForInvalidShipPlacement = 0;
            counterforindexloop = 0;
            int sameAsPlayerShipStart = PlayerShipStart;
            int firstnumber = PlayerShipStart / 10 % 10;
            int secondnumber = PlayerShipStart % 10;
            string nine = "9";
            //make firstnumber a string
            //string bottomrow = firstnumber + 9;
            //make bottomrow an int
            switch(PlayerShipDirection)
            {
                case 1: //up
                    {
                            returnIfEqualsMinusOneForInvalidShipPlacement=CheckListOfPreviousShipPlacements(indexofship, sameAsPlayerShipStart, 1, firstnumber);
                            if(returnIfEqualsMinusOneForInvalidShipPlacement == -1)
                            {
                                return -1;
                            }
                            while (counter < EachShipsLength[indexofship])
                            {
                                gameBoard.CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondnumber--][firstnumber] = '■';
                                StoreAndMakeSureNoOtherShipIsLocatedThere.Add(PlayerShipStart);
                                PlayerShipStart = PlayerShipStart - 1;
                                gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
                                counter++;
                            }
                            counter = 0;
                            return 0;
                            break;
                    }
                case 2: //down
                    {
                        returnIfEqualsMinusOneForInvalidShipPlacement = CheckListOfPreviousShipPlacements(indexofship, sameAsPlayerShipStart, 2, firstnumber);
                        if (returnIfEqualsMinusOneForInvalidShipPlacement == -1)
                        {
                            return -1;
                        }
                        while (counter < EachShipsLength[indexofship])
                        {
                            gameBoard.CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondnumber++][firstnumber] = '■';
                            StoreAndMakeSureNoOtherShipIsLocatedThere.Add(PlayerShipStart);
                            PlayerShipStart = PlayerShipStart + 1;
                            gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
                            counter++;
                        }
                        counter = 0;
                        return 0;                 
                        break;
                    }
                case 3: //left
                    {
                            returnIfEqualsMinusOneForInvalidShipPlacement = CheckListOfPreviousShipPlacements(indexofship, sameAsPlayerShipStart, 3, firstnumber);
                            if (returnIfEqualsMinusOneForInvalidShipPlacement == -1)
                            {
                                return -1;
                            }

                            while (counter < EachShipsLength[indexofship])
                            {
                                gameBoard.CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondnumber][firstnumber--] = '■';
                                StoreAndMakeSureNoOtherShipIsLocatedThere.Add(PlayerShipStart);
                                PlayerShipStart = PlayerShipStart - 10;
                                gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
                                counter++;
                            }
                            counter = 0;
                            return 0;               
                            break;
                    }
                default: //right
                    {
                            returnIfEqualsMinusOneForInvalidShipPlacement = CheckListOfPreviousShipPlacements(indexofship, sameAsPlayerShipStart, 4, firstnumber);
                            if (returnIfEqualsMinusOneForInvalidShipPlacement == -1)
                            {
                                return -1;
                            }

                            while (counter < EachShipsLength[indexofship])
                            {
                                gameBoard.CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondnumber][firstnumber++] = '■';
                                StoreAndMakeSureNoOtherShipIsLocatedThere.Add(PlayerShipStart);
                                PlayerShipStart = PlayerShipStart + 10;
                                gameBoard.PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations();
                                counter++;
                            }
                            counter = 0;
                            return 0;             
                            break;
                    }
            }
        }
        public int CheckListOfPreviousShipPlacements(int indexofship, int sameAsPlayerShipStart, int WhichShip,int firstnumber)
        {
            int capofrow = firstnumber;
            while (counterforindexloop < EachShipsLength[indexofship])
            {
                while (counter < StoreAndMakeSureNoOtherShipIsLocatedThere.Count)
                {
                    if (StoreAndMakeSureNoOtherShipIsLocatedThere[counter] == sameAsPlayerShipStart)
                    {
                        Console.WriteLine("You cant put a ship here! Your going to overlap another, please re enter starting point! ");
                        return -1;
                    }
                    else
                    {
                        counter++;
                    }
                }
                counter = 0;
                switch (WhichShip)
                {
                    case 1:
                        {
                            sameAsPlayerShipStart = sameAsPlayerShipStart - 1;
                            break;
                        }
                    case 2:
                        {
                            sameAsPlayerShipStart = sameAsPlayerShipStart + 1;
                            break;
                        }
                    case 3:
                        {
                            sameAsPlayerShipStart = sameAsPlayerShipStart - 10;
                            break;
                        }
                    default:
                        {
                            sameAsPlayerShipStart = sameAsPlayerShipStart + 10;
                            break;
                        }
                }
                if (sameAsPlayerShipStart >= 100 || sameAsPlayerShipStart<0 || sameAsPlayerShipStart>capofrow)
                {
                    Console.WriteLine("Placement of Destroyer is inncorrect, Please reenter the first point for it.");
                    return -1;
                }
                counterforindexloop++;
            }
            counterforindexloop = 0;
            counter = 0;
            return 0;





        }

        }
    }


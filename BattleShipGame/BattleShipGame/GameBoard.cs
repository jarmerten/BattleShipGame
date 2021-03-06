﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class GameBoard
    {       public int rowsAndColumnsInsideThe2dArray = 10;
            public int where = 0;
            public int location = 0;
            public int row;
            public int column;
            public int counter = 0;

            public List<List<char>> TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations = new List<List<char>>();
            public List<char> GraphsTheTwoDListThatShowsUsersShipsAndOpponentsHitsAndMissesLocations = new List<char>();

            public List<List<char>> TwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard = new List<List<char>>();
            public List<char> GraphsTheTwoDListThatShowsUsersThereHitsAndMissesOnOpponentsBoard = new List<char>();

        public void FillTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocationsWithO()
        {
            TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations.Add(GraphsTheTwoDListThatShowsUsersShipsAndOpponentsHitsAndMissesLocations);
            for (row = 0; row < rowsAndColumnsInsideThe2dArray; row++)
            {
                TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations.Add(new List<char>());
                for (column = 0; column < rowsAndColumnsInsideThe2dArray; column++)
                {
                    TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[row].Add('O');
                }
            }            
        }
        public void FillTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoardWithO()
        {
            TwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard.Add(GraphsTheTwoDListThatShowsUsersThereHitsAndMissesOnOpponentsBoard);
            for (row = 0; row < rowsAndColumnsInsideThe2dArray; row++)
            {
                TwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard.Add(new List<char>());
                for (column = 0; column < rowsAndColumnsInsideThe2dArray; column++)
                {
                    TwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard[row].Add('O');
                }
            }
        }
        public void PrintOutListofOpponenetsHitsanddMissesAndUsersShipLocations()
        {
            HeadingForTheGameBoardXais();
            foreach (List<char> index in TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations)
            {
                    Console.WriteLine();
                    SideHeadingForTheGameBoardYaxis();
                    foreach (char star in index)
                    {
                        Console.Write(" ");
                        Console.Write(star);
                    }
            }
        }
            public void PrintOutListofUsersListOfThereHitsAndMissesOnOpponentBoard()
             {
            HeadingForTheGameBoardXais();
            foreach (List<char> index in TwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard)
            {
                Console.WriteLine();
                SideHeadingForTheGameBoardYaxis();
                foreach (char star in index)
                {
                    Console.Write(" ");
                    Console.Write(star);
                }
            }
        }
            public void HeadingForTheGameBoardXais()
        {
            Console.WriteLine("             X Axis ");
            counter = 0;
            location = 0;
            Console.Write("       ");
            for (int length = 0; length < rowsAndColumnsInsideThe2dArray; length++)
            {
                int k = length;
                Console.Write(k);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write("       -------------------");
        }
        public void SideHeadingForTheGameBoardYaxis()
        {
            String kaxis = "   " + (counter) + ":|";
            switch (location)
            {
                case 0:
                    {
                        Console.Write(kaxis);
                        break;
                    }
                case 1:
                    {
                        Console.Write(kaxis);
                        break;
                    }
                case 2:
                    {
                        kaxis = " Y " + (counter) + ":|";
                        Console.Write(kaxis);
                        break;
                    }
                case 3:
                    {
                        kaxis = " - " + (counter) + ":|";
                        Console.Write(kaxis);
                        break;
                    }
                case 4:
                    {
                        kaxis = " A " + (counter) + ":|";
                        Console.Write(kaxis);
                        break;
                    }
                case 5:
                    {
                        kaxis = " X " + (counter) + ":|";
                        Console.Write(kaxis);
                        break;
                    }
                case 6:
                    {
                        kaxis = " I " + (counter) + ":|";
                        Console.Write(kaxis);
                        break;
                    }
                case 7:
                    {
                        kaxis = " S " + (counter) + ":|";
                        Console.Write(kaxis);
                        break;
                    }
                case 8:
                    {
                        Console.Write(kaxis);
                        break;
                    }
                case 9:
                    {
                        Console.Write(kaxis);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
                    counter++;
                    location++;
            }
        }   
    }

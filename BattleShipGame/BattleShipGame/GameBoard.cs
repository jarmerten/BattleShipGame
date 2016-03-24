using System;
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

            public List<List<char>> CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations = new List<List<char>>();
            public List<char> GraphsTheTwoDListThatShowsUsersShipsAndOpponentsHitsAndMissesLocations = new List<char>();

            public List<List<char>> CreateTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard = new List<List<char>>();
            public List<char> GraphsTheTwoDListThatShowsUsersThereHitsAndMissesOnOpponentsBoard = new List<char>();


   
        public void FillTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocationsWithO()
        {
            CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations.Add(GraphsTheTwoDListThatShowsUsersShipsAndOpponentsHitsAndMissesLocations);
            for (row = 0; row < rowsAndColumnsInsideThe2dArray; row++)
            {
                CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations.Add(new List<char>());
                for (column = 0; column < rowsAndColumnsInsideThe2dArray; column++)
                {
                    CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[row].Add('O');
                }
            }            
        }
        public void FillTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoardWithO()
        {
            CreateTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard.Add(GraphsTheTwoDListThatShowsUsersThereHitsAndMissesOnOpponentsBoard);
            for (row = 0; row < rowsAndColumnsInsideThe2dArray; row++)
            {
                CreateTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard.Add(new List<char>());
                for (column = 0; column < rowsAndColumnsInsideThe2dArray; column++)
                {
                    CreateTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard[row].Add('O');
                }
            }
        }
        public void PrintOutListofUsersHitsanddMissesAndShipLocationsOrListOfThereHitsAndMissesOnOpponentBoard()
        {
            Console.ReadLine();
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
            foreach(List<char> index in CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations)
            {
                Console.WriteLine();
                String kaxis = "   " + (counter) + ":|";
                if (location == 0)
                {
                    kaxis = "   " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                else if (location == 1)
                {
                    kaxis = "   " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                else if (location == 2)
                {
                    kaxis = " Y " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                else if (location == 3)
                {
                    kaxis = " - " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                else if (location == 4)
                {
                    kaxis = " A " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                else if (location == 5)
                {
                    kaxis = " X " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                else if (location == 6)
                {
                    kaxis = " I " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                else if (location == 7)
                {
                    kaxis = " S " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                else if (location == 8)
                {
                    kaxis = "   " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                else if (location == 9)
                {
                    kaxis = "   " + (counter) + ":|";
                    Console.Write(kaxis);
                }
                counter++;
                location++;
                foreach (char star in index)
                {
                    Console.Write(" ");
                    Console.Write(star);
                }
            }
            Console.ReadLine();
        


        }
        }
    }

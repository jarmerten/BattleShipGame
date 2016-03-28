using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class ShipHitOrMiss
    {
        public int CheckIfUserHitOrMissOpponent(int playerOneShipStart, GameBoard gameboard)
        {
            int totalHitsOnOpponent;
            int firstNumberOfUserEntry = playerOneShipStart / 10 % 10;
            Console.WriteLine(firstNumberOfUserEntry);
            int secondNumberOfUserEntry = playerOneShipStart % 10;
            Console.WriteLine(secondNumberOfUserEntry);
            
            if(gameboard.TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondNumberOfUserEntry][firstNumberOfUserEntry] == '■')
            {
                Console.WriteLine("You Hit There Ship!!!");
                gameboard.TwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard[secondNumberOfUserEntry][firstNumberOfUserEntry] = 'H';
                gameboard.TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondNumberOfUserEntry][firstNumberOfUserEntry] = 'H';
                totalHitsOnOpponent = 1;
                return totalHitsOnOpponent;
            }
            else
            {
                Console.WriteLine("You Missed There Ship!!!");
                gameboard.TwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard[secondNumberOfUserEntry][firstNumberOfUserEntry] = 'M';
                gameboard.TwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondNumberOfUserEntry][firstNumberOfUserEntry] = 'M';
                totalHitsOnOpponent = 0;
                return totalHitsOnOpponent;
            }        
        }
    }
}

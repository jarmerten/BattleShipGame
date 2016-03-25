using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class ShipHitOrMiss
    {
        public int CheckIfUserHitOrMissOpponent(int PlayerOneShipStart, GameBoard gameboard)
        {
            int totalHitsOnOpponent;
            int firstnumber = PlayerOneShipStart / 10 % 10;
            Console.WriteLine(firstnumber);
            int secondnumber = PlayerOneShipStart % 10;
            Console.WriteLine(secondnumber);
            
            if(gameboard.CreateTwoDListShowsUsersShipsAndOpponentsHitsAndMissesLocations[secondnumber][firstnumber] == '=')
            {
                Console.WriteLine("You Hit There Ship!!!");
                gameboard.CreateTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard[secondnumber][firstnumber] = 'H';
                totalHitsOnOpponent = 1;
                return totalHitsOnOpponent;
            }
            else
            {
                Console.WriteLine("You Missed There Ship!!!");
                gameboard.CreateTwoDListShowsUsersThereHitsAndMissesOnOpponentsBoard[secondnumber][firstnumber] = 'M';
                totalHitsOnOpponent = 0;
                return totalHitsOnOpponent;
            }        
        }
    }
}

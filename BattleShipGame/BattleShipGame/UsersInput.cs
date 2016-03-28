using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class UsersInput
    {
        public string userName;
        public int pointThatTheFrontOfCurrentShipIsOn;
        public int userPicksDirectionShipWillPoint;
        public int userGuessOnLocationOfOpponentsShip = 0;
        ValidateShipPlaceMent GetDataOnShipsLengthAndName = new ValidateShipPlaceMent();

        public string GetUsersName(int user)
        {
            Console.WriteLine("What is Player " + user + " name? ");
            string usersName = Console.ReadLine();
            userName = usersName;
            return userName;
        }
        public int ShipLocationsStartingPoint(int indexOfShip)
        {
            Console.WriteLine("What is the point you would like to place the start of your " + GetDataOnShipsLengthAndName.EachShipsName[indexOfShip] + " on. Remember it is " + GetDataOnShipsLengthAndName.EachShipsLength[indexOfShip] + " points long.");
            Console.WriteLine("Enter X axis number followed directly by Y axis number");
            pointThatTheFrontOfCurrentShipIsOn = Convert.ToInt32(Console.ReadLine());
            return pointThatTheFrontOfCurrentShipIsOn;
        }
        public int ShipDirectionUserWantsItToGoOnGameBoard(int indexOfShip)
        {

            Console.WriteLine("Which direction would you like the ship to go? (1: UP , 2: DOWN , 3: LEFT , 4: RIGHT)");
            Console.WriteLine("Remeber the " + GetDataOnShipsLengthAndName.EachShipsName[indexOfShip] + " is " + GetDataOnShipsLengthAndName.EachShipsLength[indexOfShip] + " points long.");
            userPicksDirectionShipWillPoint = Convert.ToInt32(Console.ReadLine());
            return userPicksDirectionShipWillPoint;
        }
        public int GuessByUserOnLocationOfOpponentsShip(string usersName)
        {
            Console.WriteLine("Its is " + usersName + " turn! ");
            Console.WriteLine("What is the point you would like to fire a shot at Player? (Enter X axis number followed directly by Y axis number) ");
            userGuessOnLocationOfOpponentsShip = Convert.ToInt32(Console.ReadLine());
            return userGuessOnLocationOfOpponentsShip;
        }
    }


    }


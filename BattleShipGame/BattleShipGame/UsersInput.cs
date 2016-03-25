using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class UsersInput
    {
        public string name;
        public int pointThatTheFrontOfCurrentShipIsOn;
        public int pointThatTheBackOfCurrentShipIsOn;
        public int userGuessOnLocationOfOpponentsShip = 0;
        ValidateShipPlaceMent GetDataOnShipsLengthAndName = new ValidateShipPlaceMent();

        public string GetUsersName(int user)
        {
            Console.WriteLine("What is Player " + user + " name? ");
            string usersName = Console.ReadLine();
            name = usersName;
            return name;
        }
        public int ShipLocationsStartingPoint(int indexofship)
        {
            Console.WriteLine("What is the point you would like to place the start of your " + GetDataOnShipsLengthAndName.EachShipsName[indexofship] + " on. Remeber it is " + GetDataOnShipsLengthAndName.EachShipsLength[indexofship] + " points long.");
            Console.WriteLine("Enter X axis number followed directly by Y axis number");
            pointThatTheFrontOfCurrentShipIsOn = Convert.ToInt32(Console.ReadLine());
            return pointThatTheFrontOfCurrentShipIsOn;
        }
        public int ShipDirectionUserWantsItToGoOnGameBoard(int indexofship)
        {

            Console.WriteLine("Which direction would you like the ship to go? (1: UP , 2: DOWN , 3: LEFT , 4: RIGHT)");
            Console.WriteLine("Remeber the " + GetDataOnShipsLengthAndName.EachShipsName[indexofship] + " is " + GetDataOnShipsLengthAndName.EachShipsLength[indexofship] + " points long.");
            pointThatTheBackOfCurrentShipIsOn = Convert.ToInt32(Console.ReadLine());
            return pointThatTheBackOfCurrentShipIsOn;
        }
        public int GuessByUserOnLocationOfOpponentsShip(string usersname)
        {
            Console.WriteLine("Its is " + usersname + " turn! ");
            Console.WriteLine("What is the point you would like to fire a shot at Player? (Enter X axis number followed directly by Y axis number) ");
            userGuessOnLocationOfOpponentsShip = Convert.ToInt32(Console.ReadLine());
            return userGuessOnLocationOfOpponentsShip;
        }
    }


    }


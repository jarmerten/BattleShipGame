using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class CheckIfGameWon
    {
        string gameStatus;
        public string CheckTotalScoreComparedToWinningTotal(int wasAttackHitOrMiss, string playerName)
        {
            if(wasAttackHitOrMiss == 14)
            {
                Console.WriteLine("You won " + playerName + "!!!!");
                gameStatus = "gamewon";
                return gameStatus;
            }
            else
            {
                Console.WriteLine(playerName + ", you need " + (14-wasAttackHitOrMiss) + " hits more to win the game");
                gameStatus = "keepplaying";
                return gameStatus;
            }
        }
    }
}

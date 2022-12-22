using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo_Game
{
    class AiLogics
    {
        public static bool isCellShootedAI(int randomX, int randomY, char[,] playerPlayfield)
        {
            return (playerPlayfield[randomY, randomX] == 'T' || playerPlayfield[randomY, randomX] == 'V');
        }

        public static bool isHitPlayerShipUnit(int randomX, int randomY, char[,] playerPlayfield)
        {
            return char.IsDigit(playerPlayfield[randomY, randomX]);
        }

        public static bool isCellWall(int randomX, int randomY)
        {
            if (randomY > 9 || randomY < 0)
            {
                return true;
            }
            else if (randomX > 9 || randomX < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int generateAiShoot(Random rnd, char[,] playerPlayfield)
        {
            int randomX, randomY;
            do
            {
                randomY = (int)rnd.Next(0, 10);
                randomX = (int)rnd.Next(0, 10);
            }
            while (AiLogics.isCellShootedAI(randomX, randomY, playerPlayfield) == true);

            return (randomY * 10) + randomX;
        }
    }
}

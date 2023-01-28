using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMenPhieuLuuKy
{
    class PlayerProfile
    {

        public static float playerJumpSpeed = 14f;
        public static int playerPower = 50;
        public static int playerGobalHealth = 80;

        public static void ResetPlayerProfile()
        {
            playerJumpSpeed = 14f;
            playerPower = 40;
            playerGobalHealth = 80;
        }

        public static void upJumpSpeed(ref float temp)
        {
            playerJumpSpeed += 0.09f;
            temp += 0.09f;
        }

        public static void upPower(ref int temp)
        {
            playerPower+=2;
            temp += 2;
        }

        public static void upHealth(ref int temp)
        {
            playerGobalHealth += 2;
            temp += 2;
        }
    }
}

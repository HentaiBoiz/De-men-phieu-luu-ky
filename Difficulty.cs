using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMenPhieuLuuKy
{
    class Difficulty
    {

        public static int difficulty = 2; //Độ khó: 1-Easy , 2-Medium , 3-Hard

        //Kẻ địch bình thường
        public static int KienLuaGobalSpeed;

        //Chị Cốc
        public static int chiCocGolbalHealth;

        //Dế nhà Thịnh
        public static int deNhaThinhGolbalHealth;
        public static int deNhaThinhGolbalSpeed;
        public static int deNhaThinhGolbalPunchSpeed;
        public static int deNhaThinhGolbalPunchDamage;
        public static int deNhaThinhGolbalSuperPunchDamage;

        //Nhện
        public static int nhenGolbalHealth;
        public static int nhenGolbalSpeed;
        public static int nhenGolbalShotSpeed;
        public static int nhenGolbalWebDamage;
        public static int nhenGolbalRockDamage;


        public static void ChangeEasy()
        {
            difficulty = 1;//Độ khó: 1-Easy , 2-Medium , 3-Hard

            //Kẻ địch bình thường
            KienLuaGobalSpeed = 4;

            //Chị Cốc
            chiCocGolbalHealth = 400;

            //Dế nhà Thịnh
            deNhaThinhGolbalHealth = 1100;
            deNhaThinhGolbalSpeed = 7;
            deNhaThinhGolbalPunchSpeed = 11;
            deNhaThinhGolbalPunchDamage = 13;
            deNhaThinhGolbalSuperPunchDamage = 23;

            //Nhện
            nhenGolbalHealth = 1400;
            nhenGolbalSpeed = 9;
            nhenGolbalShotSpeed = 14;
            nhenGolbalWebDamage = 18;
            nhenGolbalRockDamage = 28;

        }

        public static void ChangeMedium()
        {
            difficulty = 2;//Độ khó: 1-Easy , 2-Medium , 3-Hard

            //Kẻ địch bình thường
            KienLuaGobalSpeed = 5;

            //Chị Cốc
            chiCocGolbalHealth = 500;

            //Dế nhà Thịnh
            deNhaThinhGolbalHealth = 1200;
            deNhaThinhGolbalSpeed = 8;
            deNhaThinhGolbalPunchSpeed = 12;
            deNhaThinhGolbalPunchDamage = 15;
            deNhaThinhGolbalSuperPunchDamage = 25;

            //Nhện
            nhenGolbalHealth = 1600;
            nhenGolbalSpeed = 10;
            nhenGolbalShotSpeed = 15;
            nhenGolbalWebDamage = 20;
            nhenGolbalRockDamage = 30;

        }

        public static void ChangeHard()
        {
            difficulty = 3;//Độ khó: 1-Easy , 2-Medium , 3-Hard

            //Kẻ địch bình thường
            KienLuaGobalSpeed = 6;

            //Chị Cốc
            chiCocGolbalHealth = 700;

            //Dế nhà Thịnh
            deNhaThinhGolbalHealth = 1700;
            deNhaThinhGolbalSpeed = 9;
            deNhaThinhGolbalPunchSpeed = 13;
            deNhaThinhGolbalPunchDamage = 18;
            deNhaThinhGolbalSuperPunchDamage = 28;

            //Nhện
            nhenGolbalHealth = 1800;
            nhenGolbalSpeed = 11;
            nhenGolbalShotSpeed = 16;
            nhenGolbalWebDamage = 23;
            nhenGolbalRockDamage = 33;

        }

        public static string StringDifficulty(int difficulty)
        {
            string[] stringDifficulty = { "","Dễ", "Bình Thường", "Khó" };

            if(difficulty == 1)
            {
                ChangeEasy();
            }else if(difficulty == 2)
            {
                ChangeMedium();
            }
            else if(difficulty == 3)
            {
                ChangeHard();
            }

            return stringDifficulty[difficulty];
        }
        public static int IntDifficulty(string difficulty)
        {

            if (difficulty == "Dễ")
            {
                ChangeEasy();
                return 1;
            }
            else if (difficulty == "Bình Thường")
            {
                ChangeMedium();
                return 2;
            }
            else if (difficulty == "Khó")
            {
                ChangeHard();
                return 3;
            }
            else return 2;

        }

    }
}

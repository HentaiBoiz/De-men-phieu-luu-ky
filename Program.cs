using System;
using System.Windows.Forms;
using static DeMenPhieuLuuKy.PlayerProfile;
using static DeMenPhieuLuuKy.Difficulty;

namespace DeMenPhieuLuuKy
{
    static class Program
    {
        public static String playerNameData = null;
        public static int globalScore = 0;

        public static Title_Screen titleScreen;
        private static SaveData saveData;

        public static string SaveFolderPath = null;
        public static string SaveFilePath = null;

        //Level2
        public static int tempDamage = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetCompatibleTextRenderingDefault(false);
            titleScreen = new Title_Screen();
            Application.Run(titleScreen);

        }

        public static void AutoSave(int score, String _levelName)
        {
            saveData = new SaveData();
            globalScore += score;
            saveData.FindAndDelete(playerNameData);
            saveData.AddNewPlayer(playerNameData, globalScore, _levelName, StringDifficulty(difficulty), playerGobalHealth, playerPower, playerJumpSpeed);
            saveData.ExportToExcel();
            saveData.Close();
        }
    }
}

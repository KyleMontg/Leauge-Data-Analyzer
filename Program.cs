using Microsoft.VisualBasic.ApplicationServices;
using static League_Data_Analyzer.Main;

namespace League_Data_Analyzer
{
    internal static class Program
    {
        public static List<GameDataModel> gameData = new();
        public static List<APIKeysModel> keys = new();
        public static List<UserModel> users = new();
        public static UserModel? selectedProfile;
        public static string? selectedApiKey;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoadKeys();
            LoadUsers();
            selectedApiKey = keys.Count() > 0 ? keys[0].APIKey : null;
            Application.Run(new Main());
        }
        public static void LoadKeys()
        {
            Program.keys = SQLData.LoadAPIKeys();        }
        public static void LoadUsers()
        {
            users = SQLData.LoadUser();
        }
        public static void LoadGameData()
        {
            if (String.IsNullOrEmpty(selectedProfile?.PUID))
            {
                throw new Exception("No profile selected");
            }
            else
            {
                gameData = SQLData.LoadGameData(selectedProfile.PUID);
            }
        }
        public static string FormatStringDate(string unixDate)
        {
            long milisecDate = long.Parse(unixDate);
            DateTime date = DateTimeOffset.FromUnixTimeMilliseconds(milisecDate).UtcDateTime;
            return date.ToString("MM/dd/yyyy");
        }
    }
}
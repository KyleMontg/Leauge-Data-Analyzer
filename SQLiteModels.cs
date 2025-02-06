using System.Security.Cryptography.X509Certificates;

namespace League_Data_Analyzer
{
    public class UserModel
    {
        public string PUID { get; set; }
        public string GameName { get; set; }
        public string TagLine { get; set; }
        public int Icon { get; set; }
        public override string ToString()
        {
            return GameName + "#" + TagLine;
        }
    }
    public class GameRecordModel
    {
        public string GameID { get; set; }
        public string GameType { get; set; }
        public string Date { get; set; } // unix time stamp
    }
    public class APIKeysModel
    {
        public string APIKey { get; set; }
    }
    public class ChampionModel
    {
        public int ChampionID { get; set; }
        public string ChampionName { get; set; }
        public string ChampionIcon { get; set; }
    }
    public class GameDataModel
    {
        public string GameID { get; set; }
        public string PUID { get; set; }
        public int ChampionID { get; set; }
        public int Won { get; set; } // 1 for win, 0 for loss
        public int Gold { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int DamageStructures { get; set; }
        public int DamageChampions { get; set; }
    }
}

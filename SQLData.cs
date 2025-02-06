using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace League_Data_Analyzer
{
    public class SQLData
    {

        //USERS
        public static List<UserModel> LoadUser()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from User", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User (PUID, TagLine, GameName, Icon) values (@PUID, @TagLine, @GameName, @Icon)", user);
            }
        }
        //CHAMPIONS
        public static List<ChampionModel> LoadChampion()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ChampionModel>("select * from Champion", new DynamicParameters());
                return output.ToList();
            }
        }
        public static ChampionModel ChampionLookup(int ChampionID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ChampionModel>("select * from Champion where ChampionID = @ChampionID", new { ChampionID });
                return output.ToArray()[0];
            }
        }
        public static void SaveChampion(ChampionModel champ)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Champion (ChampionID, ChampionName, ChampionIcon) values (@ChampionID, @ChampionName, @ChampionIcon)", champ);
            }
        }
        //APIKEYS
        public static List<APIKeysModel> LoadAPIKeys()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<APIKeysModel>("select * from APIKeys", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveAPIKey(APIKeysModel key)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into APIKeys (APIKey) values (@APIKey)", key);
            }
        }
        public static void DeleteAPIKey(APIKeysModel key)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from APIKeys where APIKey = @APIKey", key);
            }
        }
        public static void DeleteAPIKey(string keyString) // Overload for string input
        {
            APIKeysModel key = new();
            key.APIKey = keyString;
            DeleteAPIKey(key);
        }
        //GAMERECORD
        public static List<GameRecordModel> LoadGameRecords()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<GameRecordModel>("select * from GameRecord", new DynamicParameters());
                return output.ToList();
            }
        }
        public static GameRecordModel GameRecordLookup(string GameID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<GameRecordModel>("select * from GameRecord where GameID = @GameID", new { GameID });
                return output.ToArray()[0];
            }
        }
        public static void SaveGameRecord(GameRecordModel game)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into GameRecord (GameID, GameType, Date) values (@GameID, @GameType, @Date)", game);
            }
        }
        //GAMEDATA
        public static List<GameDataModel> LoadGameData(string PUID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<GameDataModel>("select * from GameData where PUID = @PUID", new { PUID });
                return output.ToList();
            }
        }
        public static GameDataModel GameDataLookup(string GameID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<GameDataModel>("select * from GameData where GameID = @GameID", new { GameID });
                return output.ToArray()[0];
            }
        }
        public static void SaveGameData(GameDataModel gameData)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into GameData (GameID, PUID, ChampionID, Won, Gold, Kills, Deaths, Assists, DamageStructures, DamageChampions) values (@GameID, @PUID, @ChampionID, @Won, @Gold, @Kills, @Deaths, @Assists, @DamageStructures, @DamageChampions)", gameData);
            }
        }
        private static string LoadConnectionString(string id = "StatsDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
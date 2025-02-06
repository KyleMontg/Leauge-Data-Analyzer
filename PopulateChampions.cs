using System.Text.Json;

namespace League_Data_Analyzer
{
    public static class ChampionJson
    {
        public static async void LoadChampionJson()
        {
            await using FileStream fs = File.OpenRead(@".\Assets\champion.json");
            ChampionData championDict = JsonSerializer.Deserialize<ChampionData>(fs);
            var championArray = championDict.data.Values.ToArray(); 
            foreach (var champ in championArray)
            {
                    ChampionModel champion = new();
                    champion.ChampionID = int.Parse(champ.key);
                    champion.ChampionName = champ.name;
                    champion.ChampionIcon = champ.id;
                SQLData.SaveChampion(champion);
            }
        }
        public class ChampionData() 
        { 
            public class Champion()
            {
                public string key { get; set; } // champion id
                public string name { get; set; } //champion name
                public string id { get; set; }
            }
            public Dictionary<string, Champion> data { get; set; }
        }
    }
}

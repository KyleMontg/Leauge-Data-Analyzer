using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace League_Data_Analyzer
{
    public class APIRequests
    {
        public static class RiotAPI
        {
            public static async Task<UserData> getUserDataAsync(string gameName, string tagLine, string apiKey)
            {
                string url = "https://americas.api.riotgames.com/riot/account/v1/accounts/by-riot-id/" + gameName + "/" + tagLine + "?api_key=" + apiKey; // url for puuid request
                HttpClient client = new HttpClient();
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    var json = await response.Content.ReadAsStringAsync();
                    UserData ud = JsonSerializer.Deserialize<UserData>(json);
                    url = $"https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-puuid/{ud.puuid}?api_key={apiKey}";
                    response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    json = await response.Content.ReadAsStringAsync();
                    UserPicture up = JsonSerializer.Deserialize<UserPicture>(json);
                    ud.icon = up.profileIconId;
                    return ud;
                }
                catch (HttpRequestException e) //***Handle Exections needed
                {
                    throw e;
                }

            }
            public class UserData
            {
                public string puuid { get; set; }
                public string gameName { get; set; }
                public string tagLine { get; set; }
                public int? icon { get; set; }
            }
            public class UserPicture
            {
                public int profileIconId { get; set; }
            };
            public static async Task<List<Match>> getMatchDataAsync(string puid, string apiKey) // Defualt 20 matches
            {
                string url = $"https://americas.api.riotgames.com/lol/match/v5/matches/by-puuid/{puid}/ids?start=0&count=20&api_key={apiKey}";
                HttpClient client = new HttpClient();
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    var json = await response.Content.ReadAsStringAsync();
                    string[] matchList = JsonSerializer.Deserialize<string[]>(json);
                    List<Match> matches = [];
                    foreach (string match in matchList)
                    {
                        string matchUrl = $"https://americas.api.riotgames.com/lol/match/v5/matches/{match}?api_key={apiKey}";
                        response = await client.GetAsync(matchUrl);
                        response.EnsureSuccessStatusCode();
                        json = await response.Content.ReadAsStringAsync();
                        Match matchData = JsonSerializer.Deserialize<Match>(json);
                        matches.Add(matchData);
                    }
                    return matches;
                }
                catch (HttpRequestException e)
                {
                    throw e;
                }
            }
            public class Match
            {
                public Info info { get; set; }
                public Metadata metadata { get; set; }
            }
            public class Metadata
            {
                public string matchId { get; set; }
                public string[] participants { get; set; }
            }
                public class Info
            {
                public long gameCreation { get; set; }    // Unix timestamp
                public string gameMode { get; set; }
                public List<Participants> participants { get; set; }
            }
            public class Participants
            {
                public bool win { get; set; }
                public int goldEarned { get; set; }
                public int kills { get; set; }
                public int assists { get; set; }
                public int deaths { get; set; }
                public int totalDamageDealtToChampions { get; set; }
                public int damageDealtToBuildings { get; set; }
                public int championId { get; set; }
                public string puuid { get; set; }
            }
        }
    }
}

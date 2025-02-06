using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_Data_Analyzer
{
    public partial class StatisticDisplay : Form
    {
        public StatisticDisplay()
        {
            InitializeComponent();
            Program.LoadGameData();
            loadGameView();
        }
        private async void loadMatches_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Program.selectedApiKey) || String.IsNullOrEmpty(Program.selectedProfile?.PUID))
            {
                MessageBox.Show("Please select a profile and API key");
            }
            else
            {
                try
                {
                    var matches = await APIRequests.RiotAPI.getMatchDataAsync(Program.selectedProfile.PUID, Program.selectedApiKey); //List of matches
                    foreach (var rawMatchData in matches)
                    {
                        GameRecordModel match = new();
                        match.GameID = rawMatchData.metadata.matchId;
                        match.GameType = rawMatchData.info.gameMode;
                        match.Date = rawMatchData.info.gameCreation.ToString();
                        try
                        {
                            SQLData.SaveGameRecord(match);
                        }
                        catch
                        {
                            //Duplicate Entry
                        }
                        var userData = rawMatchData.info.participants[0];
                        foreach (var participant in rawMatchData.info.participants)
                        {
                            if (participant.puuid == Program.selectedProfile.PUID)
                            {
                                userData = participant;
                                break;
                            }
                        }
                        int won = userData.win ? 1 : 0;
                        GameDataModel gameData = gameDataConstructor
                            (
                            match.GameID,
                            Program.selectedProfile.PUID,
                            userData.championId,
                            won,
                            userData.goldEarned,
                            userData.kills,
                            userData.deaths,
                            userData.assists,
                            userData.damageDealtToBuildings,
                            userData.totalDamageDealtToChampions
                            );
                        try
                        {
                            SQLData.SaveGameData(gameData);
                        }
                        catch
                        {
                            //Duplicate Entry
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //handle error(Invalid data base stuf anbd http maybe invalid profile exc)
                }
                Program.LoadGameData();
                loadGameView();
            }
        }

        private void loadGameView()
        {
            gameView.Items.Clear();
            foreach (var game in Program.gameData)
            {
                if (game.PUID == Program.selectedProfile.PUID)
                {
                    string date = Program.FormatStringDate(SQLData.GameRecordLookup(game.GameID).Date);
                    string champion = SQLData.ChampionLookup(game.ChampionID).ChampionName;
                    string kda = getKDA(game.Kills, game.Deaths, game.Assists).ToString("0.00");
                    string win = game.Won == 1 ? "Win" : "Loss";
                    ListViewItem item = new ListViewItem(new string[] { game.GameID, champion, win, kda, date });
                    gameView.Items.Add(item);
                }
            }
        }
        private float getKDA(int killsInt, int deathsInt, int assistsInt)
        {
            float kills = (float)killsInt;
            float deaths = (float)deathsInt;
            float assists = (float)assistsInt;
            float kda = 0;
            if (deaths == 0)
            {
                kda = kills + deaths;
            }
            else if (kills != 0 || assists != 0)
            {
                kda = (kills + assists) / deaths;
            }
            return kda;
        }
        private GameDataModel gameDataConstructor(string gameId, string puid, int championId, int won, int gold, int kills, int deaths, int assists, int damageStruc, int damageChamp)
        {
            GameDataModel data = new();
            data.GameID = gameId;
            data.PUID = puid;
            data.ChampionID = championId;
            data.Won = won;
            data.Gold = gold;
            data.Kills = kills;
            data.Deaths = deaths;
            data.Assists = assists;
            data.DamageStructures = damageStruc;
            data.DamageChampions = damageChamp;
            return data;
        }

        private void gameView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gameView.SelectedItems.Count > 0)
            {
                LoadForm(new StatsSub(gameView.SelectedItems[0].Text));
            }
        }
        public void LoadForm(object Form)
        {
            if (this.statPanel.Controls.Count > 0)
            {
                this.statPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.statPanel.Controls.Add(f);
            this.statPanel.Tag = f;
            f.Show();
        }
    }
}

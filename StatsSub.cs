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
    public partial class StatsSub : Form
    {
        public StatsSub(string gameId)
        {
            InitializeComponent();
            GameDataModel gameData = SQLData.GameDataLookup(gameId);
            GameRecordModel gameRecord = SQLData.GameRecordLookup(gameId);
            setLabels
                (
                gameData.Won,
                gameRecord.GameType,
                gameData.DamageStructures,
                gameData.DamageChampions,
                gameData.Kills,
                gameData.Deaths,
                gameData.Assists,
                gameRecord.Date
                );
            setChampPic(gameData.ChampionID);
        }
        private void setLabels(int won, string type, int structDamage, int champDamage, int kills, int deaths, int assists, string date)
        {
            gameTypeLabel.Text = type;
            gameStatusLabel.Text = won == 1 ? "Victory" : "Defeat";
            damageStructLabel.Text += structDamage.ToString();
            damageChampLabel.Text += champDamage.ToString();
            killsLabel.Text += kills.ToString();
            deathsLabel.Text += deaths.ToString();
            assistsLabel.Text += assists.ToString();
            dateLabel.Text += Program.FormatStringDate(date);


        }
        private void setChampPic(int champID)
        {
            ChampionModel champ = SQLData.ChampionLookup(champID);
            champLabel.Text = champ.ChampionName;
            string iconPath = "League_Data_Analyzer.Assets.ChampionIcons." + champ.ChampionIcon + ".png";
            var assembly = Assembly.GetExecutingAssembly();
            try
            {
                using (Stream stream = assembly.GetManifestResourceStream(iconPath))
                {
                    champPicBox.Image = Image.FromStream(stream);
                }
            }
            catch
            {
                champPicBox.Image = null;
                MessageBox.Show("Error loading champion image");
            }
        }

    }
}

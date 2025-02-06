using System.Data.SQLite;
using System.Windows.Forms;
using static League_Data_Analyzer.Main;

namespace League_Data_Analyzer
{
    public partial class ManageUsers : Form
    {
        private Main main;
        public ManageUsers(Main main)
        {
            this.main = main;
            InitializeComponent();
        }

        private async void addProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(gameNameBox.Text) || String.IsNullOrEmpty(tagLineBox.Text))
                {
                    MessageBox.Show("One Or More Fields Empty");
                }
                else if (String.IsNullOrEmpty(Program.selectedApiKey))
                {
                    MessageBox.Show("No API Keys Found, Please Add One");
                }
                else
                {
                    var userData = await APIRequests.RiotAPI.getUserDataAsync(gameNameBox.Text, tagLineBox.Text, Program.selectedApiKey);
                    UserModel user = new();
                    user.GameName = userData.gameName;
                    user.TagLine = userData.tagLine;
                    user.PUID = userData.puuid;
                    user.Icon = userData.icon.Value;
                    SQLData.SaveUser(user);
                    Program.LoadUsers();
                    main.profileSelectLoad();
                }
            }
            catch (HttpRequestException httpEx)
            {
                string message = "";
                int errorCode = (int)httpEx.StatusCode.Value;
                if (errorCode == 400) //
                {
                    message = "Bad request";
                }
                else if (errorCode == 403)// Wrong API Key,
                {
                    message = "Invalid API Key";
                }
                else if (errorCode == 404) // Valid API Key, Not valid gamename or tagline
                {
                    message = "Invalid Game Name or Tag";
                }
                else if (errorCode == 429)
                {
                    message = "Please Wait To Submit Again";
                }
                else
                {
                    message = httpEx.StatusCode.ToString();
                }
                MessageBox.Show($"{message}");
            }
            catch (Exception sqlEx)
            {
                MessageBox.Show($"Profile Already Exist");
            }

        }

    }
}

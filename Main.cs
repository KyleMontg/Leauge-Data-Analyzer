using System.Reflection;
namespace League_Data_Analyzer
{
    public partial class Main : Form
    {
        private bool inStatsForm = false;
        public Main()
        {
            InitializeComponent();
            //ChampionJson.LoadChampionJson();
            LoadForm(new ManageUsers(this));
            profileSelectLoad();
        }
        public void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        public void profileSelectLoad()
        {
            profileSelect.Items.Clear();
            if (Program.users.Count() > 0)
            {
                foreach (UserModel user in Program.users)
                {
                    profileSelect.Items.Add(user);
                }
                profileSelect.SelectedIndex = 0;
            }
        }

        private void profileSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var currUser = (UserModel)profileSelect.Items[profileSelect.SelectedIndex];
            Program.selectedProfile = currUser;
            string iconPath = "League_Data_Analyzer.Assets.UserIcons." + currUser.Icon + ".png";
            try
            {
                using (Stream stream = assembly.GetManifestResourceStream(iconPath))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
            catch
            {
                pictureBox1.Image = null;
                MessageBox.Show("Error loading profile image");
            }
            if (inStatsForm)
            {
                LoadForm(new StatisticDisplay());
            }
        }

        private void addAPIButton_Click(object sender, EventArgs e)
        {
            inStatsForm = false;
            LoadForm(new keyManager());
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            inStatsForm = false;
            LoadForm(new ManageUsers(this));
        }
        private void statsButton_Click(object sender, EventArgs e)
        {
            inStatsForm = true;
            LoadForm(new StatisticDisplay());
        }
    }
}

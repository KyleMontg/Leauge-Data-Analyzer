using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_Data_Analyzer
{
    public partial class keyManager : Form
    {
        public keyManager()
        {
            InitializeComponent();
            selectedKey.Text = Program.selectedApiKey;
            loadKeyView();
        }
        private void addKeyButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(keyBox.Text))
            {
                APIKeysModel key = new();
                key.APIKey = keyBox.Text;
                try
                {
                    SQLData.SaveAPIKey(key);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Key already exists");
                }
                keyBox.Text = "";
                Program.LoadKeys();
                loadKeyView();
            }
        }
        private void loadKeyView()
        {
            keyView.Items.Clear();
            foreach (APIKeysModel key in Program.keys)
            {
                var item = new ListViewItem(new string[] { key.APIKey });
                keyView.Items.Add(item);
            }
        }
        private void useKeyButton_Click(object sender, EventArgs e)
        {
            if (Program.keys.Count() > 0)
            {
                Program.selectedApiKey = keyView.SelectedItems[0].Text;
                selectedKey.Text = Program.selectedApiKey;
            }
        }
        private void removeSelected_Click(object sender, EventArgs e)
        {
            if (Program.keys.Count() > 0)
            {
                string key = keyView.SelectedItems[0].Text;
                SQLData.DeleteAPIKey(key);
                selectedKey.Text = "";
                Program.selectedApiKey = "";
                Program.LoadKeys();
                loadKeyView();
            }
        }
    }
}

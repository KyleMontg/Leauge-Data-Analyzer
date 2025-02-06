namespace League_Data_Analyzer
{
    partial class StatisticDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            gameView = new ListView();
            GameId = new ColumnHeader();
            champIcon = new ColumnHeader();
            gameResult = new ColumnHeader();
            kda = new ColumnHeader();
            date = new ColumnHeader();
            loadMatches = new Button();
            statPanel = new Panel();
            SuspendLayout();
            // 
            // gameView
            // 
            gameView.Columns.AddRange(new ColumnHeader[] { GameId, champIcon, gameResult, kda, date });
            gameView.FullRowSelect = true;
            gameView.HideSelection = true;
            gameView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            gameView.Location = new Point(12, 12);
            gameView.MultiSelect = false;
            gameView.Name = "gameView";
            gameView.Size = new Size(253, 397);
            gameView.Sorting = SortOrder.Descending;
            gameView.TabIndex = 0;
            gameView.UseCompatibleStateImageBehavior = false;
            gameView.View = View.Details;
            gameView.SelectedIndexChanged += gameView_SelectedIndexChanged;
            // 
            // GameId
            // 
            GameId.Width = 0;
            // 
            // champIcon
            // 
            champIcon.Tag = "";
            champIcon.Text = "Champion";
            champIcon.Width = 70;
            // 
            // gameResult
            // 
            gameResult.Text = "Result";
            gameResult.Width = 50;
            // 
            // kda
            // 
            kda.Text = "KDA";
            kda.Width = 50;
            // 
            // date
            // 
            date.Text = "Date Played";
            date.Width = 80;
            // 
            // loadMatches
            // 
            loadMatches.Location = new Point(65, 415);
            loadMatches.Name = "loadMatches";
            loadMatches.Size = new Size(136, 23);
            loadMatches.TabIndex = 1;
            loadMatches.Text = "Load Recent Matches";
            loadMatches.UseVisualStyleBackColor = true;
            loadMatches.Click += loadMatches_Click;
            // 
            // statPanel
            // 
            statPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statPanel.AutoSize = true;
            statPanel.Location = new Point(281, 12);
            statPanel.MinimumSize = new Size(500, 400);
            statPanel.Name = "statPanel";
            statPanel.Size = new Size(500, 400);
            statPanel.TabIndex = 2;
            // 
            // StatisticDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(statPanel);
            Controls.Add(loadMatches);
            Controls.Add(gameView);
            Name = "StatisticDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView gameView;
        private ColumnHeader champIcon;
        private ColumnHeader gameResult;
        private ColumnHeader kda;
        private ColumnHeader date;
        private Button loadMatches;
        private Panel statPanel;
        private ColumnHeader GameId;
    }
}
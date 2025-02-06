namespace League_Data_Analyzer
{
    partial class StatsSub
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
            gameStatusLabel = new Label();
            gameTypeLabel = new Label();
            killsLabel = new Label();
            deathsLabel = new Label();
            assistsLabel = new Label();
            damageStructLabel = new Label();
            damageChampLabel = new Label();
            champPicBox = new PictureBox();
            dateLabel = new Label();
            champLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)champPicBox).BeginInit();
            SuspendLayout();
            // 
            // gameStatusLabel
            // 
            gameStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gameStatusLabel.AutoSize = true;
            gameStatusLabel.Font = new Font("Gadugi", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameStatusLabel.Location = new Point(180, 56);
            gameStatusLabel.Name = "gameStatusLabel";
            gameStatusLabel.Size = new Size(150, 35);
            gameStatusLabel.TabIndex = 0;
            gameStatusLabel.Text = "Won/Lost";
            // 
            // gameTypeLabel
            // 
            gameTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gameTypeLabel.AutoSize = true;
            gameTypeLabel.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameTypeLabel.Location = new Point(217, 115);
            gameTypeLabel.Name = "gameTypeLabel";
            gameTypeLabel.Size = new Size(70, 16);
            gameTypeLabel.TabIndex = 1;
            gameTypeLabel.Text = "Game Type";
            // 
            // killsLabel
            // 
            killsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            killsLabel.AutoSize = true;
            killsLabel.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            killsLabel.Location = new Point(40, 195);
            killsLabel.Name = "killsLabel";
            killsLabel.Size = new Size(55, 21);
            killsLabel.TabIndex = 2;
            killsLabel.Text = "Kills: ";
            // 
            // deathsLabel
            // 
            deathsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deathsLabel.AutoSize = true;
            deathsLabel.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deathsLabel.Location = new Point(15, 341);
            deathsLabel.Name = "deathsLabel";
            deathsLabel.Size = new Size(80, 21);
            deathsLabel.TabIndex = 3;
            deathsLabel.Text = "Deaths: ";
            // 
            // assistsLabel
            // 
            assistsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            assistsLabel.AutoSize = true;
            assistsLabel.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assistsLabel.Location = new Point(18, 268);
            assistsLabel.Name = "assistsLabel";
            assistsLabel.Size = new Size(77, 21);
            assistsLabel.TabIndex = 4;
            assistsLabel.Text = "Assists: ";
            // 
            // damageStructLabel
            // 
            damageStructLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            damageStructLabel.AutoSize = true;
            damageStructLabel.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            damageStructLabel.Location = new Point(180, 268);
            damageStructLabel.Name = "damageStructLabel";
            damageStructLabel.Size = new Size(218, 21);
            damageStructLabel.TabIndex = 5;
            damageStructLabel.Text = "Damage To Structures: ";
            // 
            // damageChampLabel
            // 
            damageChampLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            damageChampLabel.AutoSize = true;
            damageChampLabel.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            damageChampLabel.Location = new Point(180, 341);
            damageChampLabel.Name = "damageChampLabel";
            damageChampLabel.Size = new Size(225, 21);
            damageChampLabel.TabIndex = 6;
            damageChampLabel.Text = "Damage To Champions: ";
            // 
            // champPicBox
            // 
            champPicBox.Location = new Point(15, 12);
            champPicBox.Name = "champPicBox";
            champPicBox.Size = new Size(100, 100);
            champPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            champPicBox.TabIndex = 7;
            champPicBox.TabStop = false;
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(311, 12);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(94, 17);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date Played:  ";
            // 
            // champLabel
            // 
            champLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            champLabel.AutoSize = true;
            champLabel.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            champLabel.Location = new Point(15, 115);
            champLabel.Name = "champLabel";
            champLabel.Size = new Size(101, 16);
            champLabel.TabIndex = 9;
            champLabel.Text = "Champion Played";
            // 
            // StatsSub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(494, 394);
            ControlBox = false;
            Controls.Add(champLabel);
            Controls.Add(dateLabel);
            Controls.Add(champPicBox);
            Controls.Add(damageChampLabel);
            Controls.Add(damageStructLabel);
            Controls.Add(assistsLabel);
            Controls.Add(deathsLabel);
            Controls.Add(killsLabel);
            Controls.Add(gameTypeLabel);
            Controls.Add(gameStatusLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StatsSub";
            ((System.ComponentModel.ISupportInitialize)champPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameStatusLabel;
        private Label gameTypeLabel;
        private Label killsLabel;
        private Label deathsLabel;
        private Label assistsLabel;
        private Label damageStructLabel;
        private Label damageChampLabel;
        private PictureBox champPicBox;
        private Label dateLabel;
        private Label champLabel;
    }
}
namespace League_Data_Analyzer
{
    partial class ManageUsers
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
            GameNameLabel = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            addProfile = new Button();
            gameNameBox = new TextBox();
            tagLineBox = new TextBox();
            tagLineLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // GameNameLabel
            // 
            GameNameLabel.AutoSize = true;
            GameNameLabel.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameNameLabel.Location = new Point(36, 187);
            GameNameLabel.Name = "GameNameLabel";
            GameNameLabel.Size = new Size(118, 22);
            GameNameLabel.TabIndex = 1;
            GameNameLabel.Text = "Game Name:";
            GameNameLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // addProfile
            // 
            addProfile.Location = new Point(181, 292);
            addProfile.Name = "addProfile";
            addProfile.Size = new Size(75, 23);
            addProfile.TabIndex = 4;
            addProfile.Text = "Add ";
            addProfile.UseVisualStyleBackColor = true;
            addProfile.Click += addProfile_Click;
            // 
            // gameNameBox
            // 
            gameNameBox.ForeColor = Color.Black;
            gameNameBox.Location = new Point(167, 194);
            gameNameBox.Name = "gameNameBox";
            gameNameBox.Size = new Size(100, 23);
            gameNameBox.TabIndex = 8;
            // 
            // tagLineBox
            // 
            tagLineBox.Location = new Point(167, 229);
            tagLineBox.Name = "tagLineBox";
            tagLineBox.Size = new Size(100, 23);
            tagLineBox.TabIndex = 9;
            // 
            // tagLineLabel
            // 
            tagLineLabel.AutoSize = true;
            tagLineLabel.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagLineLabel.Location = new Point(69, 230);
            tagLineLabel.Name = "tagLineLabel";
            tagLineLabel.Size = new Size(85, 22);
            tagLineLabel.TabIndex = 11;
            tagLineLabel.Text = "Tag Line:";
            tagLineLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(tagLineLabel);
            Controls.Add(tagLineBox);
            Controls.Add(gameNameBox);
            Controls.Add(addProfile);
            Controls.Add(GameNameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label GameNameLabel;
        private FileSystemWatcher fileSystemWatcher1;
        private Button addProfile;
        private TextBox tagLineBox;
        private TextBox gameNameBox;
        private Label tagLineLabel;
    }
}
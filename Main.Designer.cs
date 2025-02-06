namespace League_Data_Analyzer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TopPanel = new Panel();
            statsButton = new Button();
            addAPIButton = new Button();
            pictureBox1 = new PictureBox();
            profileSelect = new ComboBox();
            label1 = new Label();
            addUserButton = new Button();
            label2 = new Label();
            mainPanel = new Panel();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.AccessibleRole = AccessibleRole.MenuBar;
            TopPanel.AutoSize = true;
            TopPanel.BackColor = Color.FromArgb(5, 95, 156);
            TopPanel.Controls.Add(statsButton);
            TopPanel.Controls.Add(addAPIButton);
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Controls.Add(profileSelect);
            TopPanel.Controls.Add(label1);
            TopPanel.Controls.Add(addUserButton);
            TopPanel.Controls.Add(label2);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Margin = new Padding(0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1080, 78);
            TopPanel.TabIndex = 0;
            // 
            // statsButton
            // 
            statsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statsButton.AutoSize = true;
            statsButton.Location = new Point(944, 43);
            statsButton.Name = "statsButton";
            statsButton.Size = new Size(80, 25);
            statsButton.TabIndex = 6;
            statsButton.Text = "View Stats";
            statsButton.UseVisualStyleBackColor = true;
            statsButton.Click += statsButton_Click;
            // 
            // addAPIButton
            // 
            addAPIButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addAPIButton.Location = new Point(995, 12);
            addAPIButton.MinimumSize = new Size(50, 25);
            addAPIButton.Name = "addAPIButton";
            addAPIButton.Size = new Size(80, 25);
            addAPIButton.TabIndex = 5;
            addAPIButton.Text = "Add API Key";
            addAPIButton.UseVisualStyleBackColor = true;
            addAPIButton.Click += addAPIButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // profileSelect
            // 
            profileSelect.DropDownHeight = 400;
            profileSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            profileSelect.DropDownWidth = 136;
            profileSelect.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileSelect.FormattingEnabled = true;
            profileSelect.IntegralHeight = false;
            profileSelect.ItemHeight = 16;
            profileSelect.Location = new Point(67, 48);
            profileSelect.Name = "profileSelect";
            profileSelect.Size = new Size(138, 24);
            profileSelect.TabIndex = 1;
            profileSelect.SelectedIndexChanged += profileSelect_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 25);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 2;
            label1.Text = "Current Profile";
            // 
            // addUserButton
            // 
            addUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addUserButton.Location = new Point(912, 12);
            addUserButton.Margin = new Padding(0);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(80, 25);
            addUserButton.TabIndex = 0;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Courier New", 30F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(234, 25);
            label2.Name = "label2";
            label2.Size = new Size(668, 46);
            label2.TabIndex = 3;
            label2.Text = "League Statistical Analyzer";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(202, 231, 250);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 78);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1080, 531);
            mainPanel.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 609);
            Controls.Add(mainPanel);
            Controls.Add(TopPanel);
            Name = "Main";
            Text = "Form1";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Button addUserButton;
        private Label label2;
        private Label label1;
        private ComboBox profileSelect;
        private Panel mainPanel;
        private PictureBox pictureBox1;
        private Button addAPIButton;
        private Button statsButton;
    }
}

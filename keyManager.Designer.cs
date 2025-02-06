namespace League_Data_Analyzer
{
    partial class keyManager
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
            keyView = new ListView();
            keyContent = new ColumnHeader();
            label1 = new Label();
            keyBox = new TextBox();
            addKeyButton = new Button();
            removeSelected = new Button();
            useKeyButton = new Button();
            label2 = new Label();
            selectedKey = new Label();
            SuspendLayout();
            // 
            // keyView
            // 
            keyView.Columns.AddRange(new ColumnHeader[] { keyContent });
            keyView.Location = new Point(29, 35);
            keyView.Name = "keyView";
            keyView.Size = new Size(271, 295);
            keyView.TabIndex = 0;
            keyView.UseCompatibleStateImageBehavior = false;
            keyView.View = View.Details;
            // 
            // keyContent
            // 
            keyContent.Text = "API Keys";
            keyContent.Width = 280;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 172);
            label1.Name = "label1";
            label1.Size = new Size(77, 22);
            label1.TabIndex = 1;
            label1.Text = "API Key:";
            // 
            // keyBox
            // 
            keyBox.Location = new Point(500, 172);
            keyBox.Name = "keyBox";
            keyBox.Size = new Size(100, 23);
            keyBox.TabIndex = 2;
            // 
            // addKeyButton
            // 
            addKeyButton.Location = new Point(512, 201);
            addKeyButton.Name = "addKeyButton";
            addKeyButton.Size = new Size(75, 23);
            addKeyButton.TabIndex = 3;
            addKeyButton.Text = "Add Key";
            addKeyButton.UseVisualStyleBackColor = true;
            addKeyButton.Click += addKeyButton_Click;
            // 
            // removeSelected
            // 
            removeSelected.BackColor = Color.White;
            removeSelected.Location = new Point(168, 336);
            removeSelected.Name = "removeSelected";
            removeSelected.Size = new Size(120, 25);
            removeSelected.TabIndex = 4;
            removeSelected.Text = "Remove Selected";
            removeSelected.UseVisualStyleBackColor = false;
            removeSelected.Click += removeSelected_Click;
            // 
            // useKeyButton
            // 
            useKeyButton.Location = new Point(42, 336);
            useKeyButton.Name = "useKeyButton";
            useKeyButton.Size = new Size(120, 25);
            useKeyButton.TabIndex = 5;
            useKeyButton.Text = "Use Selected";
            useKeyButton.UseVisualStyleBackColor = true;
            useKeyButton.Click += useKeyButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 65);
            label2.Name = "label2";
            label2.Size = new Size(203, 22);
            label2.TabIndex = 6;
            label2.Text = "Currently Selected Key:";
            // 
            // selectedKey
            // 
            selectedKey.AutoSize = true;
            selectedKey.Location = new Point(576, 71);
            selectedKey.Name = "selectedKey";
            selectedKey.Size = new Size(0, 15);
            selectedKey.TabIndex = 7;
            // 
            // keyManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(selectedKey);
            Controls.Add(label2);
            Controls.Add(useKeyButton);
            Controls.Add(removeSelected);
            Controls.Add(addKeyButton);
            Controls.Add(keyBox);
            Controls.Add(label1);
            Controls.Add(keyView);
            Name = "keyManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView keyView;
        private ColumnHeader keyContent;
        private Label label1;
        private TextBox keyBox;
        private Button addKeyButton;
        private Button removeSelected;
        private Button useKeyButton;
        private Label label2;
        private Label selectedKey;
    }
}
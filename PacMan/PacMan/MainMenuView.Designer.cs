namespace PacMan
{
    partial class MainMenuView
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.LeaderboardsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pac Man";
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(14, 138);
            this.ResumeButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(186, 39);
            this.ResumeButton.TabIndex = 1;
            this.ResumeButton.Text = "Resume game";
            this.ResumeButton.UseVisualStyleBackColor = true;
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(14, 89);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(5);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(186, 39);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "New game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // LeaderboardsButton
            // 
            this.LeaderboardsButton.Location = new System.Drawing.Point(14, 187);
            this.LeaderboardsButton.Margin = new System.Windows.Forms.Padding(5);
            this.LeaderboardsButton.Name = "LeaderboardsButton";
            this.LeaderboardsButton.Size = new System.Drawing.Size(186, 39);
            this.LeaderboardsButton.TabIndex = 1;
            this.LeaderboardsButton.Text = "Leaderboards";
            this.LeaderboardsButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(14, 236);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(186, 39);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Location = new System.Drawing.Point(14, 52);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(186, 29);
            this.PlayerNameTextBox.TabIndex = 2;
            this.PlayerNameTextBox.Text = "Insert Name";
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(220, 301);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LeaderboardsButton);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainMenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button LeaderboardsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
    }
}
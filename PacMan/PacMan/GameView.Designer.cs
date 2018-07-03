namespace PacMan
{
    partial class GameView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PacManPictureBox = new System.Windows.Forms.PictureBox();
            this.PinkPhantomPictureBox = new System.Windows.Forms.PictureBox();
            this.RedPhantomPictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacManPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkPhantomPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPhantomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // PacManPictureBox
            // 
            this.PacManPictureBox.Image = global::PacMan.Properties.Resources.pacman_right;
            this.PacManPictureBox.InitialImage = global::PacMan.Properties.Resources.pacman_right;
            this.PacManPictureBox.Location = new System.Drawing.Point(213, 126);
            this.PacManPictureBox.Name = "PacManPictureBox";
            this.PacManPictureBox.Size = new System.Drawing.Size(16, 16);
            this.PacManPictureBox.TabIndex = 1;
            this.PacManPictureBox.TabStop = false;
            // 
            // PinkPhantomPictureBox
            // 
            this.PinkPhantomPictureBox.Image = global::PacMan.Properties.Resources.pink_left1;
            this.PinkPhantomPictureBox.Location = new System.Drawing.Point(490, 145);
            this.PinkPhantomPictureBox.Name = "PinkPhantomPictureBox";
            this.PinkPhantomPictureBox.Size = new System.Drawing.Size(16, 16);
            this.PinkPhantomPictureBox.TabIndex = 1;
            this.PinkPhantomPictureBox.TabStop = false;
            // 
            // RedPhantomPictureBox
            // 
            this.RedPhantomPictureBox.Image = global::PacMan.Properties.Resources.red_left1;
            this.RedPhantomPictureBox.Location = new System.Drawing.Point(329, 228);
            this.RedPhantomPictureBox.Name = "RedPhantomPictureBox";
            this.RedPhantomPictureBox.Size = new System.Drawing.Size(16, 16);
            this.RedPhantomPictureBox.TabIndex = 1;
            this.RedPhantomPictureBox.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(825, 24);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(47, 13);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 749);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.RedPhantomPictureBox);
            this.Controls.Add(this.PinkPhantomPictureBox);
            this.Controls.Add(this.PacManPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameView";
            this.Text = "GameView";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameView_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacManPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkPhantomPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPhantomPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox PacManPictureBox;
        private System.Windows.Forms.PictureBox PinkPhantomPictureBox;
        private System.Windows.Forms.PictureBox RedPhantomPictureBox;
        private System.Windows.Forms.Label ScoreLabel;
    }
}
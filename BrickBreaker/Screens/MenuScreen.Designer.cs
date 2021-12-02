namespace BrickBreaker
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.highscoresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(325, 60);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(233, 77);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Start";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(325, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(233, 77);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // instructionsButton
            // 
            this.instructionsButton.BackColor = System.Drawing.Color.Transparent;
            this.instructionsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.instructionsButton.FlatAppearance.BorderSize = 0;
            this.instructionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.instructionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.instructionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsButton.ForeColor = System.Drawing.Color.White;
            this.instructionsButton.Location = new System.Drawing.Point(325, 143);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(233, 77);
            this.instructionsButton.TabIndex = 2;
            this.instructionsButton.Text = "How to Play";
            this.instructionsButton.UseVisualStyleBackColor = false;
            this.instructionsButton.Click += new System.EventHandler(this.instructionsButton_Click);
            this.instructionsButton.MouseEnter += new System.EventHandler(this.instructionsButton_MouseEnter);
            this.instructionsButton.MouseLeave += new System.EventHandler(this.instructionsButton_MouseLeave);
            // 
            // highscoresButton
            // 
            this.highscoresButton.BackColor = System.Drawing.Color.Transparent;
            this.highscoresButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.highscoresButton.FlatAppearance.BorderSize = 0;
            this.highscoresButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.highscoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.highscoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoresButton.ForeColor = System.Drawing.Color.White;
            this.highscoresButton.Location = new System.Drawing.Point(325, 226);
            this.highscoresButton.Name = "highscoresButton";
            this.highscoresButton.Size = new System.Drawing.Size(233, 77);
            this.highscoresButton.TabIndex = 4;
            this.highscoresButton.Text = "Highscores";
            this.highscoresButton.UseVisualStyleBackColor = false;
            this.highscoresButton.Click += new System.EventHandler(this.highscoresButton_Click);
            this.highscoresButton.MouseEnter += new System.EventHandler(this.highscoresButton_MouseEnter);
            this.highscoresButton.MouseLeave += new System.EventHandler(this.highscoresButton_MouseLeave);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.mainbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.highscoresButton);
            this.Controls.Add(this.instructionsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button instructionsButton;
        private System.Windows.Forms.Button highscoresButton;
    }
}
